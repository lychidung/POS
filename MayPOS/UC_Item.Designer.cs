namespace MayPOS
{
    partial class UC_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Item));
            this.Hinhchon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Tenmonchon = new System.Windows.Forms.Label();
            this.Giachon = new System.Windows.Forms.Label();
            this.SoLuongMon = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Hinhchon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongMon)).BeginInit();
            this.SuspendLayout();
            // 
            // Hinhchon
            // 
            this.Hinhchon.BorderRadius = 20;
            this.Hinhchon.Image = ((System.Drawing.Image)(resources.GetObject("Hinhchon.Image")));
            this.Hinhchon.ImageRotate = 0F;
            this.Hinhchon.Location = new System.Drawing.Point(2, 2);
            this.Hinhchon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hinhchon.Name = "Hinhchon";
            this.Hinhchon.Size = new System.Drawing.Size(69, 76);
            this.Hinhchon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hinhchon.TabIndex = 0;
            this.Hinhchon.TabStop = false;
            // 
            // Tenmonchon
            // 
            this.Tenmonchon.AutoSize = true;
            this.Tenmonchon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmonchon.Location = new System.Drawing.Point(76, 11);
            this.Tenmonchon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tenmonchon.Name = "Tenmonchon";
            this.Tenmonchon.Size = new System.Drawing.Size(96, 21);
            this.Tenmonchon.TabIndex = 2;
            this.Tenmonchon.Text = "1 Miếng Gà";
            // 
            // Giachon
            // 
            this.Giachon.AutoSize = true;
            this.Giachon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giachon.Location = new System.Drawing.Point(76, 45);
            this.Giachon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Giachon.Name = "Giachon";
            this.Giachon.Size = new System.Drawing.Size(58, 19);
            this.Giachon.TabIndex = 3;
            this.Giachon.Text = "39000đ";
            // 
            // SoLuongMon
            // 
            this.SoLuongMon.BackColor = System.Drawing.Color.Transparent;
            this.SoLuongMon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoLuongMon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SoLuongMon.Location = new System.Drawing.Point(224, 37);
            this.SoLuongMon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SoLuongMon.Name = "SoLuongMon";
            this.SoLuongMon.Size = new System.Drawing.Size(62, 33);
            this.SoLuongMon.TabIndex = 4;
            this.SoLuongMon.UpDownButtonFillColor = System.Drawing.Color.Coral;
            this.SoLuongMon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UC_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SoLuongMon);
            this.Controls.Add(this.Giachon);
            this.Controls.Add(this.Tenmonchon);
            this.Controls.Add(this.Hinhchon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Item";
            this.Size = new System.Drawing.Size(302, 81);
            ((System.ComponentModel.ISupportInitialize)(this.Hinhchon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox Hinhchon;
        private System.Windows.Forms.Label Tenmonchon;
        private System.Windows.Forms.Label Giachon;
        private Guna.UI2.WinForms.Guna2NumericUpDown SoLuongMon;
    }
}
