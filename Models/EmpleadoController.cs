using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2.Models
{
    public class EmpleadoController
    {
        private static readonly string ConnectionString = "Server=FELIPE\\SQLEXPRESS;Database=itesDB;Trusted_Connection=True";
        public static List<Empleados> GetEmpleados() 
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand cmd;
            SqlDataReader reader;
            string sql = "SELECT * FROM Empleados";
            List<Empleados> empleados = new List<Empleados>();
            try
            {
                //crea la coneccion
                sqlConnection.Open();
                MessageBox.Show("La conecxion con la base de datos esta establecida", "Conecxion a la base de datos"); //EN esta forma el primero es la leyenda y el segundo el titulo
                cmd = new SqlCommand(sql, sqlConnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    empleados.Add(new Empleados(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetDecimal(4), reader.GetInt32(5), reader.GetInt32(6)));
                }
                cmd.Dispose();
                reader.Close();//Para borrar de memoria los objetos es necesario sino la coneccion que nosotros abriumos queda abeirta, queda andando 
                sqlConnection.Dispose();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return empleados;
        }
    }
}
