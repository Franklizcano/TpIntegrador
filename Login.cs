using TpIntegrador.Datos;

namespace TpIntegrador
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ocultarUsuario(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
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
    }
}
