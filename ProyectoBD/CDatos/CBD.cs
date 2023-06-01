using CEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace CDatos
{
    public class CBD
    {
        public string cadena = "Data Source=DESKTOP-2U77OBE\\SQLEXPRESS;Initial Catalog=ESTUDIANTE;User ID=sa;Password=nigell123";
        public SqlConnection connect = new SqlConnection();
        public CBD()
        {
            //connect.ConnectionString = Properties.Settings.Default.stringConnection;
            connect.ConnectionString = cadena;

        }
        public void Abrir()
        {
           connect.Open();
           Console.WriteLine("Connection Open");
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