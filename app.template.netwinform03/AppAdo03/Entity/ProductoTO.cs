using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdo03.Entity
{
    public class ProductoTO
    {

        public ProductoTO()
        {
            IdProducto = 0;
            IdProveedor = 0;
            IdCategoria = 0;
            Precio = 0;
            Stock = 0;
        }


        //propiedades
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int IdProveedor { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

    }
}
