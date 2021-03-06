using MySql.Data.MySqlClient;

namespace Proyecto_Dulcilandia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txt2.UseSystemPasswordChar = true;
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dulcilandia; Uid=dream; Pwd=software;");
                conexion.Open();

                MySqlCommand comandar = new MySqlCommand();
                comandar.Connection = conexion;

                string consultar = "SELECT nombre, contrase?a FROM usuarios WHERE nombre = '" + txt1.Text + "' AND contrase?a = sha('" + txt2.Text + "')";

                comandar.CommandText = consultar;
                MySqlDataReader datos = comandar.ExecuteReader();

                if (datos.Read())
                {
                    MessageBox.Show("Bienvenido " + datos["nombre"] + "\nEspero tenga un buen d?a.");

                    Principal principal = new Principal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Nombre o contrase?a incorrecta", "Fallo al iniciar sesi?n",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void chick1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt2.UseSystemPasswordChar)
            {
                txt2.UseSystemPasswordChar = false;
            }
            else
            {
                txt2.UseSystemPasswordChar = true;
            }
        }
    }
}