using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajosEmpleados
{
    public partial class Form1 : Form
    {
        Mesero objMeserito = new Mesero();
        Repartidor objRepart = new Repartidor();
        Cajero objCajita = new Cajero();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comEmpleado.Text)
                
            {
                case "Mesero":
                    {

                        objMeserito.Sueldo = float.Parse(texSueldo.Text.ToString());
                        objMeserito.Propinas = float.Parse(texPropinas.Text.ToString());
                        objMeserito.DiasTrabajados = float.Parse(texTrabajos.Text.ToString());
                        objMeserito.calcularSueldo();
                        texSueldofinal.Text = objMeserito.Sueldo.ToString();

                        break;
                        { }
                    }
                            case "Repartidor":
                    objRepart.Sueldo = float.Parse(texSueldo.Text.ToString());
                    objRepart.zona = float.Parse(comRutas.Text.ToString());
                    
                    objRepart.DiasTrabajados = float.Parse(texTrabajos.Text.ToString());
                    objMeserito.calcularSueldo();
                    texSueldofinal.Text = objRepart.Sueldo.ToString();
                    break;

                case "Caja":
                    
                    objCajita.Sueldo = float.Parse(texSueldo.Text.ToString());
                    objCajita.caja = (comboBox3.Text.ToString());
                    
                    objCajita.caja = (comboBox3.Text.ToString());
                    objCajita.calcularSueldo();
                    texSueldofinal.Text = objCajita.Sueldo.ToString();
                    break;
                    


            }
            }
    }
}
