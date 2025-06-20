using TpIntegrador.Datos;
using System.Runtime.InteropServices;

namespace TpIntegrador
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ocultarUsuario(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void mostrarUsuario(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void ocultarPassword(object sender, EventArgs e)
        {
            if (txtPassword.Text == "PASSWORD")
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void mostrarPassword(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "PASSWORD";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            if (usuarios.ObtenerUsuarios(this.txtUsuario.Text, this.txtPassword.Text).Rows.Count > 0)
            {
                MessageBox.Show("Bienvenido " + this.txtUsuario.Text, "Hola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formMain mainForm = new formMain();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
