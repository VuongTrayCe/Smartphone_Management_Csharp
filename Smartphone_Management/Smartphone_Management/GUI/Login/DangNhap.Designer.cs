namespace Smartphone_Management.GUI.Login
{
    partial class DangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            //this.txtBoxUser = new JTextBox.JTextBox();
            //this.txtBoxPassword = new JTextBox.JTextBox();
            this.btnDangNhap = new Smartphone_Management.GUI.Login.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Smartphone_Management.Properties.Resources.background_welcome;
            this.pictureBox1.Location = new System.Drawing.Point(75, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Smartphone_Management.Properties.Resources.bg_user;
            this.pictureBox2.Location = new System.Drawing.Point(1067, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(1029, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đăng nhập để sử dụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(955, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(955, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mật khẩu";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.AutoSize = true;
            this.txtBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtBoxUser.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtBoxUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxUser.Hint = "";
            this.txtBoxUser.IsPassword = false;
            this.txtBoxUser.Length = 0;
            this.txtBoxUser.Location = new System.Drawing.Point(959, 305);
            this.txtBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.OnFocus = System.Drawing.Color.LightSkyBlue;
            this.txtBoxUser.OnlyChar = false;
            this.txtBoxUser.OnlyNumber = false;
            this.txtBoxUser.Size = new System.Drawing.Size(336, 48);
            this.txtBoxUser.TabIndex = 8;
            this.txtBoxUser.TextValue = "";
            this.txtBoxUser.Load += new System.EventHandler(this.txtBoxUser_Load);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AutoSize = true;
            this.txtBoxPassword.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxPassword.Hint = "";
            this.txtBoxPassword.IsPassword = true;
            this.txtBoxPassword.Length = 0;
            this.txtBoxPassword.Location = new System.Drawing.Point(959, 403);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.OnFocus = System.Drawing.Color.LightSkyBlue;
            this.txtBoxPassword.OnlyChar = false;
            this.txtBoxPassword.OnlyNumber = false;
            this.txtBoxPassword.Size = new System.Drawing.Size(336, 48);
            this.txtBoxPassword.TabIndex = 8;
            this.txtBoxPassword.TextValue = "";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(959, 472);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(336, 48);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1445, 665);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DangNhap";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private JTextBox.JTextBox txtBoxUser;
        private JTextBox.JTextBox txtBoxPassword;
        private VBButton btnDangNhap;
    }
}