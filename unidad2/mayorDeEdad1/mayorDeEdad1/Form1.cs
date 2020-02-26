using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayorDeEdad1
{
    public partial class Form1 : Form
    {
        Persona objEdad = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objEdad.añoActual = int.Parse(DateTime.Today.Year.ToString());
            objEdad.mesActual = int.Parse(DateTime.Today.Month.ToString());
            objEdad.diaActual = int.Parse(DateTime.Today.Day.ToString());
            objEdad.años = int.Parse(dateAños.Value.Year.ToString());
            objEdad.mes = int.Parse(dateAños.Value.Month.ToString());
            objEdad.dia = int.Parse(dateAños.Value.Day.ToString());
            objEdad.grande();
            texEdad.Text = objEdad.mayorDeEdad.ToString();
            objEdad.mayorDeEdad = "";
            
        }
    }
}
