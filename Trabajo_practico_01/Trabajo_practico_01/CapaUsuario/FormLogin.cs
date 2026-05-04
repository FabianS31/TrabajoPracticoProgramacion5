using Trabajo_practico_01.CapaUsuario;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Trabajo_practico_01
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boton_aceptar_Click(object sender, EventArgs e)
        {

            string user = usuario_texto.Text.Trim();
            string pass = usuario_contraseña.Text.Trim();

            // Requisito del TP: Validar campos vacíos
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CapaDatos.Usuario usuarioNegocio = new CapaDatos.Usuario();

            // Requisito del TP: Validar contra SQL y redireccionar
            if (usuarioNegocio.ValidarUsuario(user, pass))
            {
                MessageBox.Show("Login Correcto");
                pagina_principal principal = new pagina_principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                // Requisito del TP: Mostrar error
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void usuario_nuevo_CheckedChanged(object sender, EventArgs e)
        {
            // Cambiamos checkBox1 por usuario_nuevo
            if (usuario_nuevo.Checked)
            {
                FormUsuarioNuevo formRegistro = new FormUsuarioNuevo();
                formRegistro.ShowDialog();

                // También aquí cambiamos el nombre para desmarcarlo
                usuario_nuevo.Checked = false;
            }
        }
    }
}
