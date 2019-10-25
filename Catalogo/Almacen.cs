using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Almacen
    {
        private ArrayList productos;
        private ArrayList productoExistencia;
        private ArrayList productoAgotado;
        private int total;
        private int totalEx;
        private int totalAg;
        public Almacen()
        {
            productoAgotado = new ArrayList();
            productoExistencia = new ArrayList();
            productos = new ArrayList();
        }


        public void AddProducto(Producto p)
        {
            productos.Add(p); //Inventario paux=p.GetAlmacen();
            if (p.GetInventario().GetExistencias() == 0)
            {
                productoExistencia.Add(p);
            }
            else { productoAgotado.Add(p); }

            total = productos.Count;
            totalEx = productoExistencia.Count;
            totalAg = productoAgotado.Count;
        }

        public Producto[] GetProdcutoAgo()
        {
            Producto[] proAgotado = new Producto[productoAgotado.Count];
            for (int i = 0; i < productoAgotado.Count; i++)
            {
                proAgotado[i] = (Producto)productoAgotado[i];
            }
            return proAgotado;
        }

        public Producto[] GetProductoExi()
        {
            Producto[] proExistencia = new Producto[productoExistencia.Count];
            for (int i = 0; i < productoExistencia.Count; i++)
            {
                proExistencia[i] = (Producto)productoExistencia[i];
            }
            return proExistencia;
        }

        public ArrayList GetProductos()
        {
            return productos;
        }

        public Producto GetProducto(int index) { return (Producto)productos[index]; }

        public int GetTotal() { return total; }
    }
}
