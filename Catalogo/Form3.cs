using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Catalogo
{
    public partial class Form3 : Form
    {
        private Carrito carrito = new Carrito();
        private PictureBox[] cargarIm;
        private Venta[] arrayVentas;
        double total=0,totalid;
        public Form3(){InitializeComponent();}
        private void Form3_Load(object sender, EventArgs e){ 
            for (int h = 0; h < cargarIm.Length; h++){
                ListViewItem itemh = new ListViewItem("", h);
                itemh.SubItems.Add(carrito.GetVenta(h).GetProducto().GetDescripcion().Getnombre());
                itemh.SubItems.Add(Convert.ToString(carrito.GetVenta(h).GetProducto().GetDescripcion().Getprecio()) + " $");
                itemh.SubItems.Add(Convert.ToString(carrito.GetVenta(h).GetnoPiezas()));
                totalid = carrito.GetVenta(h).GetsubTotal();
                itemh.SubItems.Add(Convert.ToString(totalid) + " $");

                listView1.Items.AddRange(new ListViewItem[] { itemh });
                imageList1.Images.Add((cargarIm[h]).Image);
            }
            listView1.SmallImageList = imageList1;
        }

        internal void dameTotal(String name) { total = carrito.GetTotal(); }
        internal void AddListImg(PictureBox[] array) { cargarIm = array; }
        internal void AddProCarr(Venta[] ventas) {
            arrayVentas= ventas; 
            for (int p=0;p< arrayVentas.Length;p++) {carrito.Add(arrayVentas[p]);}
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            SistemaVentas formVentas = new SistemaVentas();
            formVentas.AgregarProducto(arrayVentas);
            formVentas.Show();
            this.Hide();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e) { this.Hide(); }
    }
}
