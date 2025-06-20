using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpIntegrador.Datos;

namespace TpIntegrador
{
    public partial class formCuotasVencidas : Form
    {
        // Variables para la impresión
        private int currentPage = 0; // Para controlar la paginación
        public formCuotasVencidas()
        {
            InitializeComponent();

            this.printPreviewDialog1.Document = this.printDocument1;
            this.printDialog1.Document = this.printDocument1;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void formCuotasVencidas_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            MySqlConnection conexion = Conexion.getInstancia().CrearConexion();
            try
            {
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(
                    @"SELECT
                        CONCAT(s.nombre, ' ', s.apellido) AS 'Nombre ',
                        s.domicilio as 'Domicilio',
                        s.telefono as 'Teléfono',
                        s.email as 'Email',
                        p.fecha_vencimiento as 'F. Vto.',
                        p.fecha_pago as 'F. Pago',
                        p.monto_pago as 'Monto'
                      FROM
                        pagosocio p
                      INNER JOIN (
                          SELECT
                              id_socio,
                              MAX(fecha_pago) AS ultima_fecha_pago
                          FROM
                              pagosocio
                          GROUP BY
                              id_socio
                      ) AS ultimos_pagos
                        ON p.id_socio = ultimos_pagos.id_socio
                        AND p.fecha_pago = ultimos_pagos.ultima_fecha_pago
                      INNER JOIN
                        socios s ON s.id = p.id_socio
                      WHERE
                        p.fecha_vencimiento < CURDATE();",
                    conexion
                );
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("No hay cuotas vencidas para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las cuotas vencidas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Reiniciar la paginación para una nueva impresión
            currentPage = 0;

            // Mostrar el diálogo de vista previa
            printPreviewDialog1.ShowDialog();

        }

        // Evento PagePrint del printDocument1: Aquí dibujamos el contenido de la página
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Definir fuentes y colores
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font bodyFont = new Font("Arial", 8, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Márgenes y área de impresión
            int startX = e.MarginBounds.Left;
            int startY = e.MarginBounds.Top;
            int currentY = startY; // Variable para controlar la posición vertical de dibujo

            // Definir un StringFormat para truncar el texto y añadir puntos suspensivos
            StringFormat sfTruncate = new StringFormat();
            sfTruncate.Trimming = StringTrimming.EllipsisCharacter; // Añade "..." al final
            sfTruncate.FormatFlags = StringFormatFlags.NoWrap;       // No permite el ajuste de línea
            sfTruncate.LineAlignment = StringAlignment.Center;       // Centra verticalmente el texto en la celda
            sfTruncate.Alignment = StringAlignment.Near;             // Alineación a la izquierda por defecto

            // --- Título del Documento (solo en la primera página) ---
            // ANTES DE ESTE CAMBIO, TU CÓDIGO TENÍA 'offset'. LO HE QUITADO PARA SIMPLIFICAR LA LÓGICA DE 'currentY'.
            // 'currentPage' ahora no es solo para paginación, sino que mantiene el índice de la fila en la grilla.
            // Si currentPage es 0, estamos en la primera página.
            if (currentPage == 0) // <--- CONDICIÓN CLAVE
            {
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                string title = "Listado de Cuotas Vencidas";
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                e.Graphics.DrawString(title, titleFont, brush, startX + (e.MarginBounds.Width / 2) - (titleSize.Width / 2), currentY);
                currentY += (int)titleSize.Height + 20; // Espacio después del título
            }

            // --- Dibujar los encabezados de la grilla ---
            int headerHeight = 25; // Altura fija para los encabezados
            int rowHeight = 20;    // <--- NUEVO: Altura fija para las filas de datos (asumiendo una sola línea)

            // Calcular anchos de columna (asegúrate de que los anchos sumen el totalWidth)
            int visibleColumnCount = dataGridView1.Columns.Cast<DataGridViewColumn>().Count(c => c.Visible);
            float totalWidth = e.MarginBounds.Width;
            float[] columnWidths = new float[dataGridView1.ColumnCount];
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Visible)
                {
                    // Puedes ajustar estos pesos si quieres que algunas columnas sean más anchas.
                    // Por ejemplo: if (dataGridView1.Columns[i].HeaderText == "Domicilio") columnWidths[i] = totalWidth * 0.3f; else ...
                    columnWidths[i] = totalWidth / visibleColumnCount;
                }
            }

            float currentHeaderX = startX;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].Visible)
                {
                    RectangleF headerRect = new RectangleF(currentHeaderX, currentY, columnWidths[i], headerHeight);
                    e.Graphics.FillRectangle(Brushes.LightGray, headerRect); // Fondo para encabezados
                    e.Graphics.DrawRectangle(Pens.Black, headerRect.X, headerRect.Y, headerRect.Width, headerRect.Height); // Borde

                    // NUEVO: StringFormat para los encabezados (pueden ser diferentes a los de los datos)
                    StringFormat headerSF = new StringFormat();
                    headerSF.Alignment = StringAlignment.Center;      // Centrar texto horizontalmente
                    headerSF.LineAlignment = StringAlignment.Center;  // Centrar texto verticalmente
                    headerSF.Trimming = StringTrimming.EllipsisCharacter; // Truncar si el encabezado es muy largo

                    e.Graphics.DrawString(dataGridView1.Columns[i].HeaderText, headerFont, brush, headerRect, headerSF);
                    currentHeaderX += columnWidths[i];
                }
            }
            currentY += headerHeight + 5; // Espacio después de los encabezados
            e.Graphics.DrawLine(Pens.Black, startX, currentY, startX + e.MarginBounds.Width, currentY); // Línea divisoria
            currentY += 10; // Espacio después de la línea

            // --- Dibujar las Filas de Datos (con paginación y truncamiento) ---
            // 'currentPage' ahora representa el índice de la primera fila del DataGridView a imprimir en esta PÁGINA

            // REEMPLAZA EL 'while (currentPage < dataGridView1.Rows.Count)' CON ESTE 'for'
            // for (int r = currentPage; r < dataGridView1.Rows.Count; r++) { ... }
            // Esto te permite saber la fila actual global (`r`) y también usar `currentPage` como el inicio de la página.
            for (int r = currentPage; r < dataGridView1.Rows.Count; r++)
            {
                // Si la fila es la de "nueva entrada" del DataGridView, saltarla.
                if (dataGridView1.Rows[r].IsNewRow)
                {
                    // No incrementes currentPage aquí, se manejará al final de la página.
                    continue;
                }

                // Verificar si la fila actual cabe en la página
                // Si la posición vertical actual + la altura de la fila excede el límite inferior del margen
                if (currentY + rowHeight > e.MarginBounds.Bottom - 10) // Restamos un poco más para evitar que quede pegado al borde
                {
                    e.HasMorePages = true; // Indica que se necesita otra página
                    currentPage = r; // La próxima página comenzará con esta fila ('r')
                    return; // Salir de este evento. PrintDocument volverá a llamar a PrintPage.
                }

                // Dibujar las celdas de la fila
                float currentCellX = startX;
                for (int c = 0; c < dataGridView1.ColumnCount; c++) // 'c' para columnas
                {
                    if (dataGridView1.Columns[c].Visible)
                    {
                        object cellValueObject = dataGridView1.Rows[r].Cells[c].Value; // <-- Usa 'r' para el índice de fila
                        string cellValue = "";

                        // Formatear fechas
                        if (cellValueObject is DateTime)
                        {
                            DateTime dateValue = (DateTime)cellValueObject;
                            cellValue = dateValue.ToString("dd/MM/yyyy");
                        }
                        else
                        {
                            cellValue = cellValueObject?.ToString() ?? "";
                        }

                        // Rectángulo para dibujar el contenido de la celda
                        // Usa 'rowHeight' aquí
                        RectangleF cellRect = new RectangleF(currentCellX, currentY, columnWidths[c], rowHeight);
                        e.Graphics.DrawRectangle(Pens.LightGray, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height); // Borde ligero

                        // Dibuja el texto de la celda dentro del rectángulo, usando sfTruncate
                        e.Graphics.DrawString(cellValue, bodyFont, brush, cellRect, sfTruncate); // <-- ¡APLICA sfTruncate aquí!
                        currentCellX += columnWidths[c];
                    }
                }
                currentY += rowHeight; // Avanzar el Y por la altura fija de la fila
            }

            // NUEVO: Después de que el bucle 'for' termine, esto significa que todas las filas visibles caben
            // o ya hemos saltado con e.HasMorePages = true; y return;
            e.HasMorePages = false;
            currentPage = 0; // Resetear para futuras impresiones
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
