using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradosC_F
{
    public partial class Form1 : Form
    {
        Grados grados = new Grados();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            grados.setGrados(double.Parse(txtgrados.Text));
            lblresultado.Text = grados.calcular().ToString() + "  Grados Fahrenheit";
            lblresultado.Visible = true;
        }
    }
}
