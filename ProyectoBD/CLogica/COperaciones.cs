using CDatos;
using CEntidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CLogica
{
    public class COperaciones
    {
        ClDatos objCD = new ClDatos();

        public List<Entidades> Lista()
        {
            //List<Entidades> = DatosEst = new List<Entidades>();
            return objCD.GetData();
        }

        public void SetData(Entidades DatosEst)
        {
            objCD.Register(DatosEst);
        }

        public void DeleteData(int id)
        {
            objCD.Delete(id);
        }

        public void UpdateData(Entidades data)
        {
            objCD.Update(data);
        }

        public Entidades SearchData(int id)
        {
            Entidades objEnt = new Entidades();
            return objCD.Search(id);
        }

        public SqlDataAdapter SearchDataAll()
        {
            return objCD.SearchAll();
        }
    }
}