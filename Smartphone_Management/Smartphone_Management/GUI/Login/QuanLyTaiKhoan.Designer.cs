using System.Drawing;
using System.Windows.Forms;

namespace Smartphone_Management.GUI.Login
{
    partial class QuanLyTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.init = new System.Windows.Forms.Timer(this.components);
            this.cbHoatDong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton5 = new Smartphone_Management.GUI.Login.VBButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnXoaTaiKhoan = new Smartphone_Management.GUI.Login.VBButton();
            this.btnSearch = new Smartphone_Management.GUI.Login.VBButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.Location = new System.Drawing.Point(33, 111);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView.RowTemplate.Height = 35;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(940, 418);
            this.dataGridView.TabIndex = 17;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            this.dataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_RowsRemoved);
            // 
            // ScrollBar
            // 
            this.ScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBar.Location = new System.Drawing.Point(1061, 157);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(21, 383);
            this.ScrollBar.TabIndex = 20;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-user-100.png");
            this.imageList1.Images.SetKeyName(1, "icons8-checkmark-64.png");
            this.imageList1.Images.SetKeyName(2, "icons8-cancel-64.png");
            // 
            // init
            // 
            this.init.Enabled = true;
            this.init.Interval = 300;
            this.init.Tick += new System.EventHandler(this.init_Tick);
            // 
            // cbHoatDong
            // 
            this.cbHoatDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHoatDong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHoatDong.ForeColor = System.Drawing.Color.Teal;
            this.cbHoatDong.FormattingEnabled = true;
            this.cbHoatDong.Items.AddRange(new object[] {
            "Tất cả",
            "Đang hoạt động",
            "Tắt hoạt động"});
            this.cbHoatDong.Location = new System.Drawing.Point(589, 71);
            this.cbHoatDong.Margin = new System.Windows.Forms.Padding(2);
            this.cbHoatDong.Name = "cbHoatDong";
            this.cbHoatDong.Size = new System.Drawing.Size(147, 27);
            this.cbHoatDong.TabIndex = 27;
            this.cbHoatDong.SelectedValueChanged += new System.EventHandler(this.cbHoatDong_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(489, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Trạng thái:";
            // 
            // vbButton5
            // 
            this.vbButton5.BackColor = System.Drawing.Color.LightCoral;
            this.vbButton5.BackgroundColor = System.Drawing.Color.LightCoral;
            this.vbButton5.BorderColor = System.Drawing.Color.PeachPuff;
            this.vbButton5.BorderRadius = 15;
            this.vbButton5.BorderSize = 0;
            this.vbButton5.FlatAppearance.BorderSize = 0;
            this.vbButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbButton5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton5.ForeColor = System.Drawing.Color.White;
            this.vbButton5.Location = new System.Drawing.Point(33, 10);
            this.vbButton5.Margin = new System.Windows.Forms.Padding(2);
            this.vbButton5.Name = "vbButton5";
            this.vbButton5.Size = new System.Drawing.Size(175, 37);
            this.vbButton5.TabIndex = 25;
            this.vbButton5.Text = "Thêm tài khoản";
            this.vbButton5.TextColor = System.Drawing.Color.White;
            this.vbButton5.UseVisualStyleBackColor = false;
            this.vbButton5.Click += new System.EventHandler(this.vbButton5_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.RosyBrown;
            this.btnXoaTaiKhoan.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnXoaTaiKhoan.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnXoaTaiKhoan.BorderRadius = 15;
            this.btnXoaTaiKhoan.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(221, 11);
            this.btnXoaTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(175, 37);
            this.btnXoaTaiKhoan.TabIndex = 29;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.TextColor = System.Drawing.Color.White;
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.LightPink;
            this.btnSearch.BackgroundColor = System.Drawing.Color.LightPink;
            this.btnSearch.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.BorderSize = 0;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(938, 68);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(2);
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.TextColor = System.Drawing.Color.White;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.vbButton2_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 32;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(740, 66);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(2);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(194, 35);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Tìm kiếm";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChange += new System.EventHandler(this.txtSearch_TextChange);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 540);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbHoatDong);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.vbButton5);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.Shown += new System.EventHandler(this.QuanLyTaiKhoan_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private VBButton btnSearch;
        private DataGridView dataGridView;
        private VScrollBar ScrollBar;
        private ImageList imageList1;
        private Timer init;
        private VBButton vbButton5;
        private ComboBox cbHoatDong;
        private Label label1;
        private Timer timer1;
        private VBButton btnXoaTaiKhoan;
    }
}