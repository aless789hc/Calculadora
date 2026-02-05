namespace Calculadora.Formulario
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRegistrar = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvPersonas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(403, 364);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(dtpFecha);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtApellido);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(395, 336);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registros";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(246, 273);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(24, 198);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(235, 23);
            dtpFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 180);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 4;
            label3.Text = "Fecha de Nacimiento";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(21, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(312, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 100);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(312, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvPersonas);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(395, 336);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mostrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new Point(6, 3);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(383, 327);
            dgvPersonas.TabIndex = 0;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 373);
            Controls.Add(tabControl1);
            Name = "frmRegistro";
            Text = "Registro Alumnos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnRegistrar;
        private DateTimePicker dtpFecha;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dgvPersonas;
    }
}