using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Catalogo
{
    public partial class Form2 : Form{
        public int imxid;
        public Form2(){InitializeComponent();}
        private void Form2_Load(object sender, EventArgs e){  }
        internal void SetImagen(PictureBox pimage,int inx) { 
            pictureBox1.Image=pimage.Image;
            imxid = inx;  }
        internal void SetLabel(String lb) { label1.Text = lb; }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e){this.Hide();}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e){}
        private void Button1_Click(object sender, EventArgs e){//agrega el id al 
            StreamWriter agregar = File.AppendText("Texto.txt"); //abre el archivo
            agregar.WriteLine(imxid+",");  //agrega el idimage=idproducto de la sigmanera: id,
            agregar.Close(); //cierra el archivo

            StreamWriter agregarN = File.AppendText("Numeric.txt");
            agregarN.WriteLine(numericUpDown1.Value + ",");
            agregarN.Close();

            MessageBox.Show("Se añadio al carrito", "Añadir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
