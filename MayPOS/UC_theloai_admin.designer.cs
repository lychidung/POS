namespace MayPOS
{
    partial class UC_theloai_admin
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
            this.FlowLayerTheLoai = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddLoai = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // FlowLayerTheLoai
            // 
            this.FlowLayerTheLoai.AutoScroll = true;
            this.FlowLayerTheLoai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlowLayerTheLoai.Location = new System.Drawing.Point(0, 79);
            this.FlowLayerTheLoai.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayerTheLoai.Name = "FlowLayerTheLoai";
            this.FlowLayerTheLoai.Size = new System.Drawing.Size(1165, 794);
            this.FlowLayerTheLoai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label1.Size = new System.Drawing.Size(210, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản lý loại";
            // 
            // AddLoai
            // 
            this.AddLoai.Animated = true;
            this.AddLoai.AnimatedGIF = true;
            this.AddLoai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddLoai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddLoai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLoai.ForeColor = System.Drawing.Color.White;
            this.AddLoai.Location = new System.Drawing.Point(274, 31);
            this.AddLoai.Name = "AddLoai";
            this.AddLoai.ShadowDecoration.Depth = 10;
            this.AddLoai.Size = new System.Drawing.Size(200, 45);
            this.AddLoai.TabIndex = 9;
            this.AddLoai.Text = "Thêm danh mục";
            this.AddLoai.Click += new System.EventHandler(this.AddLoai_Click);
            // 
            // UC_theloai_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.AddLoai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FlowLayerTheLoai);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UC_theloai_admin";
            this.Size = new System.Drawing.Size(1165, 873);
            this.Load += new System.EventHandler(this.UC_theloai_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayerTheLoai;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddLoai;
    }
}
