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
        string texto="";
        public frmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofpEditor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofpEditor.FileName))
                { // si la ruta seleccionada existe
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
            else
            {
                using (StreamWriter archivo = new StreamWriter(path)) // la ruta del archivo que voy a guardar
                    archivo.Write(rtbEditor.Text);
            }

        }
        private void guardar()
        {
            if (sfdEditor.ShowDialog() == DialogResult.OK)
            {
                path = sfdEditor.FileName;
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
            saved = false;
        }

        private void rtbEditor_TextChanged(object sender, EventArgs e)
        {
             texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            
           
            tssStatus.Text = palabras.Length.ToString() + " Palabras";
        }

        private void tssStatus_Click(object sender, EventArgs e)
        {
             texto = rtbEditor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            string[] parrafos = texto.Split(new char[] {  '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas : \n\nPalabras: " + palabras.Length.ToString ()+ "\nLetras: " + texto.Length.ToString() + "\nParrafos: " + parrafos.Length.ToString(), "Contador de Palabras");
        }
    }
}
