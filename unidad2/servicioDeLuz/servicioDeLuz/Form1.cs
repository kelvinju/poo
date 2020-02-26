using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicioDeLuz
{
    public partial class Form1 : Form
    {
        recibo objTipo = new recibo();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objTipo.vivienda = (comVivienda.Text);
            objTipo.kw = int.Parse(texKw.Text.ToString());
            objTipo.kwConsumidos();
            texCosto.Text = objTipo.presio.ToString();
        }
        
    }
}
