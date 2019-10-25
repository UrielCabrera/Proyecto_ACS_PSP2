using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Catalogo
{
    public partial class Factura : Form

    {
      

        public Factura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SistemaVentas venta = new SistemaVentas();
            DatosProducto datos = new DatosProducto();
            Busquedas busqueda = new Busquedas();
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Factura factura = new Factura();
            Portada portada = new Portada();
            factura.Close();
            portada.Close();
            busqueda.Close();
            datos.Close();
            venta.Close();
            form1.Close();
            form2.Close();
            form3.Close();
            this.Hide();
           
        }
    }
}
