using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
   public  class NhaCungCap
    {
        [Key]
        public int MaNhaCungCap { get; set; }

        public string Name_NhaCC { get; set; }

        public  string MaTinhTP { get; set; }
        [ForeignKey("MaTinhTP")]

        public virtual DiaChi diachi { get; set; }

        public ICollection<SanPham> SP { get; set; }


        public NhaCungCap()
        {
            SP = new HashSet<SanPham>();
        }
    }
}
