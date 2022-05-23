using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using ConsultasDis;



namespace ConsultasDis
{
    internal class ConexionBD
    {
        string cadena = " Data Source= JOSELUIS;Initial Catalog= PRUEBAS;Integrated Security= true";

        public SqlConnection conectar = new SqlConnection();


        public ConexionBD()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                MessageBox.Show("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema en la conexioN " + ex);
            }
        }
        public void cerrar()
        {
            conectar.Close();
        }

        public void AgregarDistribuidor(string id, string fecha, string nombre, string apPaterno, string apMaterno,
             string calle, string numero, string colonia)
        {
            string consulta = "EXEC PROC_AGREGARDISTRIBUIDOR '" + id + "','" + fecha + "' ,'" + nombre + "','"
                + apPaterno + "','" + apMaterno + "','" + calle + "','" + numero + "','" + colonia + "';";


            using (SqlConnection conn = new SqlConnection(cadena))
            {
                try
                {

                    SqlCommand ejecuta = new SqlCommand(consulta, conn);
                    conn.Open();
                    ejecuta.ExecuteNonQuery();
                    MessageBox.Show("Regristo Guardado Correctamente",MessageBoxIcon.Information.ToString());

                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("TU ERROR ES :" + ex.ToString());
                }
                conn.Close();

            }

        }


        


    }
}
