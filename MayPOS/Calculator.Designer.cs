namespace MayPOS
{
    partial class Calculator
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
            this.numericThanhToan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericNhan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.numericThua = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnCalcu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThua)).BeginInit();
            this.SuspendLayout();
            // 
            // numericThanhToan
            // 
            this.numericThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.numericThanhToan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericThanhToan.Enabled = false;
            this.numericThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericThanhToan.Location = new System.Drawing.Point(301, 64);
            this.numericThanhToan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericThanhToan.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericThanhToan.Name = "numericThanhToan";
            this.numericThanhToan.Size = new System.Drawing.Size(404, 44);
            this.numericThanhToan.TabIndex = 24;
            this.numericThanhToan.ThousandsSeparator = true;
            this.numericThanhToan.UpDownButtonFillColor = System.Drawing.Color.Coral;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cần thanh toán:";
            // 
            // numericNhan
            // 
            this.numericNhan.BackColor = System.Drawing.Color.Transparent;
            this.numericNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericNhan.Location = new System.Drawing.Point(301, 145);
            this.numericNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericNhan.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericNhan.Name = "numericNhan";
            this.numericNhan.Size = new System.Drawing.Size(404, 44);
            this.numericNhan.TabIndex = 26;
            this.numericNhan.ThousandsSeparator = true;
            this.numericNhan.UpDownButtonFillColor = System.Drawing.Color.Coral;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thực nhận:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderRadius = 10;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.Coral;
            this.btnXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(280, 326);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(257, 70);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // numericThua
            // 
            this.numericThua.BackColor = System.Drawing.Color.Transparent;
            this.numericThua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericThua.Enabled = false;
            this.numericThua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericThua.Location = new System.Drawing.Point(301, 224);
            this.numericThua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericThua.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericThua.Name = "numericThua";
            this.numericThua.Size = new System.Drawing.Size(404, 44);
            this.numericThua.TabIndex = 29;
            this.numericThua.ThousandsSeparator = true;
            this.numericThua.UpDownButtonFillColor = System.Drawing.Color.Coral;
            this.numericThua.ValueChanged += new System.EventHandler(this.numericThua_ValueChanged);
            // 
            // btnCalcu
            // 
            this.btnCalcu.Animated = true;
            this.btnCalcu.AnimatedGIF = true;
            this.btnCalcu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalcu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalcu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalcu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcu.ForeColor = System.Drawing.Color.White;
            this.btnCalcu.Location = new System.Drawing.Point(88, 224);
            this.btnCalcu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalcu.Name = "btnCalcu";
            this.btnCalcu.Size = new System.Drawing.Size(180, 46);
            this.btnCalcu.TabIndex = 30;
            this.btnCalcu.Text = "Tiền thừa";
            this.btnCalcu.Click += new System.EventHandler(this.btnCalcu_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.btnCalcu);
            this.Controls.Add(this.numericThua);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.numericNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericThanhToan);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numericThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericThua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown numericThanhToan;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericNhan;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericThua;
        private Guna.UI2.WinForms.Guna2Button btnCalcu;
    }
}