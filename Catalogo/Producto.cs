using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Producto
    {
        private int id;
        private Descripcion productoDesc;
        private Inventario productoInv;


        public Producto(string nombre, double precio, int categoria, string material, int existencias, int id)
        {
            productoDesc = new Descripcion(nombre, precio, categoria, material);
            productoInv = new Inventario(existencias);
            this.id = id;
        }
        public int getId() { return id; }

        public string GetNombrePrecioDispo()
        {
            string cadPro = productoDesc.GetNombrePrecio() + productoInv.GetDisponible();
            return cadPro;
        }

        public Descripcion GetDescripcion()
        {
            return productoDesc;
        }

        public Inventario GetInventario()
        {
            return productoInv;
        }
    }
}
