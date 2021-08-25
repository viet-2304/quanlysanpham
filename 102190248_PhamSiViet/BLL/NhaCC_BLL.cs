using _102190248_PhamSiViet.DAL;
using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.BLL
{
    class NhaCC_BLL
    {
        private static NhaCC_BLL _Instance;
        public static NhaCC_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhaCC_BLL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public NhaCC_BLL()
        {

        }
        public List<NhaCungCap> getALLNCC()
        {
            return NhaCC_DAL.Instance.getALLNCC();
        }
        public string getNameNCC(int ma)
        {
            NhaCungCap n = NhaCC_DAL.Instance.getNCC(ma);
            return n.Name_NhaCC;
        }
        public List<NhaCungCap> getlistNCC(string matinh) // lấy list nhà cung cấp dựa vào mã tỉnh
        {
            return NhaCC_DAL.Instance.getlistNCC(matinh);
        }
    }
}
