namespace Smartphone_Management.GUI.ThongKe
{
    partial class ThongKeBaoCao_NhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKeBaoCao_NhapHang));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbLoai = new Bunifu.UI.WinForms.BunifuDropdown();
            this.dataGirdView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnXuatExcel = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXuatExcel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(260, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Phiếu Nhập Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.cbbLoai);
            this.panel2.Controls.Add(this.dataGirdView1);
            this.panel2.Controls.Add(this.dateEnd);
            this.panel2.Controls.Add(this.dateStart);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 210);
            this.panel2.TabIndex = 2;
            // 
            // cbbLoai
            // 
            this.cbbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoai.BackgroundColor = System.Drawing.Color.White;
            this.cbbLoai.BorderColor = System.Drawing.Color.Silver;
            this.cbbLoai.BorderRadius = 1;
            this.cbbLoai.Color = System.Drawing.Color.Silver;
            this.cbbLoai.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbbLoai.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbLoai.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbbLoai.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbbLoai.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbbLoai.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoai.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoai.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbLoai.FillDropDown = true;
            this.cbbLoai.FillIndicator = false;
            this.cbbLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbbLoai.ForeColor = System.Drawing.Color.Black;
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Icon = null;
            this.cbbLoai.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbLoai.IndicatorColor = System.Drawing.Color.Gray;
            this.cbbLoai.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbbLoai.ItemBackColor = System.Drawing.Color.White;
            this.cbbLoai.ItemBorderColor = System.Drawing.Color.White;
            this.cbbLoai.ItemForeColor = System.Drawing.Color.Black;
            this.cbbLoai.ItemHeight = 18;
            this.cbbLoai.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbbLoai.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbbLoai.Items.AddRange(new object[] {
            "Hàng Hóa",
            "Nhà Cung Cấp",
            "Ngày Nhập"});
            this.cbbLoai.ItemTopMargin = 3;
            this.cbbLoai.Location = new System.Drawing.Point(66, 3);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(140, 24);
            this.cbbLoai.TabIndex = 4;
            this.cbbLoai.Text = null;
            this.cbbLoai.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbbLoai.TextLeftMargin = 5;
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged_1);
            // 
            // dataGirdView1
            // 
            this.dataGirdView1.AllowCustomTheming = false;
            this.dataGirdView1.AllowUserToAddRows = false;
            this.dataGirdView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGirdView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGirdView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGirdView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGirdView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGirdView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGirdView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGirdView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.Column1});
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
            this.dataGirdView1.Location = new System.Drawing.Point(9, 33);
            this.dataGirdView1.Name = "dataGirdView1";
            this.dataGirdView1.ReadOnly = true;
            this.dataGirdView1.RowHeadersVisible = false;
            this.dataGirdView1.RowTemplate.Height = 40;
            this.dataGirdView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGirdView1.Size = new System.Drawing.Size(822, 174);
            this.dataGirdView1.TabIndex = 3;
            this.dataGirdView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.DarkSlateGray;
            this.dataGirdView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGirdView1_CellContentClick);
            // 
            // dateEnd
            // 
            this.dateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(592, 4);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(159, 20);
            this.dateEnd.TabIndex = 2;
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(292, 3);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(157, 20);
            this.dateStart.TabIndex = 2;
            this.dateStart.Value = new System.DateTime(2010, 2, 2, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(486, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Đến Ngày";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(212, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Từ Ngày";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(840, 159);
            this.panel3.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(840, 159);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Xem";
            this.dataGridViewImageColumn1.Image = global::Smartphone_Management.Properties.Resources.icon_eye2;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 48;
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
            this.btnXuatExcel.BackColor1 = System.Drawing.Color.Black;
            this.btnXuatExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.BackgroundImage")));
            this.btnXuatExcel.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnXuatExcel.ButtonText = "Xuất Excel";
            this.btnXuatExcel.ButtonTextMarginLeft = 0;
            this.btnXuatExcel.ColorContrastOnClick = 45;
            this.btnXuatExcel.ColorContrastOnHover = 45;
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnXuatExcel.CustomizableEdges = borderEdges1;
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
            this.btnXuatExcel.IdleFillColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IdleIconLeftImage = null;
            this.btnXuatExcel.IdleIconRightImage = null;
            this.btnXuatExcel.IndicateFocus = false;
            this.btnXuatExcel.Location = new System.Drawing.Point(727, 6);
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
            this.btnXuatExcel.OnIdleState.FillColor = System.Drawing.Color.Black;
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
            this.btnXuatExcel.Size = new System.Drawing.Size(91, 34);
            this.btnXuatExcel.TabIndex = 1;
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuatExcel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXuatExcel.TextMarginLeft = 0;
            this.btnXuatExcel.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnXuatExcel.UseDefaultRadiusAndThickness = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Xem";
            this.Column1.Image = global::Smartphone_Management.Properties.Resources.icon_eye2;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 48;
            // 
            // ThongKeBaoCao_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongKeBaoCao_NhapHang";
            this.Text = "ThongKeNhapHang";
            this.Load += new System.EventHandler(this.ThongKeNhapHang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGirdView1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGirdView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDropdown cbbLoai;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnXuatExcel;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}