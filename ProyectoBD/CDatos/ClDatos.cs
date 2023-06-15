using System;
using System.Collections.Generic;
using CEntidades;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

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

        public void Update(Entidades DatosEst)
        {
            try
            {
                objBD.Abrir();
                string query = "UPDATE TblDatos SET Nombre = '" + DatosEst.NombreE + "', Apellido = '" + DatosEst.ApellidoE + "' WHERE idESTU = '" + DatosEst.idEstu + "'";
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

                if (reader.Read())
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

        public SqlDataAdapter SearchAll()
        {
            Entidades DatosEst = new Entidades();
            SqlDataAdapter adp = new SqlDataAdapter("", objBD.connect);
            try
            {
                objBD.Abrir();
                string query = "SELECT * FROM TblDatos";
                adp = new SqlDataAdapter(query, objBD.connect);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                objBD.Cerrar();
            }
            catch (Exception e)
            {
                objBD.Cerrar();
                MessageBox.Show(e.Message);
            }
                return adp;
        }
    }
}
