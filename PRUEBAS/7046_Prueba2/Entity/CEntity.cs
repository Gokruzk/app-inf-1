using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Producto
    {
        public int idProd { get; set; }
        public string NombrePro { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public double Iva { get; set; }
        public double TotalPrecio { get; set; }
    }
}
