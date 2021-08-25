using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _102190248_PhamSiViet.DTO
{
    class CreateDB: CreateDatabaseIfNotExists<QLSP>
    {
        protected override void Seed(QLSP context)
        {
            context.DC.AddRange(new DiaChi[]
            {
                new DiaChi{ MaTinhTP="1", Name_TinhTP="Binh Dinh"},
                new DiaChi{ MaTinhTP="2", Name_TinhTP="Da Nang"},
                new DiaChi{ MaTinhTP="3", Name_TinhTP="TP Ho Chi Minh"}
            });
            context.SP.AddRange(new SanPham[]
            {   
                new SanPham{ MSP="1", NameSP="Quan Ao", Gia=100000, MaNhaCungCap=1, NgayNhap=DateTime.Now, SoLuongSP=100  },

                new SanPham{ MSP="2", NameSP="Sach vo", Gia=50000, MaNhaCungCap=2, NgayNhap=DateTime.Now, SoLuongSP=500  },
                new SanPham{ MSP="3", NameSP="xe", Gia=60000000, MaNhaCungCap=3, NgayNhap=DateTime.Now, SoLuongSP=900  },
            }); context.NCC.AddRange(new NhaCungCap[]
             {
                new NhaCungCap{MaNhaCungCap=1, Name_NhaCC="shoppe", MaTinhTP="1" },
                new NhaCungCap{MaNhaCungCap=2, Name_NhaCC="fahasa", MaTinhTP="2" },
                new NhaCungCap{MaNhaCungCap=3, Name_NhaCC="honda", MaTinhTP="3" },
             });
        }
    }
}
