using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaResMulDiv
{
    public partial class Form1 : Form
    {
        Suma objSum = new Suma();
        Resta objRes = new Resta();
        Multiplicacion objMul = new Multiplicacion();
        Divicion objDiv = new Divicion();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objSum.Valor1 = float.Parse(texValor1.Text.ToString());
            objSum.Valor2 = float.Parse(texValor2.Text.ToString());
            objSum.sumas();
            texSuma.Text = objSum.Resultados.ToString();
            objRes.Valor1 = float.Parse(texValor1.Text.ToString());
            objRes.Valor2 = float.Parse(texValor2.Text.ToString());
            objRes.Restas();
            texResta.Text = objRes.Resultados.ToString();
            objMul.Valor1 = float.Parse(texValor1.Text.ToString());
            objMul.Valor2 = float.Parse(texValor2.Text.ToString());
            objMul.Multiplicaciones();
            texMultiplicacion.Text = objMul.Resultados.ToString();
            objDiv.Valor1 = float.Parse(texValor1.Text.ToString());
            objDiv.Valor2 = float.Parse(texValor2.Text.ToString());
            objDiv.Divisiones();
            texDivicion.Text = objDiv.Resultados.ToString();


        }
    }
}
