using DocumentFormat.OpenXml.Drawing.Charts;
using Smartphone_Management.BUS;
using Smartphone_Management.DAO;
using Smartphone_Management.DTO;
using Smartphone_Management.GUI.GUI_SanPham.Dialog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace Smartphone_Management.GUI.GUI_SanPham
{
    public partial class SanPham : Form
    {
        private static SanPhamBUS sanphamBUS = new SanPhamBUS();
        private static GiaSanPhamBUS giaSanPhamBUS = new GiaSanPhamBUS();
        public SanPham()
        {
            InitializeComponent();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* FORM LOAD *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void SanPham_Load(object sender, EventArgs e)
        {
            PanelLoiSanPham.Hide();
            AnhSanPham.Hide();
            AnhSanPhamPath.Hide();
            AnhSanPhamUpdate.Hide();
            showSanPham();
            DataGridViewSanPham.ClearSelection();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* CÁC HÀM HỖ TRỢ CHỨC NĂNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private string getImageStorePath ()
        {
            string startUpPath = Application.StartupPath;
            string imageStorePath = startUpPath.Remove(startUpPath.Length - 9) + @"\GUI\GUI_SanPham\HinhAnh\";
            return imageStorePath;
        }
        private string copyIntoImageStore (string sourcePath, string destinationPath)
        {
            DateTime Jan1St1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            long totalMilliseconds = (long)(DateTime.UtcNow - Jan1St1970).TotalMilliseconds;
            string[] fileSplit = destinationPath.Split('.');
            string fileFormat = "." + fileSplit[fileSplit.Length - 1];
            string newImageFile = totalMilliseconds.ToString() + fileFormat;
            File.Copy(sourcePath, getImageStorePath() + newImageFile, true);
            return newImageFile;
        }

        private void resetForm()
        {
            MaSanPham.Text = "";
            TenSanPham.Text = "";
            LoaiSanPham.Text = "";
            SoLuongSanPham.Text = "";
            MauSacSanPham.Text = "";
            NamSanXuatSanPham.Text = "";
            ThongSoSanPham.Text = "";
            MaNhaCungCapSanPham.Text = "";
            PictureBoxAnhSanPham.Image = new Bitmap(getImageStorePath() + "no_image.png");
            AnhSanPham.Text = "";
            AnhSanPhamPath.Text = "";
            MaSanPham.Focus();
        }

        private string getToday ()
        {
            string date = DateTime.Now.ToString();
            string[] dateSplit = date.Split(' ');
            string month = dateSplit[0].Split('/')[0];
            string day = dateSplit[0].Split('/')[1];
            string year = dateSplit[0].Split('/')[2];
            return year + "-" + month + "-" + day;
        }

        private void selectedRowDGV(int rowIndex)
        {
            int maSPSelectd = Int32.Parse(DataGridViewSanPham.Rows[rowIndex].Cells[0].Value.ToString());
            SanPhamDTO sanphamDTOSelected = sanphamBUS.getSanPhamByID(maSPSelectd);
            MaSanPham.Text = sanphamDTOSelected.Masp.ToString();
            TenSanPham.Text = sanphamDTOSelected.Tensp;
            LoaiSanPham.Text = sanphamDTOSelected.Loaisp;
            SoLuongSanPham.Text = sanphamDTOSelected.soluong.ToString();
            MauSacSanPham.Text = sanphamDTOSelected.MauSac;
            NamSanXuatSanPham.Text = sanphamDTOSelected.Namsx;
            ThongSoSanPham.Text = sanphamDTOSelected.ThongSo;
            MaNhaCungCapSanPham.Text = sanphamDTOSelected.Mancc.ToString();

            if (sanphamDTOSelected.Icon.Equals("") || sanphamDTOSelected.Icon == null)
            {
                PictureBoxAnhSanPham.Image = new Bitmap(getImageStorePath() + "no_image.png");
                AnhSanPhamUpdate.Text = "";
            }
            else
            {
                PictureBoxAnhSanPham.Image = new Bitmap(getImageStorePath() + sanphamDTOSelected.Icon);
                AnhSanPhamUpdate.Text = sanphamDTOSelected.Icon;
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* HIỂN THỊ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        public void showSanPham()
        {
            DataTable dataTable = new DataTable();
            dataTable = sanphamBUS.getDataTableSanPham();
            DataGridViewSanPham.DataSource = dataTable;
            DataGridViewSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            DataGridViewSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            DataGridViewSanPham.Columns[2].HeaderText = "Loại Sản Phẩm";
            DataGridViewSanPham.Columns[3].HeaderText = "Số Lượng";
            DataGridViewSanPham.Columns[4].HeaderText = "Màu Sắc";
            DataGridViewSanPham.Columns[5].HeaderText = "Năm sản xuất";
            DataGridViewSanPham.ScrollBars = ScrollBars.Vertical;
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* THÊM SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonThemSanPham_Click(object sender, EventArgs e)
        {
            if (!MaSanPham.Text.Equals(""))
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = "Vui lòng \"Xóa Trắng\" để thêm sản phẩm mới!";
            }
            else
            {
                PanelLoiSanPham.Hide();
                string errorMessage = sanphamBUS.checkInputSanPham(
                TenSanPham.Text, LoaiSanPham.Text, SoLuongSanPham.Text, MauSacSanPham.Text, NamSanXuatSanPham.Text, ThongSoSanPham.Text, MaNhaCungCapSanPham.Text
                );
                if (errorMessage.Equals(""))
                {
                    PanelLoiSanPham.Hide();
                    WarningDialog warningDialog = new WarningDialog("Bạn có muốn thêm sản phẩm này?");
                    DialogResult dialogResult = warningDialog.ShowDialog();
                    if (dialogResult == DialogResult.Cancel) { MaSanPham.Focus(); }
                    if (dialogResult == DialogResult.Yes)
                    {
                        MaSanPham.Focus();
                        /*---------------------------- Insert sản phẩm ----------------------------*/
                        SanPhamDTO sanphamDTO = new SanPhamDTO();
                        sanphamDTO.Tensp = TenSanPham.Text;
                        sanphamDTO.Loaisp = LoaiSanPham.Text;
                        sanphamDTO.soluong = Int32.Parse(SoLuongSanPham.Text);
                        sanphamDTO.MauSac = MauSacSanPham.Text;
                        sanphamDTO.Namsx = NamSanXuatSanPham.Text;
                        sanphamDTO.TrangThai = "T";
                        if (!AnhSanPhamPath.Text.Trim().Equals("") && !AnhSanPham.Text.Trim().Equals(""))
                        {
                            sanphamDTO.Icon = copyIntoImageStore(AnhSanPhamPath.Text, AnhSanPham.Text);
                        }
                        else
                        {
                            sanphamDTO.Icon = "";
                        }
                        sanphamDTO.ThongSo = ThongSoSanPham.Text;
                        sanphamDTO.Mancc = Int32.Parse(MaNhaCungCapSanPham.Text);
                        sanphamBUS.insertSanPham(sanphamDTO);
                        /*---------------------------- Insert giá sản phẩm ----------------------------*/
                        GiaSanPhamDTO giaSanPhamDTO = new GiaSanPhamDTO();
                        giaSanPhamDTO.Masp = sanphamBUS.getMaSanPhamCuoiCung();
                        giaSanPhamDTO.Gianhap = 0;
                        giaSanPhamDTO.Giaban = 0;
                        giaSanPhamDTO.Ngayupdate = getToday();
                        giaSanPhamDTO.TrangThai = "T";
                        giaSanPhamBUS.insertGiaSanPham(giaSanPhamDTO);
                        resetForm();
                        showSanPham();
                    }
                }
                else
                {
                    PanelLoiSanPham.Show();
                    LabelLoiSanPham.Text = errorMessage;
                }
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SỬA SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonSuaSanPham_Click(object sender, EventArgs e)
        {
            if(!MaSanPham.Text.Equals(""))
            {
                PanelLoiSanPham.Hide();
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn sửa sản phẩm này?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { MaSanPham.Focus(); }
                if (dialogResult == DialogResult.Yes)
                {
                    MaSanPham.Focus();
                    SanPhamDTO sanphamDTO = new SanPhamDTO();
                    sanphamDTO.Masp = Int32.Parse(MaSanPham.Text);
                    sanphamDTO.Tensp = TenSanPham.Text;
                    sanphamDTO.Loaisp = LoaiSanPham.Text;
                    sanphamDTO.soluong = Int32.Parse(SoLuongSanPham.Text);
                    sanphamDTO.MauSac = MauSacSanPham.Text;
                    sanphamDTO.Namsx = NamSanXuatSanPham.Text;
                    sanphamDTO.TrangThai = "T";
                    if (!AnhSanPhamPath.Text.Trim().Equals("") && !AnhSanPham.Text.Trim().Equals(""))
                    {
                        sanphamDTO.Icon = copyIntoImageStore(AnhSanPhamPath.Text, AnhSanPham.Text);
                    } else
                    {
                        sanphamDTO.Icon = AnhSanPhamUpdate.Text;
                    }
                    sanphamDTO.ThongSo = ThongSoSanPham.Text;
                    sanphamDTO.Mancc = Int32.Parse(MaNhaCungCapSanPham.Text);
                    sanphamBUS.updateSanPham(sanphamDTO);
                    resetForm();
                    showSanPham();
                }

            } else
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = "Vui lòng chọn sản phẩm để sửa!";
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XÓA SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonXoaSanPham_Click(object sender, EventArgs e)
        {
            if(!MaSanPham.Text.Equals(""))
            {
                PanelLoiSanPham.Hide();
                WarningDialog warningDialog = new WarningDialog("Bạn có muốn xóa sản phẩm này?");
                DialogResult dialogResult = warningDialog.ShowDialog();
                if (dialogResult == DialogResult.Cancel) { MaSanPham.Focus(); }
                if (dialogResult == DialogResult.Yes)
                {
                    MaSanPham.Focus();
                    int maSPDelete = Int32.Parse(MaSanPham.Text);
                    sanphamBUS.deleteSanPham(maSPDelete);
                    resetForm();
                    showSanPham();
                }
            } else
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = "Vui lòng chọn sản phẩm để xóa!";
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XUẤT EXCEL SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonXuatSanPham_Click(object sender, EventArgs e)
        {
            DataSet dataSet = sanphamBUS.getDataSetSanPham();
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "sanpham.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dataSet.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        for (int i = 0; i < (dataSet.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dataSet.Tables[0].Columns.Count; j++)
                            {
                                if (dataSet.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dataSet.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            wr.WriteLine();
                        }
                        wr.Close();      
                    }
                    else
                    {
                        PanelLoiSanPham.Show();
                        LabelLoiSanPham.Text = "Xuất file Excel thất bại!";
                    }
                }
            }
            catch (Exception ex)
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = "Xuất file Excel thất bại! Lỗi:" + ex.Message;
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XÓA TRẮNG FORM SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonXoaTrangSanPham_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ĐI TỚI SẢN PHẨM ĐẦU TIÊN *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonFirstSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewSanPham.ClearSelection();
            DataGridViewSanPham.Rows[0].Selected = true;
            selectedRowDGV(0);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ĐI TỚI SẢN PHẨM CUỐI CÙNG *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonLastSanPham_Click(object sender, EventArgs e)
        {
            DataGridViewSanPham.ClearSelection();
            DataGridViewSanPham.Rows[DataGridViewSanPham.Rows.Count - 1].Selected = true;
            selectedRowDGV(DataGridViewSanPham.Rows.Count - 1);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* QUAY LẠI SẢN PHẨM TRƯỚC ĐÓ *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonPrevSanPham_Click(object sender, EventArgs e)
        {
            int selectedRow;
            if (DataGridViewSanPham.SelectedRows.Count > 0)
            {
                selectedRow = DataGridViewSanPham.SelectedRows[0].Index;
            } else
            {
                selectedRow = 0;
            }
            if (selectedRow > 0)
            {
                DataGridViewSanPham.Rows[selectedRow].Selected = false;
                selectedRow = --selectedRow;
                DataGridViewSanPham.Rows[selectedRow].Selected = true;
            }
            else
            {
                DataGridViewSanPham.Rows[selectedRow].Selected = false;
                selectedRow = 0;
                DataGridViewSanPham.Rows[selectedRow].Selected = true;
            }
            selectedRowDGV(selectedRow);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* ĐI TỚI SẢN PHẨM TIẾP THEO *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonNextSanPham_Click(object sender, EventArgs e)
        {
            int selectedRow;
            if (DataGridViewSanPham.SelectedRows.Count > 0)
            {
                selectedRow = DataGridViewSanPham.SelectedRows[0].Index;
            }
            else
            {
                selectedRow = 0;
            }
            if (selectedRow < DataGridViewSanPham.Rows.Count - 1)
            {
                DataGridViewSanPham.Rows[selectedRow].Selected = false;
                selectedRow = ++selectedRow;
                DataGridViewSanPham.Rows[selectedRow].Selected = true;
            }
            else
            {
                DataGridViewSanPham.Rows[selectedRow].Selected = false;
                selectedRow = DataGridViewSanPham.Rows.Count - 1;
                DataGridViewSanPham.Rows[selectedRow].Selected = true;
            }
            selectedRowDGV(selectedRow);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* MỞ FORM CHỌN LOẠI SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonSelectLoaiSanPham_Click(object sender, EventArgs e)
        {
            using (SelectDialog selectDialog = new SelectDialog("CHỌN LOẠI SẢN PHẨM", sanphamBUS.getAllLoaiSanPham()))
            {
                if(selectDialog.ShowDialog() == DialogResult.Yes)
                {
                    LoaiSanPham.Text = selectDialog.selectedText;
                    MaSanPham.Focus();
                }
            }  
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* MỞ FORM CHỌN NHÀ CUNG CẤP *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonSelectMaNhaCungCap_Click(object sender, EventArgs e)
        {
            using (SelectDialog selectDialog = new SelectDialog("CHỌN NHÀ CUNG CẤP", sanphamBUS.getAllMaNhaCungCap()))
            {
                if (selectDialog.ShowDialog() == DialogResult.Yes)
                {
                    MaNhaCungCapSanPham.Text = selectDialog.selectedText;
                    MaSanPham.Focus();
                }
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* UPLOAD ẢNH SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void PictureBoxAnhSanPham_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif;";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PictureBoxAnhSanPham.Image = new Bitmap(openFileDialog.FileName);
                AnhSanPham.Text = openFileDialog.SafeFileName;
                AnhSanPhamPath.Text = openFileDialog.FileName;
            }
            openFileDialog.Dispose();
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* SELECTED ROW DATA GRID VIEW *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void DataGridViewSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            selectedRowDGV(rowIndex);
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* XEM ĐẦY ĐỦ BẢNG SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonXemDayDuSanPham_Click(object sender, EventArgs e)
        {
            FullDataDialog fullDataDialog = new FullDataDialog();
            DialogResult dialogResult = fullDataDialog.ShowDialog();
            if (dialogResult == DialogResult.Cancel)
            {
                MaSanPham.Focus();
            }
        }

        /*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* QUẢN LÝ GIÁ SẢN PHẨM *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*/
        private void ButtonQuanLyGia_Click(object sender, EventArgs e)
        {
            if(!MaSanPham.Text.Equals(""))
            {
                PanelLoiSanPham.Hide();
                PriceManagementDialog priceManagementDialog = new PriceManagementDialog();
                priceManagementDialog.maSPSelected = Int32.Parse(MaSanPham.Text);
                DialogResult dialogResult = priceManagementDialog.ShowDialog();
                if(dialogResult == DialogResult.Cancel)
                {
                    MaSanPham.Focus();
                }
            } else
            {
                PanelLoiSanPham.Show();
                LabelLoiSanPham.Text = "Vui lòng chọn sản phẩm để quản lý giá!";
            }
            
        }
    }
}
