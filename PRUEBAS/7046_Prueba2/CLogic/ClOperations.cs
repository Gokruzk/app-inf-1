using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entity;
using CData;
namespace CLogic
{
    public class ClOperations
    {
        ClData objOP = new ClData();
        public void InsertProduct(Producto pData)
        {
            objOP.InsertProduct(pData);
        }
        public void DeleteProduct(int id)
        {
            objOP.DeleteProduct(id);
        }

        public SqlDataAdapter MostrarProduct()
        {
            return objOP.MostrarProduct();
        }

        public Producto SearchProduct(int id)
        {
            return objOP.SearchProduct(id);
        }
    }
}
