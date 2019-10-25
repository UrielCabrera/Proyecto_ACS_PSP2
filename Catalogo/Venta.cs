using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Venta
    {
        private Producto producto;
        private int noPiezas;
        private int subTotal;

        public Venta(Producto producto, int noPiezas)
        {
            this.producto = producto;
            this.noPiezas = noPiezas;
            subTotal = Convert.ToInt32(producto.GetDescripcion().Getprecio() * noPiezas);
        }



        public int GetsubTotal() { return subTotal; }

        public int GetnoPiezas() { return noPiezas; }
        public Producto GetProducto() { return producto; }
    }
}
