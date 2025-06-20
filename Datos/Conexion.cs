using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TpIntegrador.Datos
{
    public class Conexion
    {

        // declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        private Conexion() // asignamos valores a las variables de la
        {
            // variables usadas para la repetición de líneas de código
            bool correcto = false;
            int mensaje;

            // creamos las variables para recibir los datos desde el teclado
            // =============================================================

            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";
            /*--------------------------------------------------------------
             * ciclo while para volver a repetir el ingreso de datos
             * la variable correcto la inicializamos para ingresar al ciclo
             * ------------------------------------------------------------*/

            while (correcto != true)
            {
                // Armamos los cuadros de dialogo para el ingreso de datos

                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL");

                /*________________________________________________________
                 * controlamos que los datos ingresados para acceder a MySQL sean correctos
                 *________________________________________________________*/

                mensaje = (int)MessageBox.Show("su ingreso: SERVIDOR = " + T_servidor + " PUERTO= " + T_puerto + " USUARIO: " +
                    T_usuario + " CLAVE: " + T_clave, "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (mensaje != 6) // el valor 6 corresponde al SI
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }

            // Reemplazamos los datos concretos que teniamos por las variables

            this.baseDatos = "proyecto";
            this.servidor = T_servidor; //"localhost";
            this.puerto = T_puerto; //"3306";
            this.usuario = T_usuario; //"root";
            this.clave = T_clave; //"123456";
        }
        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos + ";Charset=utf8mb4";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }

}
