namespace MayPOS
{
    partial class UC_theloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_theloai));
            this.TenLoai = new System.Windows.Forms.Label();
            this.PanelLoai = new Guna.UI2.WinForms.Guna2Panel();
            this.HinhLoai = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PanelLoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HinhLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // TenLoai
            // 
            this.TenLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenLoai.Location = new System.Drawing.Point(3, 60);
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Size = new System.Drawing.Size(194, 40);
            this.TenLoai.TabIndex = 1;
            this.TenLoai.Text = "Tất cả";
            this.TenLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelLoai
            // 
            this.PanelLoai.BackColor = System.Drawing.Color.Transparent;
            this.PanelLoai.BorderColor = System.Drawing.Color.White;
            this.PanelLoai.BorderRadius = 10;
            this.PanelLoai.BorderThickness = 10;
            this.PanelLoai.Controls.Add(this.TenLoai);
            this.PanelLoai.Controls.Add(this.HinhLoai);
            this.PanelLoai.FillColor = System.Drawing.Color.White;
            this.PanelLoai.Location = new System.Drawing.Point(0, 0);
            this.PanelLoai.Name = "PanelLoai";
            this.PanelLoai.Size = new System.Drawing.Size(200, 100);
            this.PanelLoai.TabIndex = 6;
            // 
            // HinhLoai
            // 
            this.HinhLoai.Image = ((System.Drawing.Image)(resources.GetObject("HinhLoai.Image")));
            this.HinhLoai.ImageRotate = 0F;
            this.HinhLoai.Location = new System.Drawing.Point(66, 4);
            this.HinhLoai.Name = "HinhLoai";
            this.HinhLoai.Size = new System.Drawing.Size(58, 53);
            this.HinhLoai.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HinhLoai.TabIndex = 0;
            this.HinhLoai.TabStop = false;
            // 
            // UC_theloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelLoai);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Name = "UC_theloai";
            this.Size = new System.Drawing.Size(200, 100);
            this.PanelLoai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HinhLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TenLoai;
        private Guna.UI2.WinForms.Guna2PictureBox HinhLoai;
        private Guna.UI2.WinForms.Guna2Panel PanelLoai;
    }
}
