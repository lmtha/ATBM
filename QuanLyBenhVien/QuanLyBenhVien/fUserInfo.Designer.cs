namespace QuanLyBenhVien
{
    partial class fUserInfo
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
            this.btnDsUser = new System.Windows.Forms.Button();
            this.btnInfoPrivilleges = new System.Windows.Forms.Button();
            this.dataGridViewInfoUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDsUser
            // 
            this.btnDsUser.Location = new System.Drawing.Point(12, 12);
            this.btnDsUser.Name = "btnDsUser";
            this.btnDsUser.Size = new System.Drawing.Size(112, 35);
            this.btnDsUser.TabIndex = 0;
            this.btnDsUser.Text = "Xem danh sách user";
            this.btnDsUser.UseVisualStyleBackColor = true;
            this.btnDsUser.Click += new System.EventHandler(this.btnDsUser_Click);
            // 
            // btnInfoPrivilleges
            // 
            this.btnInfoPrivilleges.Location = new System.Drawing.Point(130, 12);
            this.btnInfoPrivilleges.Name = "btnInfoPrivilleges";
            this.btnInfoPrivilleges.Size = new System.Drawing.Size(142, 35);
            this.btnInfoPrivilleges.TabIndex = 1;
            this.btnInfoPrivilleges.Text = "Thông tin privileges user";
            this.btnInfoPrivilleges.UseVisualStyleBackColor = true;
            this.btnInfoPrivilleges.Click += new System.EventHandler(this.btnInfoPrivilleges_Click);
            // 
            // dataGridViewInfoUser
            // 
            this.dataGridViewInfoUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoUser.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewInfoUser.Name = "dataGridViewInfoUser";
            this.dataGridViewInfoUser.Size = new System.Drawing.Size(733, 305);
            this.dataGridViewInfoUser.TabIndex = 2;
            // 
            // fUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(757, 370);
            this.Controls.Add(this.dataGridViewInfoUser);
            this.Controls.Add(this.btnInfoPrivilleges);
            this.Controls.Add(this.btnDsUser);
            this.MaximizeBox = false;
            this.Name = "fUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin user";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDsUser;
        private System.Windows.Forms.Button btnInfoPrivilleges;
        private System.Windows.Forms.DataGridView dataGridViewInfoUser;
    }
}