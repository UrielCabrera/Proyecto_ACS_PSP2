using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Carrito
    {
        private ArrayList ventas;
        private double total;

        public Carrito()
        {
            ventas = new ArrayList();
            total = 0;
        }

        //   public  string MostrarProductos(){return productos.ToString();}
        public double GetTotal() { return total; }

        /*   private void SetTotal(){
               Producto temp;
               total = 0;
               int i,n=productos.Count;
               double aux;
               for (i = 0; i < n;i++){
                   temp = (Producto)productos[i];
                   aux = (double)noArticulos[i];
                   //total=total+temp.GetPrecio()*aux;
               }
           }*/
        public void Add(Venta venta)
        {
            ventas.Add(venta);
            total = total + venta.GetsubTotal();
        }
        internal Venta GetVenta(int indx)
        {
            return (Venta)ventas[indx];
        }
        //internal int GetNoPiezas(int x) { return (int)noArticulos[x]; }
    }
}
