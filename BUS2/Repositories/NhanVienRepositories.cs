using DAL2.Context;
using DAL2.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS2.Repositories
{
    internal class NhanVienRepositories
    {
        DBContext context = new DBContext();
        public NhanVienRepositories()
        {
            context = new DBContext();
        }
        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }

        public bool AddObj(NhanVien nhanVien)
        {
            if(nhanVien == null)
            {
                return false;
            }
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
            return true;
        }
        public bool UpdateObj(NhanVien nhanVien)
        {
            if (nhanVien == null)
            {
                return false;
            }
            context.NhanViens.Update(nhanVien);
            context.SaveChanges();
            return true;
        }
        public bool DeleteObj(NhanVien nhanVien)
        {
            if (nhanVien == null)
            {
                return false;
            }
            context.NhanViens.Remove(nhanVien);
            context.SaveChanges();
            return true;
        }
    }
}
