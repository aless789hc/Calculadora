using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora.Formulario
{
    public partial class frmEditor : Form
    {
        bool saved = false;
        string path = "";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK) {
                if (File.Exists(ofpEditor.FileName)) { // si la ruta seleccionada existe
                    rtbEditor.Text = File.ReadAllText(ofpEditor.FileName);


                    
                } 
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saved == false)
            {
                guardar();
                saved = true;
            }
            else {
                using (StreamWriter archivo = new StreamWriter(path)) // la ruta del archivo que voy a guardar
                    archivo.Write(rtbEditor.Text);
            }

        }
        private void guardar() {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
               path=sfdEditor.FileName;
                using (StreamWriter archivo = new StreamWriter(path)) // la ruta del archivo que voy a guardar
                { archivo.Write(rtbEditor.Text); }// le voy a mandar al archuvo lo que tengo escrito en el rtb
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            path = "";//ruta
            saved= false;
        }
    }
}
