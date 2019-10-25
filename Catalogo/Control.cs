using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Control
    {
        private Almacen invIni;
        private Carrito carroForm1;
        private Producto p1 = new Producto("Aretes de pluma", 25.50, 1, "El material son plumas sinteticas de codorniz", 0, 0);
        private Producto p2 = new Producto("Collar de plumas", 52.2, 1, "El material son plumas sinteticas de avestruz", 50, 1);
        private Producto p3 = new Producto("Collar de plumas", 99.0, 1, "El material son plumas sinteticas de gallina", 10, 2);
        private Producto p4 = new Producto("Sombrero", 25, 1, "El material son plumas sinteticas sinteticas de colibri", 45, 3);
        private Producto p5 = new Producto("Tintero de pluma", 30, 2, "El material son plumas sinteticas de perico", 75, 4);
        private Producto p6 = new Producto("Moño de plumas", 45, 2, "El material son plumas sinteticas de gallina", 16, 5);
        private Producto p7 = new Producto("Penacho para niño", 20, 2, "El material son plumas sinteticas de quetzal", 20, 6);
        private Producto p8 = new Producto("Pajaro de madera y plumas", 10, 3, "El material son plumas sinteticas de pato", 10, 7);
        private Producto p9 = new Producto("Pajaro de papel y pluma", 150.23, 3, "El material son plumas sinteticas de avestruz", 71, 8);
        private Producto p10 = new Producto("Atrapa sueños para niña", 200, 3, "El material son plumas sinteticas de quetzal", 5, 9);
        private Producto p11 = new Producto("Pajaro de papel y pluma", 180, 4, "El material son plumas sinteticas de avestruz", 0, 10);
        private Producto p12 = new Producto("Lapicero de plumas", 4500, 4, "El material son plumas sinteticas de codorniz", 2, 11);
        private Producto p13 = new Producto("Sillas de plumas", 1200, 4, "El material son plumas sinteticasde perico", 1, 12);
        private Producto p14 = new Producto("Atrapa sueños", 720, 4, "El material son plumas sinteticas de pato", 12, 13);
        private Producto p15 = new Producto("Velas de plumas", 0.50, 5, "El material son plumas sinteticas de codorniz", 0, 14);
        private Producto p16 = new Producto("Mascara de plumas", 62, 5, "El material son plumas sinteticas de colibri", 17, 15);
        private Producto p17 = new Producto("Abanico de plumas", 25.50, 5, "El material son plumas sinteticas chinas", 78, 16);
        private Producto p18 = new Producto("Mascara de plumas", 25.50, 5, "El material son plumas sinteticas de codorniz", 120, 17);

        public Control()
        {
            invIni = new Almacen();
            carroForm1 = new Carrito();
        }
        public void AddControl()
        {
            invIni.AddProducto(p1); invIni.AddProducto(p2); invIni.AddProducto(p3); invIni.AddProducto(p4);
            invIni.AddProducto(p5); invIni.AddProducto(p6); invIni.AddProducto(p7); invIni.AddProducto(p8);
            invIni.AddProducto(p9); invIni.AddProducto(p10); invIni.AddProducto(p11); invIni.AddProducto(p12);
            invIni.AddProducto(p13); invIni.AddProducto(p14); invIni.AddProducto(p15); invIni.AddProducto(p16);
            invIni.AddProducto(p17); invIni.AddProducto(p18); //pcargados
        }

        public Almacen GetAlmacen() { return invIni; }
        public Carrito GetCarro() { return carroForm1; }

        public void iniciaForm2()
        {

            //Form2 f2 = new Form2();

        }

    }
}
