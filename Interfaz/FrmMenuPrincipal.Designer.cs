namespace Interfaz
{
    partial class FrmMenuPrincipal
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
            panelMenu = new Panel();
            btnTres = new Button();
            btnDos = new Button();
            btnUno = new Button();
            panelContenedor = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnTres);
            panelMenu.Controls.Add(btnDos);
            panelMenu.Controls.Add(btnUno);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 507);
            panelMenu.TabIndex = 0;
            // 
            // btnTres
            // 
            btnTres.BackColor = Color.FromArgb(128, 128, 255);
            btnTres.Cursor = Cursors.Hand;
            btnTres.FlatAppearance.BorderSize = 0;
            btnTres.FlatStyle = FlatStyle.Flat;
            btnTres.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.ForeColor = Color.White;
            btnTres.Location = new Point(0, 311);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(200, 50);
            btnTres.TabIndex = 2;
            btnTres.Text = "Tres";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // btnDos
            // 
            btnDos.BackColor = Color.FromArgb(128, 128, 255);
            btnDos.Cursor = Cursors.Hand;
            btnDos.FlatAppearance.BorderSize = 0;
            btnDos.FlatStyle = FlatStyle.Flat;
            btnDos.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDos.ForeColor = Color.White;
            btnDos.Location = new Point(0, 240);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(200, 50);
            btnDos.TabIndex = 1;
            btnDos.Text = "Dos";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.FromArgb(128, 128, 255);
            btnUno.Cursor = Cursors.Hand;
            btnUno.FlatAppearance.BorderSize = 0;
            btnUno.FlatStyle = FlatStyle.Flat;
            btnUno.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUno.ForeColor = Color.White;
            btnUno.Location = new Point(0, 167);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(200, 50);
            btnUno.TabIndex = 0;
            btnUno.Text = "Uno";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += btnUno_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(224, 224, 224);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(721, 507);
            panelContenedor.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 507);
            Controls.Add(panelContenedor);
            Controls.Add(panelMenu);
            MinimumSize = new Size(937, 546);
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMenuPrincipal";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenedor;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
    }
}