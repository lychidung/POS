namespace MayPOS
{
    partial class UC_theloai_admin_sub
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_theloai_admin_sub));
            this.PanelAllLoai = new Guna.UI2.WinForms.Guna2Panel();
            this.TenLoai = new System.Windows.Forms.Label();
            this.PanelAllLoai1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Thongkemon = new System.Windows.Forms.Label();
            this.Thongkegia = new System.Windows.Forms.Label();
            this.HinhLoai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.PanelAllLoai.SuspendLayout();
            this.PanelAllLoai1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAllLoai
            // 
            this.PanelAllLoai.BackColor = System.Drawing.Color.Orange;
            this.PanelAllLoai.BorderRadius = 10;
            this.PanelAllLoai.Controls.Add(this.guna2ImageButton1);
            this.PanelAllLoai.Controls.Add(this.TenLoai);
            this.PanelAllLoai.Controls.Add(this.PanelAllLoai1);
            this.PanelAllLoai.Controls.Add(this.HinhLoai);
            this.PanelAllLoai.FillColor = System.Drawing.Color.Orange;
            this.PanelAllLoai.Location = new System.Drawing.Point(0, 0);
            this.PanelAllLoai.Margin = new System.Windows.Forms.Padding(15);
            this.PanelAllLoai.Name = "PanelAllLoai";
            this.PanelAllLoai.ShadowDecoration.BorderRadius = 10;
            this.PanelAllLoai.ShadowDecoration.Depth = 10;
            this.PanelAllLoai.ShadowDecoration.Enabled = true;
            this.PanelAllLoai.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.PanelAllLoai.Size = new System.Drawing.Size(344, 332);
            this.PanelAllLoai.TabIndex = 4;
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSize = true;
            this.TenLoai.BackColor = System.Drawing.Color.Firebrick;
            this.TenLoai.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoai.ForeColor = System.Drawing.Color.White;
            this.TenLoai.Location = new System.Drawing.Point(-1, 231);
            this.TenLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Padding = new System.Windows.Forms.Padding(3);
            this.TenLoai.Size = new System.Drawing.Size(194, 37);
            this.TenLoai.TabIndex = 7;
            this.TenLoai.Text = "Gà rán - gà quay";
            // 
            // PanelAllLoai1
            // 
            this.PanelAllLoai1.Controls.Add(this.Thongkemon);
            this.PanelAllLoai1.Controls.Add(this.Thongkegia);
            this.PanelAllLoai1.Location = new System.Drawing.Point(0, 271);
            this.PanelAllLoai1.Name = "PanelAllLoai1";
            this.PanelAllLoai1.Size = new System.Drawing.Size(345, 64);
            this.PanelAllLoai1.TabIndex = 3;
            // 
            // Thongkemon
            // 
            this.Thongkemon.AutoSize = true;
            this.Thongkemon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thongkemon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Thongkemon.Location = new System.Drawing.Point(243, 30);
            this.Thongkemon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Thongkemon.Name = "Thongkemon";
            this.Thongkemon.Size = new System.Drawing.Size(80, 31);
            this.Thongkemon.TabIndex = 8;
            this.Thongkemon.Text = "5 món";
            // 
            // Thongkegia
            // 
            this.Thongkegia.AutoSize = true;
            this.Thongkegia.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thongkegia.ForeColor = System.Drawing.Color.White;
            this.Thongkegia.Location = new System.Drawing.Point(2, 0);
            this.Thongkegia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Thongkegia.Name = "Thongkegia";
            this.Thongkegia.Size = new System.Drawing.Size(217, 31);
            this.Thongkegia.TabIndex = 9;
            this.Thongkegia.Text = "120000 đến 200000";
            // 
            // HinhLoai
            // 
            this.HinhLoai.BackColor = System.Drawing.Color.Transparent;
            this.HinhLoai.BorderRadius = 20;
            this.HinhLoai.CustomizableEdges.TopLeft = false;
            this.HinhLoai.CustomizableEdges.TopRight = false;
            this.HinhLoai.Image = ((System.Drawing.Image)(resources.GetObject("HinhLoai.Image")));
            this.HinhLoai.ImageRotate = 0F;
            this.HinhLoai.Location = new System.Drawing.Point(-1, -10);
            this.HinhLoai.Name = "HinhLoai";
            this.HinhLoai.Size = new System.Drawing.Size(346, 231);
            this.HinhLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HinhLoai.TabIndex = 0;
            this.HinhLoai.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Location = new System.Drawing.Point(303, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.Size = new System.Drawing.Size(42, 42);
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // UC_theloai_admin_sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelAllLoai);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(15);
            this.Name = "UC_theloai_admin_sub";
            this.Size = new System.Drawing.Size(344, 332);
            this.PanelAllLoai.ResumeLayout(false);
            this.PanelAllLoai.PerformLayout();
            this.PanelAllLoai1.ResumeLayout(false);
            this.PanelAllLoai1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelAllLoai;
        private System.Windows.Forms.Label TenLoai;
        private Guna.UI2.WinForms.Guna2Panel PanelAllLoai1;
        private System.Windows.Forms.Label Thongkemon;
        private System.Windows.Forms.Label Thongkegia;
        private Guna.UI2.WinForms.Guna2PictureBox HinhLoai;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}
