using System.Data.SqlClient;
using System.Data;
using System.Text;
namespace ConsultasDis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cadena = "Data Source= JOSELUIS;Initial Catalog= PRUEBAS;Integrated Security= true";
            string id = string.Empty;
            id = txtID.Text;

            string consulta = "EXEC PROC_CONSULTARDISTRIBUIDOR '" + id + "';";
            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dataGridView1.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("TU ERROR ES :" + ex.ToString());
                }
                conn.Close();

            }




        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = string.Empty;
            string fechar = string.Empty;
            string nombre = string.Empty;
            string apPat = string.Empty;
            string apMat = string.Empty;
            string calle = string.Empty;
            string numero = string.Empty;
            string colonia = string.Empty;
            id = txtID.Text;
            fechar = txtFecha.Text;
            nombre = txtNombre.Text;
            apPat = txtApPat.Text;
            apMat = txtApMat.Text;
            calle = txtCalle.Text;
            numero = txtNumero.Text;
            colonia = txtcolonia.Text;

            ConexionBD conectar = new ConexionBD();

            conectar.AgregarDistribuidor(id,fechar,nombre,apPat,apMat,calle,numero,colonia);
            txtID.Text="";
            txtFecha.Text="";
            txtNombre.Text="";
            txtApPat.Text="";
            txtApMat.Text="";
            txtCalle.Text="";
            txtNumero.Text="";
            txtcolonia.Text="";


        }
    }
}