using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehiculo
{
    public partial class Form1 : Form
    {
        Aereo objAviones = new Aereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(objAviones.arrancarMotor(texApagar.Text));            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            objAviones.numeroDeAlas = int.Parse(comAlas.Text);
            objAviones.numeroDeElices = int.Parse(comElices.Text);
            objAviones.color = comColor.Text;
            objAviones.numeroDeLlantas = int.Parse(comLLantas.Text);
            objAviones.tipoAereo = comAereo.Text;
            objAviones.tipoDeCombustible = comCombustible.Text;
            MessageBox.Show("la informacion del objeto" + comAereo.Text + "se guardo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           MessageBox.Show(objAviones.pararMotor(texApagar.Text));
        }
    }
}
