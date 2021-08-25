using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
    class CBBITem
    {
        public int value { get; set; }

        public string text { get; set; }
        public override string ToString()
        {
            return text;
        }
    }
}
