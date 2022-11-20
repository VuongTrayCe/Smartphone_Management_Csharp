namespace Smartphone_Management.GUI.DonHang
{
    partial class FormBaiTap
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.smartphonemanagementDataSet = new Smartphone_Management.smartphonemanagementDataSet();
            this.smartphonemanagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlybanhangDataSet = new Smartphone_Management.quanlybanhangDataSet();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vattuTableAdapter = new Smartphone_Management.quanlybanhangDataSetTableAdapters.vattuTableAdapter();
            this.maVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVTuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phanTramDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartphonemanagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartphonemanagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Truy Van";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVTuDataGridViewTextBoxColumn,
            this.tenVTuDataGridViewTextBoxColumn,
            this.dvTinhDataGridViewTextBoxColumn,
            this.phanTramDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vattuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(368, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(373, 246);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 95);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "DS vật tư";
            // 
            // smartphonemanagementDataSet
            // 
            this.smartphonemanagementDataSet.DataSetName = "smartphonemanagementDataSet";
            this.smartphonemanagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // smartphonemanagementDataSetBindingSource
            // 
            this.smartphonemanagementDataSetBindingSource.DataSource = this.smartphonemanagementDataSet;
            this.smartphonemanagementDataSetBindingSource.Position = 0;
            // 
            // quanlybanhangDataSet
            // 
            this.quanlybanhangDataSet.DataSetName = "quanlybanhangDataSet";
            this.quanlybanhangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "vattu";
            this.vattuBindingSource.DataSource = this.quanlybanhangDataSet;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // maVTuDataGridViewTextBoxColumn
            // 
            this.maVTuDataGridViewTextBoxColumn.DataPropertyName = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.HeaderText = "MaVTu";
            this.maVTuDataGridViewTextBoxColumn.Name = "maVTuDataGridViewTextBoxColumn";
            this.maVTuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenVTuDataGridViewTextBoxColumn
            // 
            this.tenVTuDataGridViewTextBoxColumn.DataPropertyName = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.HeaderText = "TenVTu";
            this.tenVTuDataGridViewTextBoxColumn.Name = "tenVTuDataGridViewTextBoxColumn";
            this.tenVTuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dvTinhDataGridViewTextBoxColumn
            // 
            this.dvTinhDataGridViewTextBoxColumn.DataPropertyName = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.HeaderText = "DvTinh";
            this.dvTinhDataGridViewTextBoxColumn.Name = "dvTinhDataGridViewTextBoxColumn";
            this.dvTinhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phanTramDataGridViewTextBoxColumn
            // 
            this.phanTramDataGridViewTextBoxColumn.DataPropertyName = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.HeaderText = "PhanTram";
            this.phanTramDataGridViewTextBoxColumn.Name = "phanTramDataGridViewTextBoxColumn";
            this.phanTramDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormBaiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormBaiTap";
            this.Text = "FormBaiTap";
            this.Load += new System.EventHandler(this.FormBaiTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartphonemanagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartphonemanagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlybanhangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource smartphonemanagementDataSetBindingSource;
        private smartphonemanagementDataSet smartphonemanagementDataSet;
        private quanlybanhangDataSet quanlybanhangDataSet;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private quanlybanhangDataSetTableAdapters.vattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVTuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phanTramDataGridViewTextBoxColumn;
    }
}