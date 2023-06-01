using CDatos;
using CEntidades;
using System.Collections.Generic;

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

        public Entidades SearchData(int id)
        {
            Entidades objEnt = new Entidades();
            return objCD.Search(id);
        }
    }
}