using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrito
{
    public partial class Form1 : Form
    {
        vehiculo objCarro = new vehiculo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCarro.tipo = (comTipo.Text);
            objCarro.TipoDeVehiculo();
            tecCuota.Text = objCarro.cantidad.ToString();
        }
    }
}
