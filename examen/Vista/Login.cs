using Datos;
using System.Windows.Forms;
using Vista;


namespace Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (CodigoUsuariotextBox.Text == string.Empty)
            {
                errorProvider1.SetError(CodigoUsuariotextBox, "Por favor ingrese un codigo de usuario");
                CodigoUsuariotextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (Clavetext.Text == string.Empty)
            {

                errorProvider1.SetError(Clavetext, "Por favor ingrese una clave");
                Clavetext.Focus();
                return;
            }
            errorProvider1.Clear();


            UsuarioDatos userDatos = new UsuarioDatos();
            bool valido = await userDatos.loginAsync(CodigoUsuariotextBox.Text, Clavetext.Text);
            if (valido)
            {
                Menu formulario = new Menu();
                Hide();
                formulario.Show();


            }
            else
            {
                MessageBox.Show("Datos de usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancelarbutton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
} 