using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglosarray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaracion de las variables
            int[] notas = new int[6];
            //especificar las notas
            notas[0] = 10;
            notas[1] = 10;
            notas[2] = 9;
            notas[3] = 10;
            notas[4] = 8;
            notas[5] = 6;
            int suma = 0;
            double promedio;
            //proceso
            comnotas.Items.Clear();
            //recorrer nuestro arreglo
            for(int i =0; i<=5;i++)
            {
                //mostrar las notas de los arreglos en el combobox
                comnotas.Items.Add(notas[i]);
                suma = suma + notas[i];
            }
            promedio = suma / 6;
            texPro.Text = Convert.ToString(promedio);
        }
    }
}
