namespace Smartphone_Management.GUI.DonHang
{
    partial class QuanLyDonHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDonHang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges9 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Xem = new System.Windows.Forms.DataGridViewImageColumn();
            this.In = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnXem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnXuatExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPrint = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DateEnd);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dateStart);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Location = new System.Drawing.Point(175, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 24);
            this.panel1.TabIndex = 1;
            // 
            // DateEnd
            // 
            this.DateEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.Location = new System.Drawing.Point(461, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(112, 22);
            this.DateEnd.TabIndex = 6;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(379, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(82, 24);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Đến Ngày";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(362, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 24);
            this.panel4.TabIndex = 4;
            // 
            // dateStart
            // 
            this.dateStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(250, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(112, 22);
            this.dateStart.TabIndex = 2;
            this.dateStart.Value = new System.DateTime(1753, 7, 10, 0, 0, 0, 0);
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(177, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(73, 24);
            this.panel3.TabIndex = 3;
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(73, 24);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Từ Ngày";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(160, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 24);
            this.panel2.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 20;
            this.btnTimKiem.Location = new System.Drawing.Point(134, 0);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(26, 24);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTimKiem.Location = new System.Drawing.Point(0, 0);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(134, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(24, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(145, 41);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Đặt Hàng";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "In";
            this.dataGridViewImageColumn1.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "In";
            this.dataGridViewImageColumn2.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xem,
            this.In});
            this.dataGridView1.Location = new System.Drawing.Point(24, 129);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(696, 294);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Image = global::Smartphone_Management.Properties.Resources.icon_eye2;
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Width = 40;
            // 
            // In
            // 
            this.In.HeaderText = "In";
            this.In.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.In.Name = "In";
            this.In.ReadOnly = true;
            this.In.Width = 30;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.cbbTrangThai);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(353, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 23);
            this.panel6.TabIndex = 4;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đặt Hàng",
            "Hoàn Thành",
            "Đã Hủy"});
            this.cbbTrangThai.Location = new System.Drawing.Point(104, 0);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(119, 24);
            this.cbbTrangThai.TabIndex = 1;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.iconButton3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(104, 23);
            this.panel7.TabIndex = 0;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(98, 23);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Trạng Thái";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnXem
            // 
            this.btnXem.AllowAnimations = true;
            this.btnXem.AllowMouseEffects = true;
            this.btnXem.AllowToggling = false;
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.AnimationSpeed = 200;
            this.btnXem.AutoGenerateColors = false;
            this.btnXem.AutoRoundBorders = false;
            this.btnXem.AutoSizeLeftIcon = true;
            this.btnXem.AutoSizeRightIcon = true;
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXem.BackgroundImage")));
            this.btnXem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.ButtonText = "Xem";
            this.btnXem.ButtonTextMarginLeft = 0;
            this.btnXem.ColorContrastOnClick = 45;
            this.btnXem.ColorContrastOnHover = 45;
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnXem.CustomizableEdges = borderEdges7;
            this.btnXem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXem.IconMarginLeft = 11;
            this.btnXem.IconPadding = 10;
            this.btnXem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXem.IconSize = 25;
            this.btnXem.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.IdleBorderRadius = 1;
            this.btnXem.IdleBorderThickness = 1;
            this.btnXem.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.IdleIconLeftImage = null;
            this.btnXem.IdleIconRightImage = null;
            this.btnXem.IndicateFocus = false;
            this.btnXem.Location = new System.Drawing.Point(735, 129);
            this.btnXem.Name = "btnXem";
            this.btnXem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXem.OnDisabledState.BorderRadius = 1;
            this.btnXem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnDisabledState.BorderThickness = 1;
            this.btnXem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXem.OnDisabledState.IconLeftImage = null;
            this.btnXem.OnDisabledState.IconRightImage = null;
            this.btnXem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXem.onHoverState.BorderRadius = 1;
            this.btnXem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.onHoverState.BorderThickness = 1;
            this.btnXem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXem.onHoverState.IconLeftImage = null;
            this.btnXem.onHoverState.IconRightImage = null;
            this.btnXem.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.OnIdleState.BorderRadius = 1;
            this.btnXem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnIdleState.BorderThickness = 1;
            this.btnXem.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXem.OnIdleState.IconLeftImage = null;
            this.btnXem.OnIdleState.IconRightImage = null;
            this.btnXem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXem.OnPressedState.BorderRadius = 1;
            this.btnXem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXem.OnPressedState.BorderThickness = 1;
            this.btnXem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXem.OnPressedState.IconLeftImage = null;
            this.btnXem.OnPressedState.IconRightImage = null;
            this.btnXem.Size = new System.Drawing.Size(104, 39);
            this.btnXem.TabIndex = 6;
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXem.TextMarginLeft = 0;
            this.btnXem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXem.UseDefaultRadiusAndThickness = true;
            this.btnXem.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AllowAnimations = true;
            this.btnXuatExcel.AllowMouseEffects = true;
            this.btnXuatExcel.AllowToggling = false;
            this.btnXuatExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExcel.AnimationSpeed = 200;
            this.btnXuatExcel.AutoGenerateColors = false;
            this.btnXuatExcel.AutoRoundBorders = false;
            this.btnXuatExcel.AutoSizeLeftIcon = true;
            this.btnXuatExcel.AutoSizeRightIcon = true;
            this.btnXuatExcel.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatExcel.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.BackgroundImage")));
            this.btnXuatExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.ButtonText = "Xuất Excel";
            this.btnXuatExcel.ButtonTextMarginLeft = 0;
            this.btnXuatExcel.ColorContrastOnClick = 45;
            this.btnXuatExcel.ColorContrastOnHover = 45;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnXuatExcel.CustomizableEdges = borderEdges8;
            this.btnXuatExcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuatExcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuatExcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuatExcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuatExcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuatExcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXuatExcel.IconMarginLeft = 11;
            this.btnXuatExcel.IconPadding = 10;
            this.btnXuatExcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuatExcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXuatExcel.IconSize = 25;
            this.btnXuatExcel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.IdleBorderRadius = 1;
            this.btnXuatExcel.IdleBorderThickness = 1;
            this.btnXuatExcel.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.IdleIconLeftImage = null;
            this.btnXuatExcel.IdleIconRightImage = null;
            this.btnXuatExcel.IndicateFocus = false;
            this.btnXuatExcel.Location = new System.Drawing.Point(736, 189);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuatExcel.OnDisabledState.BorderRadius = 1;
            this.btnXuatExcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.OnDisabledState.BorderThickness = 1;
            this.btnXuatExcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuatExcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuatExcel.OnDisabledState.IconLeftImage = null;
            this.btnXuatExcel.OnDisabledState.IconRightImage = null;
            this.btnXuatExcel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.onHoverState.BorderRadius = 1;
            this.btnXuatExcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.onHoverState.BorderThickness = 1;
            this.btnXuatExcel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXuatExcel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.onHoverState.IconLeftImage = null;
            this.btnXuatExcel.onHoverState.IconRightImage = null;
            this.btnXuatExcel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.OnIdleState.BorderRadius = 1;
            this.btnXuatExcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.OnIdleState.BorderThickness = 1;
            this.btnXuatExcel.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatExcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.OnIdleState.IconLeftImage = null;
            this.btnXuatExcel.OnIdleState.IconRightImage = null;
            this.btnXuatExcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuatExcel.OnPressedState.BorderRadius = 1;
            this.btnXuatExcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.OnPressedState.BorderThickness = 1;
            this.btnXuatExcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuatExcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.OnPressedState.IconLeftImage = null;
            this.btnXuatExcel.OnPressedState.IconRightImage = null;
            this.btnXuatExcel.Size = new System.Drawing.Size(104, 39);
            this.btnXuatExcel.TabIndex = 6;
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuatExcel.TextMarginLeft = 0;
            this.btnXuatExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.UseDefaultRadiusAndThickness = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AllowAnimations = true;
            this.btnPrint.AllowMouseEffects = true;
            this.btnPrint.AllowToggling = false;
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.AnimationSpeed = 200;
            this.btnPrint.AutoGenerateColors = false;
            this.btnPrint.AutoRoundBorders = false;
            this.btnPrint.AutoSizeLeftIcon = true;
            this.btnPrint.AutoSizeRightIcon = true;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.ButtonText = "Print";
            this.btnPrint.ButtonTextMarginLeft = 0;
            this.btnPrint.ColorContrastOnClick = 45;
            this.btnPrint.ColorContrastOnHover = 45;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges9.BottomLeft = true;
            borderEdges9.BottomRight = true;
            borderEdges9.TopLeft = true;
            borderEdges9.TopRight = true;
            this.btnPrint.CustomizableEdges = borderEdges9;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrint.IconMarginLeft = 11;
            this.btnPrint.IconPadding = 10;
            this.btnPrint.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrint.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrint.IconSize = 25;
            this.btnPrint.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.IdleBorderRadius = 1;
            this.btnPrint.IdleBorderThickness = 1;
            this.btnPrint.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.IdleIconLeftImage = null;
            this.btnPrint.IdleIconRightImage = null;
            this.btnPrint.IndicateFocus = false;
            this.btnPrint.Location = new System.Drawing.Point(735, 246);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrint.OnDisabledState.BorderRadius = 1;
            this.btnPrint.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnDisabledState.BorderThickness = 1;
            this.btnPrint.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrint.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrint.OnDisabledState.IconLeftImage = null;
            this.btnPrint.OnDisabledState.IconRightImage = null;
            this.btnPrint.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.BorderRadius = 1;
            this.btnPrint.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.onHoverState.BorderThickness = 1;
            this.btnPrint.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrint.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.onHoverState.IconLeftImage = null;
            this.btnPrint.onHoverState.IconRightImage = null;
            this.btnPrint.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.OnIdleState.BorderRadius = 1;
            this.btnPrint.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnIdleState.BorderThickness = 1;
            this.btnPrint.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnIdleState.IconLeftImage = null;
            this.btnPrint.OnIdleState.IconRightImage = null;
            this.btnPrint.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.BorderRadius = 1;
            this.btnPrint.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrint.OnPressedState.BorderThickness = 1;
            this.btnPrint.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrint.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPrint.OnPressedState.IconLeftImage = null;
            this.btnPrint.OnPressedState.IconRightImage = null;
            this.btnPrint.Size = new System.Drawing.Size(105, 39);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrint.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.TextMarginLeft = 0;
            this.btnPrint.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrint.UseDefaultRadiusAndThickness = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 465);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyDonHang";
            this.Text = "QuanLyDonHang";
            this.Load += new System.EventHandler(this.QuanLyDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.DataGridViewImageColumn Xem;
        private System.Windows.Forms.DataGridViewImageColumn In;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXuatExcel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrint;
    }
}