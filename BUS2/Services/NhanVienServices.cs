using BUS2.Repositories;
using DAL2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS2.Services
{
    public class NhanVienServices
    {
        NhanVienRepositories repos;
        public NhanVienServices()
        {
            repos = new NhanVienRepositories();
        }
        public List<NhanVien> GetNhanViens()
        {
            return repos.GetAll();
        }
        public string ThemNhanVien(NhanVien nhanVien)
        {
            if (repos.AddObj(nhanVien))
            {
                return "Them thanh cong";
            }
            else
            {
                return "Them that bai";
            }
        }
        public string SuaNhanVien(NhanVien nhanVien)
        {
            NhanVien clone = new NhanVien();
            clone.MaNv = nhanVien.MaNv;
            clone.HoTen = nhanVien.HoTen;
            clone.NgaySinh = nhanVien.NgaySinh;
            clone.Diachi = nhanVien.Diachi;
            clone.GioiTinh = nhanVien.GioiTinh;
            if(repos.UpdateObj(nhanVien))
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }
        public string XoaNhanVien(string id)
        {
            NhanVien clone = repos.GetAll().Find(x => x.MaNv == id);
            if (repos.DeleteObj(clone))
            {
                return "Xoa thanh cong";
            }
            else
            {
                return "Xua that bai";
            }
        }
    }
}
