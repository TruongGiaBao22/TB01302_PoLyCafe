namespace GUI_PoLyCafe
{
    partial class frm_MainHeThong
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
            this.pnMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDMK = new Guna.UI2.WinForms.Guna2Button();
            this.btnHDSD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.Location = new System.Drawing.Point(0, 35);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1098, 574);
            this.pnMain.TabIndex = 3;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkSalmon;
            this.guna2Panel1.Controls.Add(this.btnDMK);
            this.guna2Panel1.Controls.Add(this.btnHDSD);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1098, 29);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnDMK
            // 
            this.btnDMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDMK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDMK.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnDMK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDMK.ForeColor = System.Drawing.Color.White;
            this.btnDMK.Image = global::GUI_PoLyCafe.Properties.Resources.reset_password;
            this.btnDMK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDMK.Location = new System.Drawing.Point(243, 0);
            this.btnDMK.Name = "btnDMK";
            this.btnDMK.Size = new System.Drawing.Size(180, 29);
            this.btnDMK.TabIndex = 1;
            this.btnDMK.Text = "Đổi Mật Khẩu";
            this.btnDMK.Click += new System.EventHandler(this.btnDMK_Click);
            // 
            // btnHDSD
            // 
            this.btnHDSD.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHDSD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHDSD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHDSD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHDSD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHDSD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHDSD.FillColor = System.Drawing.Color.DarkSalmon;
            this.btnHDSD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHDSD.ForeColor = System.Drawing.Color.White;
            this.btnHDSD.Image = global::GUI_PoLyCafe.Properties.Resources.user_guide;
            this.btnHDSD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHDSD.Location = new System.Drawing.Point(0, 0);
            this.btnHDSD.Name = "btnHDSD";
            this.btnHDSD.Size = new System.Drawing.Size(243, 29);
            this.btnHDSD.TabIndex = 0;
            this.btnHDSD.Text = "Hướng Dẫn Sử Dụng";
            this.btnHDSD.Click += new System.EventHandler(this.btnHDSD_Click);
            // 
            // frm_MainHeThong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 609);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frm_MainHeThong";
            this.Text = "frm_MainHeThong";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMain;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnDMK;
        private Guna.UI2.WinForms.Guna2Button btnHDSD;
    }
}