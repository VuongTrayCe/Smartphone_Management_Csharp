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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxem = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTimKiem = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnXuatEcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.dataGirdView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Xem = new System.Windows.Forms.DataGridViewImageColumn();
            this.In = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateEnd
            // 
            this.DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEnd.Location = new System.Drawing.Point(88, 53);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(112, 21);
            this.DateEnd.TabIndex = 6;
            // 
            // dateStart
            // 
            this.dateStart.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(88, 23);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(112, 21);
            this.dateStart.TabIndex = 2;
            this.dateStart.Value = new System.DateTime(1753, 7, 10, 0, 0, 0, 0);
            this.dateStart.ValueChanged += new System.EventHandler(this.dateStart_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 41);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn Đặt Hàng";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(11, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(183, 23);
            this.panel6.TabIndex = 4;
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
            this.iconButton3.BackColor = System.Drawing.Color.Black;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(90, 23);
            this.iconButton3.TabIndex = 0;
            this.iconButton3.Text = "Trạng Thái";
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Đặt Hàng",
            "Hoàn Thành",
            "Đã Hủy"});
            this.cbbTrangThai.Location = new System.Drawing.Point(11, 110);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(183, 23);
            this.cbbTrangThai.TabIndex = 1;
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnxem);
            this.groupBox1.Controls.Add(this.cbbTrangThai);
            this.groupBox1.Controls.Add(this.iconButton2);
            this.groupBox1.Controls.Add(this.iconButton1);
            this.groupBox1.Controls.Add(this.dateStart);
            this.groupBox1.Controls.Add(this.DateEnd);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(634, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 308);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nâng Cao";
            // 
            // btnxem
            // 
            this.btnxem.AllowAnimations = true;
            this.btnxem.AllowMouseEffects = true;
            this.btnxem.AllowToggling = false;
            this.btnxem.AnimationSpeed = 200;
            this.btnxem.AutoGenerateColors = false;
            this.btnxem.AutoRoundBorders = false;
            this.btnxem.AutoSizeLeftIcon = true;
            this.btnxem.AutoSizeRightIcon = true;
            this.btnxem.BackColor = System.Drawing.Color.Transparent;
            this.btnxem.BackColor1 = System.Drawing.Color.Black;
            this.btnxem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnxem.BackgroundImage")));
            this.btnxem.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnxem.ButtonText = "Xem";
            this.btnxem.ButtonTextMarginLeft = 0;
            this.btnxem.ColorContrastOnClick = 45;
            this.btnxem.ColorContrastOnHover = 45;
            this.btnxem.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnxem.CustomizableEdges = borderEdges1;
            this.btnxem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnxem.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnxem.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnxem.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnxem.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnxem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.ForeColor = System.Drawing.Color.White;
            this.btnxem.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxem.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnxem.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnxem.IconMarginLeft = 11;
            this.btnxem.IconPadding = 10;
            this.btnxem.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxem.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnxem.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnxem.IconSize = 25;
            this.btnxem.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnxem.IdleBorderRadius = 1;
            this.btnxem.IdleBorderThickness = 1;
            this.btnxem.IdleFillColor = System.Drawing.Color.Black;
            this.btnxem.IdleIconLeftImage = null;
            this.btnxem.IdleIconRightImage = null;
            this.btnxem.IndicateFocus = false;
            this.btnxem.Location = new System.Drawing.Point(11, 148);
            this.btnxem.Name = "btnxem";
            this.btnxem.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnxem.OnDisabledState.BorderRadius = 1;
            this.btnxem.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnxem.OnDisabledState.BorderThickness = 1;
            this.btnxem.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnxem.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnxem.OnDisabledState.IconLeftImage = null;
            this.btnxem.OnDisabledState.IconRightImage = null;
            this.btnxem.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnxem.onHoverState.BorderRadius = 1;
            this.btnxem.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnxem.onHoverState.BorderThickness = 1;
            this.btnxem.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnxem.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnxem.onHoverState.IconLeftImage = null;
            this.btnxem.onHoverState.IconRightImage = null;
            this.btnxem.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnxem.OnIdleState.BorderRadius = 1;
            this.btnxem.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnxem.OnIdleState.BorderThickness = 1;
            this.btnxem.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnxem.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnxem.OnIdleState.IconLeftImage = null;
            this.btnxem.OnIdleState.IconRightImage = null;
            this.btnxem.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnxem.OnPressedState.BorderRadius = 1;
            this.btnxem.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnxem.OnPressedState.BorderThickness = 1;
            this.btnxem.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnxem.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnxem.OnPressedState.IconLeftImage = null;
            this.btnxem.OnPressedState.IconRightImage = null;
            this.btnxem.Size = new System.Drawing.Size(183, 31);
            this.btnxem.TabIndex = 7;
            this.btnxem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxem.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnxem.TextMarginLeft = 0;
            this.btnxem.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnxem.UseDefaultRadiusAndThickness = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Black;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(11, 21);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(73, 24);
            this.iconButton2.TabIndex = 0;
            this.iconButton2.Text = "Từ Ngày";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Transparent;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(11, 51);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(73, 24);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Đến Ngày";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "In";
            this.dataGridViewImageColumn1.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 40;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "In";
            this.dataGridViewImageColumn2.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AcceptsReturn = false;
            this.txtTimKiem.AcceptsTab = false;
            this.txtTimKiem.AnimationSpeed = 200;
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.BackgroundImage")));
            this.txtTimKiem.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtTimKiem.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTimKiem.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtTimKiem.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtTimKiem.BorderRadius = 1;
            this.txtTimKiem.BorderThickness = 1;
            this.txtTimKiem.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.FillColor = System.Drawing.Color.White;
            this.txtTimKiem.HideSelection = true;
            this.txtTimKiem.IconLeft = null;
            this.txtTimKiem.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.IconPadding = 10;
            this.txtTimKiem.IconRight = null;
            this.txtTimKiem.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.Lines = new string[0];
            this.txtTimKiem.Location = new System.Drawing.Point(3, 91);
            this.txtTimKiem.MaxLength = 32767;
            this.txtTimKiem.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtTimKiem.Modified = false;
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtTimKiem.OnIdleState = stateProperties4;
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(3);
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Enter text";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.SelectionLength = 0;
            this.txtTimKiem.SelectionStart = 0;
            this.txtTimKiem.ShortcutsEnabled = true;
            this.txtTimKiem.Size = new System.Drawing.Size(441, 37);
            this.txtTimKiem.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTimKiem.TextMarginBottom = 0;
            this.txtTimKiem.TextMarginLeft = 3;
            this.txtTimKiem.TextMarginTop = 0;
            this.txtTimKiem.TextPlaceholder = "Enter text";
            this.txtTimKiem.UseSystemPasswordChar = false;
            this.txtTimKiem.WordWrap = true;
            // 
            // btnXuatEcel
            // 
            this.btnXuatEcel.AllowAnimations = true;
            this.btnXuatEcel.AllowMouseEffects = true;
            this.btnXuatEcel.AllowToggling = false;
            this.btnXuatEcel.AnimationSpeed = 200;
            this.btnXuatEcel.AutoGenerateColors = false;
            this.btnXuatEcel.AutoRoundBorders = false;
            this.btnXuatEcel.AutoSizeLeftIcon = true;
            this.btnXuatEcel.AutoSizeRightIcon = true;
            this.btnXuatEcel.BackColor = System.Drawing.Color.Transparent;
            this.btnXuatEcel.BackColor1 = System.Drawing.Color.Black;
            this.btnXuatEcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatEcel.BackgroundImage")));
            this.btnXuatEcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatEcel.ButtonText = "Xuất Excel";
            this.btnXuatEcel.ButtonTextMarginLeft = 0;
            this.btnXuatEcel.ColorContrastOnClick = 45;
            this.btnXuatEcel.ColorContrastOnHover = 45;
            this.btnXuatEcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnXuatEcel.CustomizableEdges = borderEdges2;
            this.btnXuatEcel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXuatEcel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuatEcel.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuatEcel.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuatEcel.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnXuatEcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatEcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatEcel.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatEcel.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuatEcel.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnXuatEcel.IconMarginLeft = 11;
            this.btnXuatEcel.IconPadding = 10;
            this.btnXuatEcel.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatEcel.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnXuatEcel.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnXuatEcel.IconSize = 25;
            this.btnXuatEcel.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatEcel.IdleBorderRadius = 1;
            this.btnXuatEcel.IdleBorderThickness = 1;
            this.btnXuatEcel.IdleFillColor = System.Drawing.Color.Black;
            this.btnXuatEcel.IdleIconLeftImage = null;
            this.btnXuatEcel.IdleIconRightImage = null;
            this.btnXuatEcel.IndicateFocus = false;
            this.btnXuatEcel.Location = new System.Drawing.Point(726, 18);
            this.btnXuatEcel.Name = "btnXuatEcel";
            this.btnXuatEcel.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnXuatEcel.OnDisabledState.BorderRadius = 1;
            this.btnXuatEcel.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatEcel.OnDisabledState.BorderThickness = 1;
            this.btnXuatEcel.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnXuatEcel.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnXuatEcel.OnDisabledState.IconLeftImage = null;
            this.btnXuatEcel.OnDisabledState.IconRightImage = null;
            this.btnXuatEcel.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXuatEcel.onHoverState.BorderRadius = 1;
            this.btnXuatEcel.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatEcel.onHoverState.BorderThickness = 1;
            this.btnXuatEcel.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnXuatEcel.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnXuatEcel.onHoverState.IconLeftImage = null;
            this.btnXuatEcel.onHoverState.IconRightImage = null;
            this.btnXuatEcel.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnXuatEcel.OnIdleState.BorderRadius = 1;
            this.btnXuatEcel.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatEcel.OnIdleState.BorderThickness = 1;
            this.btnXuatEcel.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnXuatEcel.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnXuatEcel.OnIdleState.IconLeftImage = null;
            this.btnXuatEcel.OnIdleState.IconRightImage = null;
            this.btnXuatEcel.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuatEcel.OnPressedState.BorderRadius = 1;
            this.btnXuatEcel.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatEcel.OnPressedState.BorderThickness = 1;
            this.btnXuatEcel.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnXuatEcel.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnXuatEcel.OnPressedState.IconLeftImage = null;
            this.btnXuatEcel.OnPressedState.IconRightImage = null;
            this.btnXuatEcel.Size = new System.Drawing.Size(108, 31);
            this.btnXuatEcel.TabIndex = 7;
            this.btnXuatEcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatEcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuatEcel.TextMarginLeft = 0;
            this.btnXuatEcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXuatEcel.UseDefaultRadiusAndThickness = true;
            this.btnXuatEcel.Click += new System.EventHandler(this.btnXuatEcel_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(620, 18);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(98, 31);
            this.iconButton5.TabIndex = 5;
            this.iconButton5.Text = "Print";
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.Black;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 20;
            this.btnTimKiem.Location = new System.Drawing.Point(450, 90);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(36, 38);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGirdView1
            // 
            this.dataGirdView1.AllowCustomTheming = true;
            this.dataGirdView1.AllowUserToAddRows = false;
            this.dataGirdView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGirdView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGirdView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGirdView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGirdView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGirdView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGirdView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGirdView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGirdView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGirdView1.ColumnHeadersHeight = 40;
            this.dataGirdView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xem,
            this.In});
            this.dataGirdView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.dataGirdView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGirdView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGirdView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dataGirdView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGirdView1.CurrentTheme.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dataGirdView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataGirdView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DarkSlateGray;
            this.dataGirdView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGirdView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGirdView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.dataGirdView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGirdView1.CurrentTheme.Name = null;
            this.dataGirdView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.dataGirdView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGirdView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGirdView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.dataGirdView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGirdView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGirdView1.EnableHeadersVisualStyles = false;
            this.dataGirdView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.dataGirdView1.HeaderBackColor = System.Drawing.Color.DarkSlateGray;
            this.dataGirdView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGirdView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGirdView1.Location = new System.Drawing.Point(3, 134);
            this.dataGirdView1.MultiSelect = false;
            this.dataGirdView1.Name = "dataGirdView1";
            this.dataGirdView1.ReadOnly = true;
            this.dataGirdView1.RowHeadersVisible = false;
            this.dataGirdView1.RowTemplate.Height = 40;
            this.dataGirdView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGirdView1.Size = new System.Drawing.Size(625, 319);
            this.dataGirdView1.TabIndex = 9;
            this.dataGirdView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dataGirdView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirdView1_CellContentClick);
            // 
            // Xem
            // 
            this.Xem.HeaderText = "Xem";
            this.Xem.Image = global::Smartphone_Management.Properties.Resources.icon_eye2;
            this.Xem.Name = "Xem";
            this.Xem.ReadOnly = true;
            this.Xem.Width = 47;
            // 
            // In
            // 
            this.In.HeaderText = "In";
            this.In.Image = global::Smartphone_Management.Properties.Resources.Printer_icon;
            this.In.Name = "In";
            this.In.ReadOnly = true;
            this.In.Width = 28;
            // 
            // QuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 465);
            this.Controls.Add(this.dataGirdView1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnXuatEcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyDonHang";
            this.Text = "QuanLyDonHang";
            this.Load += new System.EventHandler(this.QuanLyDonHang_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnxem;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXuatEcel;
        private Bunifu.UI.WinForms.BunifuTextBox txtTimKiem;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGirdView1;
        private System.Windows.Forms.DataGridViewImageColumn Xem;
        private System.Windows.Forms.DataGridViewImageColumn In;
    }
}