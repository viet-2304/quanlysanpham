using _102190248_PhamSiViet.DAL;
using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.BLL
{
    public delegate bool Compare(object o1, object o2);
  
    class SanPham_BLL
    {
        private static SanPham_BLL _Instance;
        public static SanPham_BLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPham_BLL();
                }
                return _Instance;
            }
            set
            {

            }
        }
        public SanPham_BLL()
        {

        }

        public List<SP_Show> Convert_SPShow(List<SanPham> listsp)
        {

            List<SP_Show> list_show = new List<SP_Show>();

            foreach (var s in listsp)
            {
                SP_Show spw = new SP_Show();
                spw.MSP = s.MSP;
                spw.NameSP = s.NameSP;
                spw.NhaCungCap = NhaCC_BLL.Instance.getNameNCC(s.MaNhaCungCap);
                spw.NgayNhap = s.NgayNhap;
                spw.TinhTP = TinhTP_BLL.Instance.getNameTP(s.MaNhaCungCap.ToString());
                if (s.SoLuongSP > 0)
                {
                    spw.TinhTrang = true;
                }
                else
                    spw.TinhTrang = false;
                spw.Gia = s.Gia;
                list_show.Add(spw);
            }
            return list_show;
        }
        public List<SP_Show> GetSP_BLL( int mancc, string search)
        {
            return Convert_SPShow( SanPham_DAL.Instance.Show_sp(mancc, search));          
        }
        public void addSP_BLL(SanPham sp)
        {
            SanPham_DAL.Instance.addsp(sp);

        }
        public void delesp(List<string> ma)
        {          
                SanPham_DAL.Instance.deleteSP(ma);            
        }
        public void editSP(SanPham SP)
        {
            SanPham_DAL.Instance.EditSPLDAL(SP);
        }
        public SanPham FindSP(string MSP)
        {
            return SanPham_DAL.Instance.FindSP(MSP);
        }

        public void sort(List<SP_Show> list_spshow, Compare cmp)
        {
            for (int i = 0; i < list_spshow.Count; i++)
            {
                for (int j = i + 1; j < list_spshow.Count; j++)
                {
                    if (cmp(list_spshow[i], list_spshow[j]))
                    {
                        SP_Show sp = list_spshow[i];
                        list_spshow[i] = list_spshow[j];
                        list_spshow[j] = sp;

                    }
                }
            }
        }

    }
}
