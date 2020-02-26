using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaYPerimetroDeUnCuadrado
{
    public partial class Form1 : Form
    {

        Cuadrado objPerimetro = new Cuadrado();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objPerimetro.lado = int.Parse(textBox1.Text.ToString());
            objPerimetro.PerimetroArea();
            texArea.Text = objPerimetro.area.ToString();
            texPerimetro.Text = objPerimetro.perimetro.ToString();
        }
    }
}
