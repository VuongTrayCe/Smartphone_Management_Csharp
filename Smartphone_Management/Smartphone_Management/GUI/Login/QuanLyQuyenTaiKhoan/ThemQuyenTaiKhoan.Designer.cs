namespace Smartphone_Management.GUI.Login.QuanLyQuyenTaiKhoan
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaTaiKhoan = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbQuyenHienTai = new System.Windows.Forms.ComboBox();
            this.cbbQuyenMoi = new System.Windows.Forms.ComboBox();
            this.txtTenNhanvien = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Back = new Smartphone_Management.GUI.Login.VBButton();
            this.btnXacNhanNhanVien = new Smartphone_Management.GUI.Login.VBButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtTenNhanvien);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbQuyenMoi);
            this.groupBox1.Controls.Add(this.cbbQuyenHienTai);
            this.groupBox1.Controls.Add(this.cbMaTaiKhoan);
            this.groupBox1.Controls.Add(this.btnXacNhanNhanVien);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(24, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(547, 532);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm Quyền - Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(4, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã tài khoản:";
            // 
            // cbMaTaiKhoan
            // 
            this.cbMaTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTaiKhoan.ForeColor = System.Drawing.Color.Teal;
            this.cbMaTaiKhoan.FormattingEnabled = true;
            this.cbMaTaiKhoan.Location = new System.Drawing.Point(159, 187);
            this.cbMaTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMaTaiKhoan.Name = "cbMaTaiKhoan";
            this.cbMaTaiKhoan.Size = new System.Drawing.Size(280, 24);
            this.cbMaTaiKhoan.TabIndex = 18;
            this.cbMaTaiKhoan.SelectedIndexChanged += new System.EventHandler(this.cbMaTaiKhoan_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quyền Hiện Tại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quyền Mới";
            // 
            // cbbQuyenHienTai
            // 
            this.cbbQuyenHienTai.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyenHienTai.ForeColor = System.Drawing.Color.Teal;
            this.cbbQuyenHienTai.FormattingEnabled = true;
            this.cbbQuyenHienTai.Location = new System.Drawing.Point(159, 280);
            this.cbbQuyenHienTai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbQuyenHienTai.Name = "cbbQuyenHienTai";
            this.cbbQuyenHienTai.Size = new System.Drawing.Size(280, 24);
            this.cbbQuyenHienTai.TabIndex = 18;
            // 
            // cbbQuyenMoi
            // 
            this.cbbQuyenMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyenMoi.ForeColor = System.Drawing.Color.Teal;
            this.cbbQuyenMoi.FormattingEnabled = true;
            this.cbbQuyenMoi.Location = new System.Drawing.Point(159, 328);
            this.cbbQuyenMoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbQuyenMoi.Name = "cbbQuyenMoi";
            this.cbbQuyenMoi.Size = new System.Drawing.Size(280, 24);
            this.cbbQuyenMoi.TabIndex = 18;
            // 
            // txtTenNhanvien
            // 
            this.txtTenNhanvien.AcceptsReturn = false;
            this.txtTenNhanvien.AcceptsTab = false;
            this.txtTenNhanvien.AnimationSpeed = 200;
            this.txtTenNhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTenNhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTenNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNhanvien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTenNhanvien.BackgroundImage")));
            this.txtTenNhanvien.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTenNhanvien.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTenNhanvien.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTenNhanvien.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTenNhanvien.BorderRadius = 1;
            this.txtTenNhanvien.BorderThickness = 1;
            this.txtTenNhanvien.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTenNhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanvien.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTenNhanvien.DefaultText = "";
            this.txtTenNhanvien.FillColor = System.Drawing.Color.White;
            this.txtTenNhanvien.HideSelection = true;
            this.txtTenNhanvien.IconLeft = null;
            this.txtTenNhanvien.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanvien.IconPadding = 10;
            this.txtTenNhanvien.IconRight = null;
            this.txtTenNhanvien.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanvien.Lines = new string[0];
            this.txtTenNhanvien.Location = new System.Drawing.Point(159, 216);
            this.txtTenNhanvien.MaxLength = 32767;
            this.txtTenNhanvien.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTenNhanvien.Modified = false;
            this.txtTenNhanvien.Multiline = false;
            this.txtTenNhanvien.Name = "txtTenNhanvien";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenNhanvien.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenNhanvien.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenNhanvien.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTenNhanvien.OnIdleState = stateProperties4;
            this.txtTenNhanvien.Padding = new System.Windows.Forms.Padding(3);
            this.txtTenNhanvien.PasswordChar = '\0';
            this.txtTenNhanvien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenNhanvien.PlaceholderText = "Enter text";
            this.txtTenNhanvien.ReadOnly = false;
            this.txtTenNhanvien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenNhanvien.SelectedText = "";
            this.txtTenNhanvien.SelectionLength = 0;
            this.txtTenNhanvien.SelectionStart = 0;
            this.txtTenNhanvien.ShortcutsEnabled = true;
            this.txtTenNhanvien.Size = new System.Drawing.Size(280, 37);
            this.txtTenNhanvien.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTenNhanvien.TabIndex = 21;
            this.txtTenNhanvien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTenNhanvien.TextMarginBottom = 0;
            this.txtTenNhanvien.TextMarginLeft = 3;
            this.txtTenNhanvien.TextMarginTop = 0;
            this.txtTenNhanvien.TextPlaceholder = "Enter text";
            this.txtTenNhanvien.UseSystemPasswordChar = false;
            this.txtTenNhanvien.WordWrap = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Smartphone_Management.Properties.Resources.Add___Copy;
            this.button1.Location = new System.Drawing.Point(444, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 32);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.btn_Back.Location = new System.Drawing.Point(24, 10);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Back.Size = new System.Drawing.Size(32, 32);
            this.btn_Back.TabIndex = 20;
            this.btn_Back.TextColor = System.Drawing.Color.White;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
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
            this.btnXacNhanNhanVien.Location = new System.Drawing.Point(159, 402);
            this.btnXacNhanNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhanNhanVien.Name = "btnXacNhanNhanVien";
            this.btnXacNhanNhanVien.Size = new System.Drawing.Size(211, 39);
            this.btnXacNhanNhanVien.TabIndex = 11;
            this.btnXacNhanNhanVien.Text = "Xác nhận";
            this.btnXacNhanNhanVien.TextColor = System.Drawing.Color.White;
            this.btnXacNhanNhanVien.UseVisualStyleBackColor = false;
            this.btnXacNhanNhanVien.Click += new System.EventHandler(this.btnXacNhanNhanVien_Click);
            // 
            // ThemQuyenTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(582, 529);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private VBButton btnXacNhanNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VBButton btn_Back;
        private Bunifu.UI.WinForms.BunifuTextBox txtTenNhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQuyenHienTai;
        private System.Windows.Forms.ComboBox cbbQuyenMoi;
        private System.Windows.Forms.Button button1;
    }
}