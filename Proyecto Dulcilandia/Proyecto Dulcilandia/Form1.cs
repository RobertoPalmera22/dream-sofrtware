using MySql.Data.MySqlClient;

namespace Proyecto_Dulcilandia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection("Server=localhost; Database=dulcilandia; Uid=dream; Pwd=software;");
                conexion.Open();

                MySqlCommand comandar = new MySqlCommand();
                comandar.Connection = conexion;

                string consultar = "SELECT nombre, contraseña FROM usuarios WHERE nombre = '" + txt1.Text + "' AND contraseña = sha('" + txt2.Text + "')";

                comandar.CommandText = consultar;
                MySqlDataReader datos = comandar.ExecuteReader();

                if (datos.Read())
                {
                    MessageBox.Show("Bienvenido " + datos["nombre"] + "\nEspero tenga un buen día.");

                    Principal principal = new Principal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso Denegado");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + "\nIngrese algo correcto");
            }
        }
    }
}