using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Xml.Linq;

namespace CDatos
{
    public class ClDatos
    {
        CBD objBD = new CBD();
        public List<Entidades> GetData()
        {
            List<Entidades> DatosEst = new List<Entidades>();
            try
            {
                objBD.Abrir();
                SqlCommand sql = new SqlCommand("SELECT * FROM TblDatos");
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    Entidades objEnt = new Entidades()
                    {
                        idEstu = Convert.ToInt16(reader["idEstu"]),
                        NombreE = Convert.ToString(reader["Nombre"]),
                        ApellidoE = Convert.ToString(reader["Apellido"])
                    };
                    DatosEst.Add(objEnt);
                }
            }
            catch
            {
                DatosEst = null;
                objBD.Cerrar();
            }
            return DatosEst;
        }

        public void Register(Entidades DatosEst)
        {
            try
            {
                objBD.Abrir();
                string query = "INSERT INTO TblDatos(Nombre, Apellido) VALUES('" + DatosEst.NombreE + "', '" + DatosEst.ApellidoE + "')";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                objBD.Abrir();
                string query = "DELETE FROM TblDatos WHERE idEstu = '" + id + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Entidades Search(int id)
        {
            Entidades DatosEst = new Entidades();
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM TblDatos WHERE idEstu = '" + id + "'";
                SqlCommand sql = new SqlCommand(query, objBD.connect);
                sql.ExecuteNonQuery();

                SqlDataReader reader = sql.ExecuteReader();

                while (reader.Read())
                {
                    Entidades objEnt = new Entidades()
                    {
                        idEstu = Convert.ToInt16(reader["idEstu"]),
                        NombreE = Convert.ToString(reader["Nombre"]),
                        ApellidoE = Convert.ToString(reader["Apellido"])
                    };
                    DatosEst = objEnt;
                }
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                DatosEst = null;
                objBD.Cerrar();
                MessageBox.Show(e.Message);
            }
            return DatosEst;
        }
    }
}
