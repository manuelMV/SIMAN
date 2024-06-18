using MySql.Data.MySqlClient;

namespace SIMAN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        string tbl = "tbl_usuario";
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_usuario.Text;
            string clave = txt_clave.Text;
            if (InicioDeSecion(tbl, user, clave))
            {
                Home abrirHome = new Home();
                abrirHome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }

        }
        public static bool InicioDeSecion(string tbl, string usuario, string contraseña)
        {

            string consulta = $"SELECT * FROM {tbl} WHERE usuario = '{usuario}' AND contraseña = '{contraseña}';";
            MySqlConnection miconcexcion = Conexion.sqlConnection();
            miconcexcion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(consulta, miconcexcion);
                cmd.ExecuteNonQuery();
                int dato = Convert.ToInt32(cmd.ExecuteScalar());
                if (dato > 0)
                {
                    return true;
                }

                MessageBox.Show(consulta);
            }
            catch
            {
                return false;
            }
            return false;
        }

        
    }
}
