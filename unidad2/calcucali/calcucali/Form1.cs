using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcucali
{
    public partial class Form1 : Form
    {
        Calificaciones objCalificaciones = new Calificaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objCalificaciones.califCapturada = int.Parse(texCali.Text.ToString());
            objCalificaciones.centerAprobacion();
            texCali.Text = "";
            MessageBox.Show("pon otra calificacion");
            texCali.Clear();
        }

        private void btnReportar_Click(object sender, EventArgs e)
        {
            texReprobados.Text = objCalificaciones.reprobados.ToString();
            texAprobados.Text = objCalificaciones.aprobados.ToString();
            texPro.Text = objCalificaciones.promedioGrupal.ToString();

        }
    }
}
