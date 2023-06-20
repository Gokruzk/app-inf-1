using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entity;

namespace CData
{

    public class ClData
    {
        CBD objBD = new CBD();
        Producto pData = new Producto();

        public Producto SearchProduct(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"SELECT * FROM Productos WHERE idProd = {@id}";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                if (reader.Read())
                {
                    Producto objEnt = new Producto()
                    {
                        idProd = Convert.ToInt16(reader["idProd"]),
                        NombrePro = Convert.ToString(reader["NombrePro"]),
                        Precio = Convert.ToInt16(reader["Precio"]),
                        Cantidad = Convert.ToInt16(reader["Cantidad"]),
                        Iva = Convert.ToDouble(reader["Iva"]),
                        TotalPrecio = Convert.ToDouble(reader["TotalPrecio"])
                    };
                    pData = objEnt;
                }
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                pData = null;
                Console.WriteLine(e.Message);
            }
            return pData;
        }

        //Ingreso de datos de Producto
        public void InsertProduct(Producto pData)
        {
            try
            {
                objBD.Abrir();
                string query = $"INSERT INTO Productos(NombrePro, Precio, Cantidad, Iva, TotalPrecio) VALUES('{@pData.NombrePro}', {@pData.Precio}, {@pData.Cantidad}, {@pData.Iva}, {@pData.TotalPrecio})";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Eliminar producto por ID
        public void DeleteProduct(int id)
        {
            try
            {
                objBD.Abrir();
                string query = $"DELETE FROM Productos WHERE idProdu = {@id})";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public SqlDataAdapter MostrarProduct()
        {
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM Productos";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return adp;
        }
    }
}
