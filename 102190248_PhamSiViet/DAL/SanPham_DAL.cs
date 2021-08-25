using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DAL
{
    class SanPham_DAL
    {
        private static SanPham_DAL _Instance;
        public static SanPham_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPham_DAL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public SanPham_DAL()
        {

        }
        public List<SanPham> Show_sp(int mancc, string search)
        {
            List<SanPham> listshow = new List<SanPham>();
            using (QLSP db = new QLSP())
            {

                if (search == "" || search == null)
                {
                    if (mancc == 0)
                    {
                        listshow = db.SP.ToList();
                    }
                    else
                    {
                        listshow = db.SP.Where(p => p.MaNhaCungCap == mancc).ToList();
                    }
                }
                else
                {
                    if (mancc == 0)
                    {
                        listshow = db.SP.Where(p => p.NameSP.Contains(search)).ToList();
                    }
                    else
                    {
                        listshow = db.SP.Where(p => p.NameSP.Contains(search) && p.MaNhaCungCap == mancc).ToList();
                    }
                }
                return listshow;
            }
        }


        /*public List<SanPham> Show_sp(int mancc, string search)
        {
            List<SP_Show> listshow = new List<SP_Show>();
            using (QLSP db = new QLSP())
            {
               
                 if (search == "" || search == null)
                 {
                     if (mancc == 0)
                     {
                         listshow= Convert_SPShow(db.SP.ToList());
                     }
                     else
                     {
                       listshow= Convert_SPShow(db.SP.Where(p => p.MaNhaCungCap == mancc).ToList());
                     }
                 }
                 else
                 {
                     if (mancc == 0)
                     {
                        listshow = Convert_SPShow(db.SP.Where(p => p.NameSP.Contains(search)).ToList());
                     }
                     else
                     {
                        listshow = Convert_SPShow(db.SP.Where(p => p.NameSP.Contains(search) && p.MaNhaCungCap == mancc).ToList());
                     }
                 }
                return listshow;
            }
        }*/
        public void addsp(SanPham sp)
        {
            using(QLSP db= new QLSP()){
                db.SP.Add(sp);
                db.SaveChanges();
            }
        }
        public void deleteSP(List<string> ma)
        {
            using (QLSP db = new QLSP())
            {

                db.SP.RemoveRange(listsp(ma));
                
                db.SaveChanges();
            }
        } 
        private List<SanPham> listsp(List<string> ma)
        {
            List<SanPham> listSp = new List<SanPham>();
            foreach(var s in ma)
            {
                listSp.Add(FindSP(s));
            }
            return listSp;
        }

        public void EditSPLDAL(SanPham sp)
        {
            using (QLSP db = new QLSP())
            {
                List<SanPham> s = db.SP.ToList();
                foreach (var s1 in s)
                {
                    if (s1.MSP == sp.MSP)
                    {
                        s1.NameSP = sp.NameSP;
                        s1.MaNhaCungCap = sp.MaNhaCungCap;
                        s1.NgayNhap = sp.NgayNhap;
                        s1.Gia = sp.Gia;
                        s1.SoLuongSP = sp.SoLuongSP;
                        db.SaveChanges();
                    }

                }

            }

        }
        public SanPham FindSP(string MSP)
        {
            using (QLSP db = new QLSP())
            {

                return db.SP.Find(MSP);
            }
        }
    }
}
