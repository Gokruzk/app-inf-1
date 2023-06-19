using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CData
{
    public class CBD
    {
        readonly string BDD = "PRODUCTOS";
        public string SERVER = "DESKTOP-2U77OBE\\SQLEXPRESS", PSW = "nigel123";
        public string cadena;
        public SqlConnection connect = new SqlConnection();
        public CBD()
        {
            cadena = $"Data Source = {@SERVER}; Initial Catalog = {@BDD}; Integrated Security = True";
            connect.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                connect.Open();
                Console.WriteLine("Conexión abierta");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Cerrar()
        {
            try
            {
                connect.Close();
                Console.WriteLine("Conexión cerrada");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
