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
            btnCalcular.Location = new Point(262, 107);
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
            btnReset.Location = new Point(332, 194);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.TopCenter;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 229);
            Controls.Add(btnReset);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(txtVariableB);
            Controls.Add(txtVariableA);
            Controls.Add(label1);
            Name = "frmCalculadora";
            Text = "Calculadora";
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
    }
}