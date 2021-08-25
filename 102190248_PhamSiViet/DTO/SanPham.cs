using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
    public class SanPham
    {[Key]
        public string MSP { get; set; }

        public string NameSP { get; set; }

        public float Gia { get; set; }

        public DateTime NgayNhap { get; set; }

        public int SoLuongSP { get; set; }

        public int MaNhaCungCap { get; set; }

        [ForeignKey("MaNhaCungCap")]

        public virtual NhaCungCap NCC { get; set; }
    }
}
