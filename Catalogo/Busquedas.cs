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
    public partial class Busquedas : Form
    {
        Venta ventaBusqueda;
        Producto productoBuscado;
        string[,] Lista = new string[200, 6];
        int filas = 0;
        public Busquedas()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.Text == "ARETES CARACOL")
            {
                pictureBox1.Image = Catalogo.Properties.Resources.caracol;
                l1.Text = "\n\nAretes artesanales con caracol natural \n\n";
                lblPrecio.Text = "$40.00";
            }

            if (comboBox1.Text == "PRENDEDOR GRANDE PAVO REAL")
            {
                pictureBox1.Image = Catalogo.Properties.Resources.pavogrande;
                l1.Text = "\n\nPrendedor para el cabello de pavo real grande \n\n";
                lblPrecio.Text = "$80.00";
            }
            if (comboBox1.Text == "PRENDEDOR CHICO PAVO REAL")
            {
                pictureBox1.Image = Catalogo.Properties.Resources.pavochico;
                l1.Text = "\n\nPrendedor para el cabello de tamaño peque{o \n\n$55.00";
                lblPrecio.Text = "$55.00";
            }
            if (comboBox1.Text == "PENACHO")
            {

                pictureBox1.Image = Catalogo.Properties.Resources.penacho;
                l1.Text = "\n\n\nPenacho color vino \n\n";
                lblPrecio.Text = "$300.00";
            }
            if (comboBox1.Text == "ATRAPA SUEÑOS")
            {
                pictureBox1.Image = Catalogo.Properties.Resources.atrapasueños;
                l1.Text = "\n\n\nAtrapa sueños lila \n\n";
                lblPrecio.Text = "$50.00";
            }

            if (comboBox1.Text == "COLLAR")
            {
                pictureBox1.Image = Catalogo.Properties.Resources.collar;
                l1.Text = "\n\n\nCollar de plumas \n\n";
                lblPrecio.Text = "$110.00";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
          /*  productoBuscado = new Producto(comboBox1.Text, lblPrecio.Text,);
                [filas, 0] = comboBox1.Text;
            Lista[filas, 1] = lblPrecio.Text;
            Lista[filas, 2] = txtCantidad.Text;
            Lista[filas, 3] = (float.Parse(txtCantidad.Text) * float.Parse(lblPrecio.Text)).ToString();
            dataGridView1.Rows.Add(Lista[filas, 0], Lista[filas, 1], Lista[filas, 2], Lista[filas, 3]);
            filas++;*/
        }
    }
}
