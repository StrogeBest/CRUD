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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.btnTres);
            this.panelMenu.Controls.Add(this.btnDos);
            this.panelMenu.Controls.Add(this.btnUno);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 507);
            this.panelMenu.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(721, 507);
            this.panelContenedor.TabIndex = 1;
            // 
            // btnTres
            // 
            this.btnTres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTres.FlatAppearance.BorderSize = 0;
            this.btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTres.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTres.ForeColor = System.Drawing.Color.White;
            this.btnTres.Location = new System.Drawing.Point(0, 311);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(200, 50);
            this.btnTres.TabIndex = 2;
            this.btnTres.Text = "Tres";
            this.btnTres.UseVisualStyleBackColor = false;
            // 
            // btnDos
            // 
            this.btnDos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDos.FlatAppearance.BorderSize = 0;
            this.btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDos.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDos.ForeColor = System.Drawing.Color.White;
            this.btnDos.Location = new System.Drawing.Point(0, 240);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(200, 50);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "Dos";
            this.btnDos.UseVisualStyleBackColor = false;
            // 
            // btnUno
            // 
            this.btnUno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUno.FlatAppearance.BorderSize = 0;
            this.btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUno.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUno.ForeColor = System.Drawing.Color.White;
            this.btnUno.Location = new System.Drawing.Point(0, 167);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(200, 50);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "Uno";
            this.btnUno.UseVisualStyleBackColor = false;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 507);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(937, 546);
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel panelContenedor;
        private Button btnTres;
        private Button btnDos;
        private Button btnUno;
    }
}