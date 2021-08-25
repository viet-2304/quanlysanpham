using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
    public class DiaChi
    {
        [Key]
        public string MaTinhTP { get; set; }

        public string Name_TinhTP { get; set; }     

        public ICollection<NhaCungCap> NCC { get; set; }


        public DiaChi()
        {
            NCC = new HashSet<NhaCungCap>();
        }
    }
}
