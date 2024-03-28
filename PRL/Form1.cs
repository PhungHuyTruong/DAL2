using BUS2.Services;
using DAL2.DomainClass;
using System.Data;

namespace PRL
{
    public partial class Form1 : Form
    {
        NhanVienServices ser;
        public Form1()
        {
            InitializeComponent();
            ser = new NhanVienServices();
            LoadGird();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string id = "NV03";
            MessageBox.Show(ser.XoaNhanVien(id));
            LoadGird();
        }
        public void LoadGird()
        {
            dtg_View.ColumnCount = 5;
            dtg_View.Columns[0].Name = "Mã Nv";
            dtg_View.Columns[1].Name = "Họ Tên";
            dtg_View.Columns[2].Name = "Ngày Sinh";
            dtg_View.Columns[3].Name = "Gioi tinh";
            dtg_View.Columns[4].Name = "Dia chi";
            //nếu có load lại trang thì không bị gấp đôi dữ liệu
            dtg_View.Rows.Clear();
            //
            foreach (var nhanVien in ser.GetNhanViens())
            {
                dtg_View.Rows.Add(nhanVien.MaNv,
                                 nhanVien.HoTen,
                                 nhanVien.NgaySinh,
                                 nhanVien.GioiTinh,
                                 nhanVien.Diachi);
            }

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //tao nhan vien moi
            NhanVien nv = new NhanVien();
            //gan gia tri tu man hinh vao cac thuoc tinh cua nhan vien
            nv.MaNv = txt_manv.Text;
            nv.HoTen = txt_hoten.Text;
            nv.NgaySinh = DateOnly.Parse(txt_ngaysinh.Text);
            if(rbtn_nam.Checked==true)
            {
                nv.GioiTinh = "Nam";
            }
            else
            {
                nv.GioiTinh = "Nu";
            }
            nv.Diachi = cmbx_diachi.Text;
            MessageBox.Show(ser.ThemNhanVien(nv));
            LoadGird();
        }
    }
}
