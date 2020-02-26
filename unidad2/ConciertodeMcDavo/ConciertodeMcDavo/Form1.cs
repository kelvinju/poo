using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConciertodeMcDavo
{
    public partial class Form1 : Form
    {
        Concierto objAistente = new Concierto();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            objAistente.asisten = (comPersonas.Text);
            objAistente.cantidad = int.Parse(comEntrada.Text.ToString());

            objAistente.contarEntradas();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            texbebes.Text = objAistente.bebes.ToString();
            texniños.Text = objAistente.niños.ToString();
            texadultos.Text = objAistente.adultos.ToString();
            textercera.Text = objAistente.mayores.ToString();
        }

        private void comEntrada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
