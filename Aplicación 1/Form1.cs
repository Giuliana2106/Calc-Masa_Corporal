using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aplicación_1
{
    public partial class Form1 : Form
    {
    static Operación op = new Operación();
    public Form1()
        {
            InitializeComponent();
        }

        private void cmdCalc_Click(object sender, EventArgs e)
        {
            lblResultado.Text = (op.Calculo(float.Parse(txtvP.Text), float.Parse(txtvEst.Text)).ToString());
        }

        private void lblPeso_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("La conversión de lbs a kgs es de: 1 libra = 0.45 kgs");
        }

        private void cbxIMC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIMC.Text == "18.5 - 24.9")
            {
                MessageBox.Show("Normal");
            }

            else if (cbxIMC.Text == "25.0 - 29.9")
            {
                MessageBox.Show("Sobrepeso");
            }

            else if (cbxIMC.Text == "30.0 - 39.9")
            {
                MessageBox.Show("Obesidad");
            }

            else if (cbxIMC.Text == "Más de 40")
            {
                MessageBox.Show("Obesidad mórbida");
            }
        }
    }
}
