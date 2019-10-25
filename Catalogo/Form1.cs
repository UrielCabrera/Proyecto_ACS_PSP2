using System;
using System.Windows.Forms;
using System.Data;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace Catalogo
{    
    public partial class Form1 : Form{
        public ArrayList galeria = new ArrayList();
        private Control control1=new Control();
        public Form1(){InitializeComponent();
            control1.AddControl();
        }
        private void Form1_Load(object sender, EventArgs e){
            label1.Text = control1.GetAlmacen().GetProducto(0).GetNombrePrecioDispo();
            label2.Text = control1.GetAlmacen().GetProducto(1).GetNombrePrecioDispo();
            label3.Text = control1.GetAlmacen().GetProducto(2).GetNombrePrecioDispo();
            label4.Text = control1.GetAlmacen().GetProducto(3).GetNombrePrecioDispo();
            label5.Text = control1.GetAlmacen().GetProducto(4).GetNombrePrecioDispo();
            label6.Text = control1.GetAlmacen().GetProducto(5).GetNombrePrecioDispo();
            label7.Text = control1.GetAlmacen().GetProducto(6).GetNombrePrecioDispo();
            label8.Text = control1.GetAlmacen().GetProducto(7).GetNombrePrecioDispo();
            label9.Text = control1.GetAlmacen().GetProducto(8).GetNombrePrecioDispo();
            label10.Text = control1.GetAlmacen().GetProducto(9).GetNombrePrecioDispo();
            label11.Text = control1.GetAlmacen().GetProducto(10).GetNombrePrecioDispo();
            label12.Text = control1.GetAlmacen().GetProducto(11).GetNombrePrecioDispo();
            label13.Text = control1.GetAlmacen().GetProducto(12).GetNombrePrecioDispo();
            label14.Text = control1.GetAlmacen().GetProducto(13).GetNombrePrecioDispo();
            label15.Text = control1.GetAlmacen().GetProducto(14).GetNombrePrecioDispo();
            label16.Text = control1.GetAlmacen().GetProducto(15).GetNombrePrecioDispo();
            label17.Text = control1.GetAlmacen().GetProducto(16).GetNombrePrecioDispo();
            label18.Text = control1.GetAlmacen().GetProducto(17).GetNombrePrecioDispo();

            galeria.Add(pictureBox1); galeria.Add(pictureBox2); galeria.Add(pictureBox3); galeria.Add(pictureBox4); galeria.Add(pictureBox5);
            galeria.Add(pictureBox6); galeria.Add(pictureBox7); galeria.Add(pictureBox8); galeria.Add(pictureBox9); galeria.Add(pictureBox10);
            galeria.Add(pictureBox11); galeria.Add(pictureBox12); galeria.Add(pictureBox13); galeria.Add(pictureBox14); galeria.Add(pictureBox15);
            galeria.Add(pictureBox15); galeria.Add(pictureBox16); galeria.Add(pictureBox17); galeria.Add(pictureBox18);
            TextWriter escribe = new StreamWriter("Texto.txt"); escribe.Close();
            TextWriter archivo2 = new StreamWriter("Numeric.txt");archivo2.Close();
            TextWriter archivo3 = new StreamWriter("Produccion.txt"); archivo3.Close();
            
        }

        private void ProductoDispon(int idPic){//OPCION1
            if (control1.GetAlmacen().GetProducto(idPic).GetInventario().GetExistencias() == 0){
                MessageBox.Show("Articulo no Disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else{
               Form2 f2 = new Form2();
                f2.SetImagen((PictureBox)galeria[idPic], idPic); //manda la imagen, el indice de la imagen y del producto
                f2.SetLabel(control1.GetAlmacen().GetProducto(idPic).GetDescripcion().ToString());
                f2.Show();
            }
        } 
        private void RadioButton1_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(0); }
        private void RadioButton2_CheckedChanged(object sender, EventArgs e){ tabControl1.SelectTab(1);}
        private void RadioButton3_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(2); }
        private void RadioButton4_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(3);  }
        private void RadioButton5_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(4); }
        private void RadioButton6_CheckedChanged(object sender, EventArgs e){tabControl1.SelectTab(5); }

        private void PictureBox1_Click(object sender, EventArgs e){
            ProductoDispon(0);
        }
        private void PictureBox2_Click(object sender, EventArgs e){
            ProductoDispon(1);
        }
        private void PictureBox3_Click(object sender, EventArgs e){DatosProducto f2 = new DatosProducto();
            ProductoDispon(2);
        }
        private void PictureBox4_Click(object sender, EventArgs e){
            ProductoDispon(3);
        }
        private void PictureBox5_Click(object sender, EventArgs e) {
           ProductoDispon(4);
        }
        private void PictureBox6_Click(object sender, EventArgs e) {
            ProductoDispon(5);
        }
        private void PictureBox7_Click(object sender, EventArgs e) {
            ProductoDispon(6);
        } 
        private void PictureBox8_Click(object sender, EventArgs e){
            ProductoDispon(7);
        }
        private void PictureBox9_Click(object sender, EventArgs e){
          //  ProductoDispon(8);
        }
        private void PictureBox10_Click(object sender, EventArgs e){
           // ProductoDispon(9);
        }
        private void PictureBox11_Click(object sender, EventArgs e){
            ProductoDispon(10);
        }
        private void PictureBox12_Click(object sender, EventArgs e){
            ProductoDispon(11);
        }
        private void PictureBox13_Click(object sender, EventArgs e){
            ProductoDispon(12);
        }
        private void PictureBox14_Click(object sender, EventArgs e) {
            ProductoDispon(13);
        }
        private void PictureBox15_Click(object sender, EventArgs e){
            ProductoDispon(14);
        }
        private void PictureBox16_Click(object sender, EventArgs e) {
            ProductoDispon(15);
        }
        private void PictureBox17_Click(object sender, EventArgs e){
            ProductoDispon(16);
        }
        private void PictureBox18_Click(object sender, EventArgs e){
            ProductoDispon(17);
        }
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e){
        }
        private void TabControl1_TabIndexChanged(object sender, EventArgs e) { }
        private void TabPage1_Click(object sender, EventArgs e) { }    
        private void GroupBox1_TabIndexChanged(object sender, EventArgs e) { }
        private void Label1_Click(object sender, EventArgs e){}
        private void Label5_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox5_Click_1(object sender, EventArgs e) { }
        private void PictureBox5_Click_2(object sender, EventArgs e){ }
        private void PictureBox6_Click_1(object sender, EventArgs e) { }
        private void PictureBox7_Click_1(object sender, EventArgs e) { }
        private void PictureBox12_Click_1(object sender, EventArgs e) { }
        private void MenuItem1_Click(object sender, EventArgs e){}
        
        private void Button1_Click(object sender, EventArgs e) {
            Form3 f3 = new Form3();
            int entaux,tam;
            ArrayList numLi = new ArrayList(); ArrayList numN = new ArrayList(); 
            string contenido = File.ReadAllText("Texto.txt");
            string contenido2 = File.ReadAllText("Numeric.txt");
            string[] lineas = contenido.Split(',');
            string[] lineas2 = contenido2.Split(',');
            foreach (string linea in lineas){numLi.Add(linea);}
            foreach (string linea2 in lineas2){numN.Add(linea2);}          
            tam = numLi.Count;
            PictureBox[] galeriaPic = new PictureBox[tam-1];
            Venta[] ventas = new Venta[tam-1];
            for (int j=0;j<tam-1;j++) {
                entaux = Convert.ToInt32(numLi[j]);//contiene los idProductos
                //entaux=idProducto
                galeriaPic[j] =(PictureBox) galeria[entaux]; 
                ventas[j] = new Venta(control1.GetAlmacen().GetProducto(entaux), Convert.ToInt32(numN[j]));
            }
            f3.AddListImg(galeriaPic);
            f3.AddProCarr(ventas);
            f3.Show();

        }
        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Activated(object sender, EventArgs e){}
        private void Form1_Leave(object sender, EventArgs e){}

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
