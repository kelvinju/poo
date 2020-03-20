using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figuras_geometricas
{
    public partial class Form1 : Form
    {
        Cuadrado objCuadrito = new Cuadrado();
        Triangulo objTriangulito = new Triangulo();
        Circulo objCirculito = new Circulo();
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Cuadrado":
                    {

                        objCuadrito.Lado = float.Parse(texLado.Text.ToString());
                        objCuadrito.CalcularArea();
                        texArea.Text = objCuadrito.Area.ToString();
                        objCuadrito.calcularPerimetro();
                        texPerimetro.Text = objCuadrito.Perimetro.ToString();
                        break;
                    }

                case "Triangulo":
                    objTriangulito.Lado = float.Parse(texLado.Text.ToString());
                    objTriangulito.Altura = float.Parse(texLado.Text.ToString());
                    objTriangulito.CalcularArea();
                    texArea.Text = objTriangulito.Area.ToString();
                    objTriangulito.calcularPerimetro();
                    texPerimetro.Text = objTriangulito.Perimetro.ToString();
                    break;
                    
                           case "Circulo":
                    objCirculito.Lado = float.Parse(texLado.Text.ToString());
                    
                    objCirculito.CalcularArea();
                    texArea.Text = objCirculito.Area.ToString();
                    objCirculito.calcularPerimetro();
                    texPerimetro.Text = objCirculito.Perimetro.ToString();
                    break;
            
        }
                       
            

            
        
        }
    }
}
