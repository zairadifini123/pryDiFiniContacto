namespace pryDiFiniContacto
{
    partial class frmContacto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContacto));
            lblContacto = new Label();
            txtContacto = new TextBox();
            lblTelefono = new Label();
            mtbTelefono = new MaskedTextBox();
            btnSalir = new Button();
            lstResultados = new ListBox();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContacto.ForeColor = SystemColors.ControlText;
            lblContacto.Location = new Point(32, 22);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(112, 25);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "CONTACTO";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(150, 22);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(144, 23);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = SystemColors.ControlText;
            lblTelefono.Location = new Point(32, 68);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(106, 25);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "TELEFONO";
            // 
            // mtbTelefono
            // 
            mtbTelefono.Location = new Point(150, 70);
            mtbTelefono.Mask = "000-000-0000";
            mtbTelefono.Name = "mtbTelefono";
            mtbTelefono.Size = new Size(144, 23);
            mtbTelefono.TabIndex = 3;
            mtbTelefono.MaskInputRejected += mtbTelefono_MaskInputRejected;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(32, 128);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstResultados
            // 
            lstResultados.BackColor = SystemColors.HighlightText;
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(12, 176);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(282, 199);
            lstResultados.TabIndex = 5;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(178, 128);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(116, 23);
            btnGrabar.TabIndex = 6;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // frmContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(320, 390);
            Controls.Add(btnGrabar);
            Controls.Add(lstResultados);
            Controls.Add(btnSalir);
            Controls.Add(mtbTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtContacto);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmContacto";
            Text = "Contacto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private TextBox txtContacto;
        private Label lblTelefono;
        private MaskedTextBox mtbTelefono;
        private ListBox lstResultados;
        private Button btnGrabar;
        private Button btnSalir;
    }
}
