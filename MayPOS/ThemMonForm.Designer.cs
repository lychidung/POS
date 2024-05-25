namespace MayPOS
{
    partial class ThemMonForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonThemMon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericGiaThem = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTenMonAn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTheLoaiMonThem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHinhAnh = new System.Windows.Forms.TextBox();
            this.textBoxMoTa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaThem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 498);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonThemMon);
            this.panel5.Location = new System.Drawing.Point(348, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(172, 60);
            this.panel5.TabIndex = 3;
            // 
            // buttonThemMon
            // 
            this.buttonThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThemMon.Location = new System.Drawing.Point(4, 5);
            this.buttonThemMon.Name = "buttonThemMon";
            this.buttonThemMon.Size = new System.Drawing.Size(165, 52);
            this.buttonThemMon.TabIndex = 0;
            this.buttonThemMon.Text = "THÊM";
            this.buttonThemMon.UseVisualStyleBackColor = true;
            this.buttonThemMon.Click += new System.EventHandler(this.buttonThemMon_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxMoTa);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxHinhAnh);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.comboBoxTheLoaiMonThem);
            this.panel3.Controls.Add(this.numericGiaThem);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxTenMonAn);
            this.panel3.Location = new System.Drawing.Point(50, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 426);
            this.panel3.TabIndex = 2;
            // 
            // numericGiaThem
            // 
            this.numericGiaThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericGiaThem.Location = new System.Drawing.Point(3, 154);
            this.numericGiaThem.Maximum = new decimal(new int[] {
            -1981284352,
            -1966660860,
            0,
            0});
            this.numericGiaThem.Name = "numericGiaThem";
            this.numericGiaThem.Size = new System.Drawing.Size(416, 24);
            this.numericGiaThem.TabIndex = 3;
            this.numericGiaThem.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên món ăn:";
            // 
            // textBoxTenMonAn
            // 
            this.textBoxTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenMonAn.Location = new System.Drawing.Point(3, 33);
            this.textBoxTenMonAn.Multiline = true;
            this.textBoxTenMonAn.Name = "textBoxTenMonAn";
            this.textBoxTenMonAn.Size = new System.Drawing.Size(416, 25);
            this.textBoxTenMonAn.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 60);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MÓN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxTheLoaiMonThem
            // 
            this.comboBoxTheLoaiMonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTheLoaiMonThem.FormattingEnabled = true;
            this.comboBoxTheLoaiMonThem.Location = new System.Drawing.Point(3, 94);
            this.comboBoxTheLoaiMonThem.Name = "comboBoxTheLoaiMonThem";
            this.comboBoxTheLoaiMonThem.Size = new System.Drawing.Size(416, 24);
            this.comboBoxTheLoaiMonThem.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Thể loại món:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 184);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hình ảnh:";
            // 
            // textBoxHinhAnh
            // 
            this.textBoxHinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHinhAnh.Location = new System.Drawing.Point(3, 214);
            this.textBoxHinhAnh.Multiline = true;
            this.textBoxHinhAnh.Name = "textBoxHinhAnh";
            this.textBoxHinhAnh.Size = new System.Drawing.Size(416, 25);
            this.textBoxHinhAnh.TabIndex = 7;
            // 
            // textBoxMoTa
            // 
            this.textBoxMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMoTa.Location = new System.Drawing.Point(3, 275);
            this.textBoxMoTa.Multiline = true;
            this.textBoxMoTa.Name = "textBoxMoTa";
            this.textBoxMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMoTa.Size = new System.Drawing.Size(416, 148);
            this.textBoxMoTa.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mô tả:";
            // 
            // ThemMonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 522);
            this.Controls.Add(this.panel1);
            this.Name = "ThemMonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ThemMonForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericGiaThem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonThemMon;
        private System.Windows.Forms.NumericUpDown numericGiaThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTenMonAn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTheLoaiMonThem;
        private System.Windows.Forms.TextBox textBoxMoTa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHinhAnh;
        private System.Windows.Forms.Label label6;
    }
}