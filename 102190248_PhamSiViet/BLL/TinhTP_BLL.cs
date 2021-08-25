using _102190248_PhamSiViet.DAL;
using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.BLL
{
    class TinhTP_BLL
    {
        private static TinhTP_BLL _Instance;
        public static TinhTP_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new TinhTP_BLL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public TinhTP_BLL()
        {

        }
        public List<DiaChi> getALLTP()
        {
            return TinhTP_DAL.Instance.getALLTP();
        }
        public string getNameTP(string ma)
        {
            DiaChi n = TinhTP_DAL.Instance.getdiachi_byMaNCC(ma);
            return n.Name_TinhTP;

        }

        public string getMaTP_ByMaNCC(string ma)
        {
            DiaChi n = TinhTP_DAL.Instance.getdiachi_byMaNCC(ma);
            return n.MaTinhTP;
        }
    }
}
