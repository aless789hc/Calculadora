using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;//para usar el visual box
using System.Media;

namespace Calculadora.Formulario
{ 
    public partial class frmTemporizador : Form
    {
        string alarma1 = "";
        public frmTemporizador()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();//para poner la hora en el label shor(hora) y long(segundos)
            //
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alarma1 = Interaction.InputBox("Ingrese la hora: ", "Sistema", "00:00:00 x.x");
        }
    }
}
