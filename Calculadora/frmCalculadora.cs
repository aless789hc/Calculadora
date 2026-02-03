using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }


        private void txtVariableA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = int.Parse(txtVariableA.Text);
                b = Convert.ToInt32(txtVariableB.Text);
                if (rdSuma.Checked)
                    resultado = a + b;
                if (rdResta.Checked)
                    resultado = a - b;
                if(rdMultiplicacion.Checked)
                resultado = a * b;
                if (rdDivision.Checked)
                    resultado = a / b;
                MessageBox.Show("El resultado es: " + resultado.ToString(), "Sitema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversión de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void Reset() {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }
    }
}
