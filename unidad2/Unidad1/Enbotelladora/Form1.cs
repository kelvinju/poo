using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enbotelladora
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ClassBotella objBotella = new ClassBotella();

            objBotella.nivelLlenado = Convert.ToInt32(txt.Text);
            MessageBox.Show(objBotella.verificarLlenado());
        

        }
    }
}
