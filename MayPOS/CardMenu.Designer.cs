namespace MayPOS
{
    partial class CardMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardMenu));
            this.PanelCard = new Guna.UI2.WinForms.Guna2Panel();
            this.Anhmonan = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Giamonan = new System.Windows.Forms.Label();
            this.Tenmonan = new System.Windows.Forms.Label();
            this.PanelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anhmonan)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelCard
            // 
            this.PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.PanelCard.BorderRadius = 30;
            this.PanelCard.Controls.Add(this.Anhmonan);
            this.PanelCard.Controls.Add(this.Giamonan);
            this.PanelCard.Controls.Add(this.Tenmonan);
            this.PanelCard.Location = new System.Drawing.Point(0, 0);
            this.PanelCard.Name = "PanelCard";
            this.PanelCard.ShadowDecoration.BorderRadius = 1;
            this.PanelCard.ShadowDecoration.Depth = 1;
            this.PanelCard.ShadowDecoration.Enabled = true;
            this.PanelCard.Size = new System.Drawing.Size(294, 248);
            this.PanelCard.TabIndex = 5;
            // 
            // Anhmonan
            // 
            this.Anhmonan.BorderRadius = 10;
            this.Anhmonan.Image = ((System.Drawing.Image)(resources.GetObject("Anhmonan.Image")));
            this.Anhmonan.ImageRotate = 0F;
            this.Anhmonan.Location = new System.Drawing.Point(16, 12);
            this.Anhmonan.Name = "Anhmonan";
            this.Anhmonan.Size = new System.Drawing.Size(258, 128);
            this.Anhmonan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anhmonan.TabIndex = 3;
            this.Anhmonan.TabStop = false;
            // 
            // Giamonan
            // 
            this.Giamonan.AutoSize = true;
            this.Giamonan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giamonan.Location = new System.Drawing.Point(12, 206);
            this.Giamonan.Name = "Giamonan";
            this.Giamonan.Size = new System.Drawing.Size(69, 23);
            this.Giamonan.TabIndex = 2;
            this.Giamonan.Text = "39,000đ";
            // 
            // Tenmonan
            // 
            this.Tenmonan.AutoSize = true;
            this.Tenmonan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tenmonan.Location = new System.Drawing.Point(11, 162);
            this.Tenmonan.Name = "Tenmonan";
            this.Tenmonan.Size = new System.Drawing.Size(121, 28);
            this.Tenmonan.TabIndex = 1;
            this.Tenmonan.Text = "1 Miếng Gà";
            // 
            // CardMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelCard);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(14, 7, 7, 7);
            this.Name = "CardMenu";
            this.Size = new System.Drawing.Size(295, 249);
            this.PanelCard.ResumeLayout(false);
            this.PanelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Anhmonan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelCard;
        private System.Windows.Forms.Label Giamonan;
        private System.Windows.Forms.Label Tenmonan;
        private Guna.UI2.WinForms.Guna2PictureBox Anhmonan;
    }
}
