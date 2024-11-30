using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CuaHangAnPhuoc.frmNhanVien
{
    public partial class frmNVMain : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        List<loaisanpham> lstLoaiSanPham = new List<loaisanpham>();
        List<sanpham> lstSPHD = new List<sanpham>();
        List<sanpham> lstSPHD_slg = new List<sanpham>();

        public frmNVMain()
        {
            InitializeComponent();
        }

        private void frmNVMain_Load(object sender, EventArgs e)
        {
            loadform();
        }
        void loadform()
        {
            BLLloaisanpham bllloaisp = new BLLloaisanpham(connectionString);
            DataTable dtloaisp = bllloaisp.getAll();
            foreach (DataRow row in dtloaisp.Rows)
            {
                loaisanpham l = new loaisanpham
                {
                    Id = Convert.ToInt32(row["id"]),
                    Maloai = row["MaLoai"].ToString(),
                    Tenloai = row["TenLoai"].ToString(),
                    Danhmucsanpham = row["DanhMucSanPham"].ToString()
                };
                lstLoaiSanPham.Add(l);
            }
            lstLoaiSanPham.Sort((e1, e2) => e1.Id.CompareTo(e2.Id));

            lvDanhMucSanPham.View = View.Details;
            lvDanhMucSanPham.Columns.Add("Chọn loại: ", -2, HorizontalAlignment.Left);

            foreach (var loai in lstLoaiSanPham)
            {
                ListViewItem item = new ListViewItem(loai.Tenloai);
                item.Tag = loai.Maloai;
                lvDanhMucSanPham.Items.Add(item);
            }
            lvDanhMucSanPham.ItemActivate += ListView1_ItemActivate;

            BLLsanpham bllsp = new BLLsanpham(connectionString);
            DataTable dt = bllsp.getDayDu();
            loadDGVSP(dt);
            loadDGVSP_HD();
        }
        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            // Lấy item được chọn
            ListViewItem selectedItem = lvDanhMucSanPham.SelectedItems[0];

            // Lấy giá trị ID từ Tag của ListViewItem
            string maloai = selectedItem.Tag.ToString();

            BLLloaisanpham bllloai = new BLLloaisanpham(connectionString);
            List<string> dsloai = bllloai.GetLoaiLienQuan(maloai);
            BLLsanpham bllsanpham = new BLLsanpham(connectionString);
            DataTable dt = bllsanpham.GetProductsByLoai(dsloai);
            loadDGVSP(dt);
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenSanPham.Text ="Sản phẩm: "+ dgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtMaSanPham.Text ="Mã: "+ dgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTonKho.Text ="Tồn kho: "+ dgvSanPham.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtGiaBan.Text ="Giá: "+ dgvSanPham.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtID.Text = "ID: " + dgvSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
        void loadDGVSP(DataTable dt)
        {
            dgvSanPham.DataSource = dt;
            dgvSanPham.Columns["MaSanPham"].Frozen = true;
            if (dt.Rows.Count > 0)
            {
                txtTenSanPham.Text = "Sản phẩm: " + dgvSanPham.Rows[0].Cells[2].Value.ToString();
                txtMaSanPham.Text = "Mã: " + dgvSanPham.Rows[0].Cells[1].Value.ToString();
                txtTonKho.Text = "Tồn kho: " + dgvSanPham.Rows[0].Cells[4].Value.ToString();
                txtGiaBan.Text = "Giá: " + dgvSanPham.Rows[0].Cells[5].Value.ToString();
                txtID.Text = "ID: " + dgvSanPham.Rows[0].Cells[0].Value.ToString();
            }
        }
        void loadDGVSP_HD()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Mã", typeof(string));
            dt.Columns.Add("Tên", typeof(string));
            dt.Columns.Add("Giá", typeof(string));
            dt.Columns.Add("Số lượng", typeof(string));

            // Duyệt qua List<Product> và thêm các dòng vào DataTable
            foreach (sanpham product in lstSPHD)
            {
                foreach(sanpham spsl in lstSPHD_slg)
                {
                    if (product.Id == spsl.Id)
                    {
                        dt.Rows.Add(product.Id, product.Masanpham, product.Tensanpham, product.Giaban, spsl.Soluong);
                    }
                }
                
            }
            dgvSanPhamHoaDon.DataSource = dt;
            dgvSanPhamHoaDon.Columns["id"].Frozen = true;
            if (lstSPHD.Count > 0)
            {
                txtSanPhamHoaDon.Text = dgvSanPhamHoaDon.Rows[0].Cells[1].Value.ToString() +" - "+ dgvSanPhamHoaDon.Rows[0].Cells[2].Value.ToString();
                txtSoLuongSPHD.Text = dgvSanPhamHoaDon.Rows[0].Cells[4].Value.ToString();
            }else
            {
                txtSanPhamHoaDon.Text = "";
                txtSoLuongSPHD.Text = "";
            }
            tinhtien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int sltonkho = Convert.ToInt32(txtTonKho.Text.Substring(8));
            if (sltonkho <= 0)
            {
                MessageBox.Show("Số lượng tồn kho không đủ.");
                return;
            }
            foreach (sanpham sp in lstSPHD_slg)
            {
                if(sp.Id == Convert.ToInt32(txtID.Text.Substring(4)))
                {
                    if (sp.Soluong == sltonkho)
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ.");
                        return;
                    }
                    sp.Soluong++;
                    loadDGVSP_HD();
                    return;
                }
            }
            sanpham sphd = new sanpham();
            sphd.Id = Convert.ToInt32(txtID.Text.Substring(4));
            sphd.Masanpham = txtMaSanPham.Text.Substring(4);
            sphd.Tensanpham = txtTenSanPham.Text.Substring(10);
            sphd.Giaban = Convert.ToInt32(txtGiaBan.Text.Substring(5));
            sphd.Soluong = Convert.ToInt32(txtTonKho.Text.Substring(8));
            lstSPHD.Add(sphd);
            sanpham spsl = new sanpham();
            spsl.Id = sphd.Id;
            spsl.Soluong = 1;
            lstSPHD_slg.Add(spsl);
            loadDGVSP_HD();
        }

        private void dgvSanPhamHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtSanPhamHoaDon.Text = dgvSanPhamHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString() + " - " + dgvSanPhamHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuongSPHD.Text = dgvSanPhamHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnGiamSPHD_Click(object sender, EventArgs e)
        {
            string[] parts = txtSanPhamHoaDon.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            string Masp = parts[0];

            int sl = Convert.ToInt32(txtSoLuongSPHD.Text);
            sl--;
            if (sl <= 0)
            {
                foreach (sanpham sp in lstSPHD)
                {
                    if (sp.Masanpham.Equals(Masp))
                    {
                        lstSPHD.Remove(sp);
                        foreach(sanpham spsl in lstSPHD_slg)
                        {
                            if (sp.Id == spsl.Id)
                            {
                                lstSPHD_slg.Remove(spsl);
                                break;
                            }
                        }
                        
                        loadDGVSP_HD();
                        return;
                    }
                }
            } else
            {
                foreach (sanpham sp in lstSPHD)
                {
                    if (sp.Masanpham.Equals(Masp))
                    {
                        foreach(sanpham spsl in lstSPHD_slg)
                        {
                            if (sp.Id.Equals(spsl.Id))
                            {
                                spsl.Soluong = sl;
                                break;
                            }

                        }
                        
                        lstSPHD.Remove(sp);
                        lstSPHD.Insert(0, sp);
                        loadDGVSP_HD();
                        return;
                    }
                }
            }
        }

        private void btnTangSPHD_Click(object sender, EventArgs e)
        {
            string[] parts = txtSanPhamHoaDon.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            string Masp = parts[0];
            int sl = Convert.ToInt32(txtSoLuongSPHD.Text);
            foreach (sanpham sp in lstSPHD)
            {
                if (sp.Masanpham.Equals(Masp))
                {
                    if (sp.Soluong == sl)
                    {
                        MessageBox.Show("Số lượng tồn kho không đủ.");
                        return;
                    }else
                    {
                        foreach(sanpham spsl in lstSPHD_slg)
                        {
                            if (sp.Id == spsl.Id)
                            {
                                spsl.Soluong++;
                                lstSPHD.Remove(sp);
                                lstSPHD.Insert(0, sp);
                                loadDGVSP_HD();
                                return;
                            }
                        }
                    }
                }
            }

        }

        private void btnXoaSPHD_Click(object sender, EventArgs e)
        {
            string[] parts = txtSanPhamHoaDon.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            string Masp = parts[0];

            foreach (sanpham sp in lstSPHD)
            {
                if (sp.Masanpham.Equals(Masp))
                {
                    lstSPHD.Remove(sp);
                    foreach (sanpham spsl in lstSPHD_slg)
                    {
                        if (sp.Id == spsl.Id)
                        {
                            lstSPHD_slg.Remove(spsl);
                            break;
                        }
                    }

                    loadDGVSP_HD();
                    return;
                }
            }
        }
        void tinhtien()
        {
            double tien = 0;
            foreach (sanpham sp in lstSPHD)
            {
                foreach(sanpham spsl in lstSPHD_slg)
                {
                    if(sp.Id == spsl.Id)
                    {
                        tien += (sp.Giaban * spsl.Soluong);
                    }
                }
            }
            txtTongTienHD.Text = tien + " VND";
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if(lstSPHD.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm để xuất hoá đơn.");
                return;
            }
            donhang dh = new donhang();
            dh.Ngaydathang = DateTime.Now;
            dh.Ngayxacnhan = DateTime.Now;
            dh.Tongien = Convert.ToDouble(txtTongTienHD.Text.Substring(0, txtTongTienHD.Text.Length - 4));
            BLLdonhang bll = new BLLdonhang(connectionString);
            BLLchitietdonhang bllchitiet = new BLLchitietdonhang(connectionString);
            BLLsanpham bllsp = new BLLsanpham(connectionString);
            if (bll.taoDonHangDonGianKhongKhachHang(dh))
            {
                foreach(sanpham sp in lstSPHD)
                {
                    foreach (sanpham spsl in lstSPHD_slg)
                    {
                        if(sp.Id == spsl.Id)
                        {
                            chitietdonhang ctdh = new chitietdonhang();
                            ctdh.Madonhang = bll.getIdDhCuoiCung();
                            ctdh.Masanpham = sp.Masanpham;
                            ctdh.Soluong = spsl.Soluong;
                            ctdh.Dongia = sp.Giaban;
                            if (!bllchitiet.themCTDH(ctdh))
                            {
                                MessageBox.Show("Tạo đơn hàng thất bại - Lỗi thêm từng sản phẩm");
                                bll.huyDonHang(ctdh.Madonhang);
                                return;
                            } else
                            {
                                if(!bllsp.updateSoLuong(sp.Id, ctdh.Soluong))
                                {
                                    MessageBox.Show("Tạo đơn hàng thất bại - Lỗi cập nhật số lượng tồn kho");
                                    bll.huyDonHang(ctdh.Madonhang);
                                    return;
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("Xuất hoá đơn hành công");
                lstLoaiSanPham.Clear();
                lstSPHD.Clear();
                lstSPHD_slg.Clear();
                loadform();
                return;
            }else
            {
                MessageBox.Show("Tạo đơn hàng thất bại - Lỗi tạo hoá đơn");
                return;
            }

        }
    }
}
