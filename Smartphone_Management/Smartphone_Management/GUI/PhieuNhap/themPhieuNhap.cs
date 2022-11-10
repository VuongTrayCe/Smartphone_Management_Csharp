using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using System.Data.SqlClient;

namespace Smartphone_Management.GUI
{
    public partial class themPhieuNhap : Form
    {
        private MySqlConnection sqlNhap;
        string nhapStr = "server=localhost;user=root;database=phoneSale;port=3306;password=dvsaigonese";
        public themPhieuNhap()
        {
            
            this.sqlNhap = new MySqlConnection(nhapStr);

            this.Load += new EventHandler(Form1_Load);
        }

        private void thongTinPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            InitializeComponent();
            SetupDataGridView();
            SetupDateTime();
            getComboBoxData();
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SetupDateTime()
        {
            var today = DateTime.Today.ToString("dd/MM/yyyy");
            ngayNhapTxt.Text = today;
        }

        private void SetupDataGridView()
        {
            dataGridView1.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView1.ColumnCount = 5;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns[0].Name = "Mã Phiếu Nhập";
            dataGridView1.Columns[1].Name = "Mã Nhân Viên";
            dataGridView1.Columns[2].Name = "Số Lượng";
            dataGridView1.Columns[3].Name = "Tổng Tiền";
            dataGridView1.Columns[4].Name = "Trạng Thái";

        }

        private void thongTinPhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void addRowbtn_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Add();
        }

        private void deleteRowBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 &&
                this.dataGridView1.SelectedRows[0].Index !=
                this.dataGridView1.Rows.Count - 1)
            {
                this.dataGridView1.Rows.RemoveAt(
                    this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void getComboBoxData()
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("select Tenncc, Mancc, DiaChi from nhacungcap", sqlNhap);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "TenNcc");
                comboBox1.DisplayMember = "Tenncc";
                comboBox1.ValueMember = "Mancc";
                comboBox1.DataSource = dataSet.Tables["TenNcc"];
            }
            catch
            {
                MessageBox.Show("Chọn nhà cung cấp!");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlNhap.Open();
            try
            {
                //for (int i = 0; i < dataGridView1.Rows.Count; i++)
                //{
                //    for (int j = 0; j < dataGridView1.Rows[j].Cells.Count; j++)
                //    {
                //        string sqlcode = "INSERT INTO `phieunhap` VALUES (" + dataGridView1.Rows[i].Cells[j].Value + ", " + dataGridView1.Rows[i].Cells[j].Value + ", " + int.Parse(comboBox1.SelectedValue.ToString()) + ", " + dataGridView1.Rows[i].Cells[j].Value + ", '" + ngayNhapTxt.Text + "', " + dataGridView1.Rows[i].Cells[j].Value + ", '" + dataGridView1.Rows[i].Cells[j].Value + "');";
                //        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlcode, sqlNhap);
                //        DataSet dataSet = new DataSet();
                //        dataAdapter.Fill(dataSet);

                //    }
                //}
                MySqlCommand command;

                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    command = new MySqlCommand("INSERT INTO phieunhap VALUES(@Maphieunhap,@Manv,@Mancc,@SoLuong,@NgayNhap,@TongTien,@Trangthai)", sqlNhap);

                    command.Parameters.Add("@Maphieunhap", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    command.Parameters.Add("@Manv", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    command.Parameters.Add("@Mancc", MySqlDbType.Int32).Value = int.Parse(comboBox1.SelectedValue.ToString());
                    command.Parameters.Add("@SoLuong", MySqlDbType.Int32).Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    command.Parameters.Add("@NgayNhap", MySqlDbType.VarChar).Value = ngayNhapTxt.Text;
                    command.Parameters.Add("@TongTien", MySqlDbType.Double).Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    command.Parameters.Add("@Trangthai", MySqlDbType.VarChar).Value = dataGridView1.Rows[i].Cells[4].Value.ToString();


                    command.ExecuteNonQuery();

                }
                //if (dataGridView1.Rows.Count > 1)
                //{
                //    do
                //    {
                //        dataGridView1.Rows.RemoveAt(0);
                //    }
                //    while (dataGridView1.Rows.Count > 0);
                //}
                //if (dataGridView1.Rows.Count == 0)
                //{
                //    MessageBox.Show("Thêm phiếu nhập thành công!");
                //    return;
                //}
                dataGridView1.Rows.Clear();
                MessageBox.Show("Thêm phiếu nhập thành công!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x + "Vui lòng nhập trước khi thêm, hoặc nếu đã nhập, có thể mã phiếu nhập, mã nhân viên hay mã nhà cung cấp bị trùng, vui lòng nhập lại!");
            }
            sqlNhap.Close();
        }
    }
}
