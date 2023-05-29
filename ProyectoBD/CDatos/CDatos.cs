using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace CDatos
{
    public class CDatos
    {
        CBD objBD = new CBD();
        public List<Entidades> GetData()
        {
            List<Entidades> DatosEst = new List<Entidades>();
            try
            {
                objBD.Abrir();
                MySqlCommand sql = new MySqlCommand("SELECT * FROM TblDatos", objBD.connect);
                MySqlDataReader reader = sql.ExecuteReader();
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
            catch (Exception ex)
            {
                DatosEst = null;
                objBD.Cerrar();
            }
            return DatosEst;
        }
    }
}
