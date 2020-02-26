using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vacaciones
{
    public partial class Form1 : Form
    {
        empleado objDias = new empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objDias.años = int.Parse(texCantidad.Text.ToString());
            objDias.trabajador();
            texAdicional.Text = objDias.años.ToString();
        }
    }
}
