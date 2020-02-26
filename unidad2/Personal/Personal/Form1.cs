using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal
{
    public partial class Form1 : Form
    {
        Persona objTipo = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form formulario = new formularioinformes();
            formulario.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
