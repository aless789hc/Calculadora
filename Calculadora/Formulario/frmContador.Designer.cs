namespace Calculadora.Formulario
{
    partial class frmContador
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
            components = new System.ComponentModel.Container();
            lblCuenta = new Label();
            btnInicio = new Button();
            btnDetener = new Button();
            tkbVelocidad = new TrackBar();
            tmrContador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).BeginInit();
            SuspendLayout();
            // 
            // lblCuenta
            // 
            lblCuenta.AutoSize = true;
            lblCuenta.Font = new Font("Lucida Console", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuenta.Location = new Point(231, 34);
            lblCuenta.Name = "lblCuenta";
            lblCuenta.Size = new Size(48, 47);
            lblCuenta.TabIndex = 0;
            lblCuenta.Text = "0";
            // 
            // btnInicio
            // 
            btnInicio.Location = new Point(42, 183);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(94, 29);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(347, 197);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(94, 29);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // tkbVelocidad
            // 
            tkbVelocidad.Enabled = false;
            tkbVelocidad.Location = new Point(42, 105);
            tkbVelocidad.Maximum = 5;
            tkbVelocidad.Minimum = 1;
            tkbVelocidad.Name = "tkbVelocidad";
            tkbVelocidad.Size = new Size(399, 56);
            tkbVelocidad.TabIndex = 3;
            tkbVelocidad.TickStyle = TickStyle.TopLeft;
            tkbVelocidad.Value = 1;
            tkbVelocidad.Scroll += tkbVelocidad_Scroll;
            // 
            // tmrContador
            // 
            tmrContador.Interval = 1;
            tmrContador.Tick += tmrContador_Tick;
            // 
            // frmContador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 268);
            Controls.Add(tkbVelocidad);
            Controls.Add(btnDetener);
            Controls.Add(btnInicio);
            Controls.Add(lblCuenta);
            Name = "frmContador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkbVelocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCuenta;
        private Button btnInicio;
        private Button btnDetener;
        private TrackBar tkbVelocidad;
        public System.Windows.Forms.Timer tmrContador;
    }
}