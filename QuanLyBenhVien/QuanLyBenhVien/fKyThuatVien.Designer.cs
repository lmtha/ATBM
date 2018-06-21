namespace QuanLyBenhVien
{
    partial class fKyThuatVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewThuocDSBN = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKTVXacNhan = new System.Windows.Forms.Button();
            this.txbKTVMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxMRI = new System.Windows.Forms.CheckBox();
            this.checkBoxCT = new System.Windows.Forms.CheckBox();
            this.checkBoxSieuAm = new System.Windows.Forms.CheckBox();
            this.checkBoxXquang = new System.Windows.Forms.CheckBox();
            this.checkBoxXetNg = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbxKTVTenBN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuocDSBN)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(425, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewThuocDSBN);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(417, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách bệnh nhân";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewThuocDSBN
            // 
            this.dataGridViewThuocDSBN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThuocDSBN.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewThuocDSBN.Name = "dataGridViewThuocDSBN";
            this.dataGridViewThuocDSBN.Size = new System.Drawing.Size(408, 202);
            this.dataGridViewThuocDSBN.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Danh sách bệnh nhân";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(417, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chuẩn đoán";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKTVXacNhan);
            this.panel2.Controls.Add(this.txbKTVMoTa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(51, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 82);
            this.panel2.TabIndex = 5;
            // 
            // btnKTVXacNhan
            // 
            this.btnKTVXacNhan.Location = new System.Drawing.Point(249, 56);
            this.btnKTVXacNhan.Name = "btnKTVXacNhan";
            this.btnKTVXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnKTVXacNhan.TabIndex = 4;
            this.btnKTVXacNhan.Text = "Xác nhận";
            this.btnKTVXacNhan.UseVisualStyleBackColor = true;
            // 
            // txbKTVMoTa
            // 
            this.txbKTVMoTa.Location = new System.Drawing.Point(113, 3);
            this.txbKTVMoTa.Multiline = true;
            this.txbKTVMoTa.Name = "txbKTVMoTa";
            this.txbKTVMoTa.Size = new System.Drawing.Size(211, 50);
            this.txbKTVMoTa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mô tả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxMRI);
            this.panel1.Controls.Add(this.checkBoxCT);
            this.panel1.Controls.Add(this.checkBoxSieuAm);
            this.panel1.Controls.Add(this.checkBoxXquang);
            this.panel1.Controls.Add(this.checkBoxXetNg);
            this.panel1.Location = new System.Drawing.Point(51, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 78);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxMRI
            // 
            this.checkBoxMRI.AutoSize = true;
            this.checkBoxMRI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMRI.Location = new System.Drawing.Point(113, 51);
            this.checkBoxMRI.Name = "checkBoxMRI";
            this.checkBoxMRI.Size = new System.Drawing.Size(51, 21);
            this.checkBoxMRI.TabIndex = 9;
            this.checkBoxMRI.Text = "MRI";
            this.checkBoxMRI.UseVisualStyleBackColor = true;
            // 
            // checkBoxCT
            // 
            this.checkBoxCT.AutoSize = true;
            this.checkBoxCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCT.Location = new System.Drawing.Point(5, 51);
            this.checkBoxCT.Name = "checkBoxCT";
            this.checkBoxCT.Size = new System.Drawing.Size(45, 21);
            this.checkBoxCT.TabIndex = 8;
            this.checkBoxCT.Text = "CT";
            this.checkBoxCT.UseVisualStyleBackColor = true;
            // 
            // checkBoxSieuAm
            // 
            this.checkBoxSieuAm.AutoSize = true;
            this.checkBoxSieuAm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSieuAm.Location = new System.Drawing.Point(202, 12);
            this.checkBoxSieuAm.Name = "checkBoxSieuAm";
            this.checkBoxSieuAm.Size = new System.Drawing.Size(78, 21);
            this.checkBoxSieuAm.TabIndex = 7;
            this.checkBoxSieuAm.Text = "Siêu âm";
            this.checkBoxSieuAm.UseVisualStyleBackColor = true;
            // 
            // checkBoxXquang
            // 
            this.checkBoxXquang.AutoSize = true;
            this.checkBoxXquang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXquang.Location = new System.Drawing.Point(113, 12);
            this.checkBoxXquang.Name = "checkBoxXquang";
            this.checkBoxXquang.Size = new System.Drawing.Size(84, 21);
            this.checkBoxXquang.TabIndex = 6;
            this.checkBoxXquang.Text = "X-Quang";
            this.checkBoxXquang.UseVisualStyleBackColor = true;
            // 
            // checkBoxXetNg
            // 
            this.checkBoxXetNg.AutoSize = true;
            this.checkBoxXetNg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxXetNg.Location = new System.Drawing.Point(5, 12);
            this.checkBoxXetNg.Name = "checkBoxXetNg";
            this.checkBoxXetNg.Size = new System.Drawing.Size(98, 21);
            this.checkBoxXetNg.TabIndex = 5;
            this.checkBoxXetNg.Text = "Xét nghiệm";
            this.checkBoxXetNg.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbxKTVTenBN);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(51, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(324, 37);
            this.panel4.TabIndex = 4;
            // 
            // cbxKTVTenBN
            // 
            this.cbxKTVTenBN.FormattingEnabled = true;
            this.cbxKTVTenBN.Location = new System.Drawing.Point(113, 9);
            this.cbxKTVTenBN.Name = "cbxKTVTenBN";
            this.cbxKTVTenBN.Size = new System.Drawing.Size(208, 21);
            this.cbxKTVTenBN.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // fKyThuatVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 288);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "fKyThuatVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kỹ thuật viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThuocDSBN)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewThuocDSBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxMRI;
        private System.Windows.Forms.CheckBox checkBoxCT;
        private System.Windows.Forms.CheckBox checkBoxSieuAm;
        private System.Windows.Forms.CheckBox checkBoxXquang;
        private System.Windows.Forms.CheckBox checkBoxXetNg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbxKTVTenBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKTVXacNhan;
        private System.Windows.Forms.TextBox txbKTVMoTa;
        private System.Windows.Forms.Label label2;
    }
}