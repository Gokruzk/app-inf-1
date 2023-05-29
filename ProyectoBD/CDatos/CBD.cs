using CEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace CDatos
{
    public class CBD
    {
        public string cadena = "Data Source = DESKTOP-2U77OBE\\SQLEXPRESS01; Initial Catalog = ESTUDIANTES; Integrated Security = True";
        public MySqlConnection connect = new MySqlConnection();
        public CBD() 
        {
            connect.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                connect.Open();
                Console.WriteLine("Connection Open");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Cerrar() 
        {
            try
            {
                connect.Close();
                Console.WriteLine("Connection Close");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}