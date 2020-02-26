using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradosCentigrados
{
    public partial class Form1 : Form
    {
        grados objGra = new grados();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objGra.comvertir = (comGrados.Text);
            objGra.cantidad = int.Parse(texCantidad.Text.ToString());
            objGra.convertirGrados();
            texResultado.Text = objGra.cantidad.ToString();
        }
    }
}
