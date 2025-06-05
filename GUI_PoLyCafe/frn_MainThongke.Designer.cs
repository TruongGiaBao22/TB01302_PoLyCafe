namespace GUI_PoLyCafe
{
    partial class frn_MainThongke
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnTKLSP = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKSP = new Guna.UI2.WinForms.Guna2Button();
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.btnTKLSP);
            this.guna2Panel1.Controls.Add(this.btnTKSP);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1092, 29);
            this.guna2Panel1.TabIndex = 1;
            // 
            // btnTKLSP
            // 
            this.btnTKLSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKLSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKLSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKLSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKLSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTKLSP.FillColor = System.Drawing.Color.Teal;
            this.btnTKLSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTKLSP.ForeColor = System.Drawing.Color.White;
            this.btnTKLSP.Image = global::GUI_PoLyCafe.Properties.Resources.products;
            this.btnTKLSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTKLSP.Location = new System.Drawing.Point(180, 0);
            this.btnTKLSP.Name = "btnTKLSP";
            this.btnTKLSP.Size = new System.Drawing.Size(180, 29);
            this.btnTKLSP.TabIndex = 1;
            this.btnTKLSP.Text = "TK Loại Sản Phẩm";
            // 
            // btnTKSP
            // 
            this.btnTKSP.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTKSP.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTKSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTKSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTKSP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTKSP.FillColor = System.Drawing.Color.Teal;
            this.btnTKSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTKSP.ForeColor = System.Drawing.Color.White;
            this.btnTKSP.Image = global::GUI_PoLyCafe.Properties.Resources.box;
            this.btnTKSP.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTKSP.Location = new System.Drawing.Point(0, 0);
            this.btnTKSP.Name = "btnTKSP";
            this.btnTKSP.Size = new System.Drawing.Size(180, 29);
            this.btnTKSP.TabIndex = 0;
            this.btnTKSP.Text = "TK Sản Phẩm";
            this.btnTKSP.Click += new System.EventHandler(this.btnTKSP_Click);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 29);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1092, 577);
            this.pnMain.TabIndex = 2;
            // 
            // frn_MainThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 606);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frn_MainThongke";
            this.Text = "frn_MainThongke";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnTKLSP;
        private Guna.UI2.WinForms.Guna2Button btnTKSP;
        private Guna.UI2.WinForms.Guna2Panel pnMain;
    }
}