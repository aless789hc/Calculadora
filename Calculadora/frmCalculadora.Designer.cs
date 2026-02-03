namespace Calculadora
{
    partial class frmCalculadora
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
            label1 = new Label();
            txtVariableA = new TextBox();
            txtVariableB = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            btnReset = new Button();
            groupBox1 = new GroupBox();
            rdSuma = new RadioButton();
            rdResta = new RadioButton();
            rdMultiplicacion = new RadioButton();
            rdDivision = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "VariableA";
            // 
            // txtVariableA
            // 
            txtVariableA.Location = new Point(13, 49);
            txtVariableA.Name = "txtVariableA";
            txtVariableA.Size = new Size(216, 23);
            txtVariableA.TabIndex = 2;
            txtVariableA.TextChanged += txtVariableA_TextChanged;
            // 
            // txtVariableB
            // 
            txtVariableB.Location = new Point(12, 158);
            txtVariableB.Name = "txtVariableB";
            txtVariableB.Size = new Size(217, 23);
            txtVariableB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 140);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "VariableB";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(255, 192, 192);
            btnCalcular.Location = new Point(461, 49);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(255, 128, 128);
            btnReset.Location = new Point(461, 91);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.TopCenter;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdDivision);
            groupBox1.Controls.Add(rdMultiplicacion);
            groupBox1.Controls.Add(rdResta);
            groupBox1.Controls.Add(rdSuma);
            groupBox1.Location = new Point(255, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 167);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // rdSuma
            // 
            rdSuma.AutoSize = true;
            rdSuma.Location = new Point(36, 25);
            rdSuma.Name = "rdSuma";
            rdSuma.Size = new Size(55, 19);
            rdSuma.TabIndex = 0;
            rdSuma.TabStop = true;
            rdSuma.Text = "Suma";
            rdSuma.UseVisualStyleBackColor = true;
            // 
            // rdResta
            // 
            rdResta.AutoSize = true;
            rdResta.Location = new Point(36, 50);
            rdResta.Name = "rdResta";
            rdResta.Size = new Size(53, 19);
            rdResta.TabIndex = 1;
            rdResta.TabStop = true;
            rdResta.Text = "Resta";
            rdResta.UseVisualStyleBackColor = true;
            // 
            // rdMultiplicacion
            // 
            rdMultiplicacion.AutoSize = true;
            rdMultiplicacion.Location = new Point(36, 75);
            rdMultiplicacion.Name = "rdMultiplicacion";
            rdMultiplicacion.Size = new Size(101, 19);
            rdMultiplicacion.TabIndex = 8;
            rdMultiplicacion.TabStop = true;
            rdMultiplicacion.Text = "Multiplicacion";
            rdMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdDivision
            // 
            rdDivision.AutoSize = true;
            rdDivision.Location = new Point(36, 109);
            rdDivision.Name = "rdDivision";
            rdDivision.Size = new Size(67, 19);
            rdDivision.TabIndex = 9;
            rdDivision.TabStop = true;
            rdDivision.Text = "Division";
            rdDivision.UseVisualStyleBackColor = true;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 229);
            Controls.Add(groupBox1);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVariableA;
        private TextBox txtVariableB;
        private Label label2;
        private Button btnCalcular;
        private Button btnReset;
        private GroupBox groupBox1;
        private RadioButton rdDivision;
        private RadioButton rdMultiplicacion;
        private RadioButton rdResta;
        private RadioButton rdSuma;
    }
}