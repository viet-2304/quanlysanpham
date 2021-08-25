using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
    class SP_Show
    {
        public string MSP { get; set; }

        public string NameSP { get; set; }

        public float Gia { get; set; }

        public DateTime NgayNhap { get; set; }

        public bool TinhTrang { get; set; }

        public string NhaCungCap { get; set; }

        public string TinhTP { get; set; }

        public static bool Compare_NameSP(Object o1, Object o2)
        {
            if (String.Compare(((SP_Show)o1).NameSP, ((SP_Show)o2).NameSP) >0)
                return true;
            else return false;
        }
        public static bool Compare_GiaSP(Object o1, Object o2)
        {
            if (((SP_Show)o1).Gia> ((SP_Show)o2).Gia)
                return true;
            else return false;
        }
        public static bool Compare_Ngay(Object o1, Object o2)
        {
            if (DateTime.Compare(((SP_Show)o1).NgayNhap, ((SP_Show)o2).NgayNhap) > 0)
                return true;
            else return false;
        }
        public static bool Compare_TinhTranng(Object o1, Object o2)
        {
            
            if (Convert.ToInt32( ((SP_Show)o1).TinhTrang) > Convert.ToInt32(((SP_Show)o2).TinhTrang))
                return true;
            else return false;
        }
        public static bool Compare_NhaCC(Object o1, Object o2)
        {
            if (String.Compare(((SP_Show)o1).NhaCungCap, ((SP_Show)o2).NhaCungCap) > 0)
                return true;
            else return false;
        }
        public static bool Compare_ThanhPho(Object o1, Object o2)
        {
            if (String.Compare(((SP_Show)o1).TinhTP, ((SP_Show)o2).TinhTP) > 0)
                return true;
            else return false;
        }
    }
}
