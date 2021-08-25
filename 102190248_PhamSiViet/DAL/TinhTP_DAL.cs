using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DAL
{
    class TinhTP_DAL
    {
        private static TinhTP_DAL _Instance;
        public static TinhTP_DAL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TinhTP_DAL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public TinhTP_DAL()
        {

        }
        public List<DiaChi> getALLTP()
        {
            using(QLSP db= new QLSP())
            {
                return db.DC.ToList();
            }
        }
        public DiaChi getdiachi_byMaNCC(string ma)
        {
          
            using (QLSP db = new QLSP())
            {
                NhaCungCap ncc = db.NCC.Find(Convert.ToInt32( ma));
                
                return db.DC.Find(ncc.MaTinhTP);
            }
        }
    }
}
