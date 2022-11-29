namespace Smartphone_Management.GUI.Login
{
    partial class ThemQuyenTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemQuyenTaiKhoan));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cbMaQuyen = new System.Windows.Forms.ComboBox();
            this.btnXacNhanNhanVien = new Smartphone_Management.GUI.Login.VBButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Back = new Smartphone_Management.GUI.Login.VBButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMaTaiKhoan);
            this.groupBox1.Controls.Add(this.cbMaQuyen);
            this.groupBox1.Controls.Add(this.btnXacNhanNhanVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(32, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 609);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Quyền - Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(168, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã tài khoản:";
            // 
            // cbMaTaiKhoan
            // 
            this.cbMaTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTaiKhoan.ForeColor = System.Drawing.Color.Teal;
            this.cbMaTaiKhoan.FormattingEnabled = true;
            this.cbMaTaiKhoan.Location = new System.Drawing.Point(171, 401);
            this.cbMaTaiKhoan.Name = "cbMaTaiKhoan";
            this.cbMaTaiKhoan.Size = new System.Drawing.Size(336, 27);
            this.cbMaTaiKhoan.TabIndex = 18;
            // 
            // cbMaQuyen
            // 
            this.cbMaQuyen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaQuyen.ForeColor = System.Drawing.Color.Teal;
            this.cbMaQuyen.FormattingEnabled = true;
            this.cbMaQuyen.Location = new System.Drawing.Point(171, 289);
            this.cbMaQuyen.Name = "cbMaQuyen";
            this.cbMaQuyen.Size = new System.Drawing.Size(336, 27);
            this.cbMaQuyen.TabIndex = 17;
            // 
            // btnXacNhanNhanVien
            // 
            this.btnXacNhanNhanVien.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXacNhanNhanVien.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnXacNhanNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhanNhanVien.BorderRadius = 20;
            this.btnXacNhanNhanVien.BorderSize = 0;
            this.btnXacNhanNhanVien.FlatAppearance.BorderSize = 0;
            this.btnXacNhanNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanNhanVien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanNhanVien.Location = new System.Drawing.Point(192, 491);
            this.btnXacNhanNhanVien.Name = "btnXacNhanNhanVien";
            this.btnXacNhanNhanVien.Size = new System.Drawing.Size(281, 48);
            this.btnXacNhanNhanVien.TabIndex = 11;
            this.btnXacNhanNhanVien.Text = "Xác nhận";
            this.btnXacNhanNhanVien.TextColor = System.Drawing.Color.White;
            this.btnXacNhanNhanVien.UseVisualStyleBackColor = false;
            this.btnXacNhanNhanVien.Click += new System.EventHandler(this.btnXacNhanNhanVien_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(168, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Mã Quyền:";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.LavenderBlush;
            this.btn_Back.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.btn_Back.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Back.BorderRadius = 15;
            this.btn_Back.BorderSize = 0;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.White;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.Location = new System.Drawing.Point(32, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Back.Size = new System.Drawing.Size(43, 40);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.TextColor = System.Drawing.Color.White;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ThemQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(755, 717);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ThemQuyenTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Quyền Tài Khoản";
            this.Load += new System.EventHandler(this.ThemQuyenTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaTaiKhoan;
        private System.Windows.Forms.ComboBox cbMaQuyen;
        private VBButton btnXacNhanNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VBButton btn_Back;
    }
}