namespace Interfaz
{
    partial class FrmDos
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
            lblTitulo = new Label();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 32F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(721, 80);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Formulario Dos: ListBox";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(116, 98);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(492, 349);
            lstDatos.TabIndex = 2;
            // 
            // FrmDos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(721, 507);
            Controls.Add(lstDatos);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDos";
            Text = "FrmDos";
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private ListBox lstDatos;
    }
}