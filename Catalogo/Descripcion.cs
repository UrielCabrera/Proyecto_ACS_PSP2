using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Descripcion
    {
        private string nombre;
        private double precio;
        private string material;
        private int categoria;

        public Descripcion(string nombre, double precio, int categoria, string material)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.categoria = categoria;
            this.material = material;
        }
        public string Getnombre() { return nombre; }
        public double Getprecio() { return precio; }
        public string Getmaterial() { return material; }
        public string Getcategoria()
        {
            if (categoria == 1) { return "Dama"; }
            if (categoria == 2) { return "Caballero"; }
            if (categoria == 3) { return "Niña"; }
            if (categoria == 4) { return "Niño"; }
            if (categoria == 5) { return "Decoracion"; }
            if (categoria == 6) { return "Otro"; }
            return null;
        }
        public override string ToString()
        {
            string cadpro = "";
            cadpro = "\nNombre:" + nombre + "\nCategoria:" + Getcategoria() + "\n Precio:" + precio + " $" + "\n Material:" + material + "\n";
            return cadpro;
        }

        public string GetNombrePrecio()
        {
            string cadena1 = nombre + "\nPrecio:" + precio + " $";
            return cadena1;
        }
    }
}
