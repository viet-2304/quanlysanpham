using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DAL
{
    class NhaCC_DAL
    {
        private static NhaCC_DAL _Instance;
        public static NhaCC_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhaCC_DAL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public NhaCC_DAL()
        {

        }
        public List<NhaCungCap> getALLNCC()
        {
            using (QLSP db = new QLSP())
            {
                return db.NCC.ToList();
            }
        }
        public NhaCungCap getNCC(int ma)
        {
            using (QLSP db = new QLSP())
            {
                return db.NCC.Find(ma);
            }
        }
        public List<NhaCungCap> getlistNCC(string matinh)
        {
            List<NhaCungCap> listnhacc = new List<NhaCungCap>();
            using(QLSP db = new QLSP())
            {
                listnhacc=db.NCC.Where(p => p.MaTinhTP == matinh).ToList();
            }
            return listnhacc;
        }
    }
}
