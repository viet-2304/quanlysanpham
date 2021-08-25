using _102190248_PhamSiViet.BLL;
using _102190248_PhamSiViet.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _102190248_PhamSiViet
{
    public partial class _102190248_DF : Form
    {
        public delegate void mydel(int mancc, string search);
        public mydel d { get; set; }
        string ma;
        public _102190248_DF(string MA)
        {
            InitializeComponent();
            ma = MA;
            setCBB_NhaCC(null);
            setCBB_Tinh();
            Check();
        }
        private void Check()
        {
            if (Convert.ToInt32(ma) != 0)
            {
                TB_Ma.Enabled = false;
                SetGUI();
            }
            else
                TB_Ma.Enabled = true;
        }
        private void setCBB_Tinh()
        {
            List<DiaChi> listDC = TinhTP_BLL.Instance.getALLTP();
            if (CBTinh.Items != null)
            {
                CBTinh.Items.Clear();
            }
            CBTinh.Items.Add(new CBBITem { text = "all", value = 0 });
            foreach (var item in listDC)
            {
                CBTinh.Items.Add(new CBBITem
                {
                    text = item.Name_TinhTP,
                    value = Convert.ToInt32(item.MaTinhTP)
                });
            }
            CBTinh.SelectedIndex = 0;
        }
        private void setCBB_NhaCC(string matinh)
        {
            List<NhaCungCap> listNCC = new List<NhaCungCap>();
            if (matinh == 0.ToString())
            {
                listNCC = NhaCC_BLL.Instance.getALLNCC();
                if (CBNhaCC.Items != null)
                {
                    CBNhaCC.Items.Clear();
                }

                CBNhaCC.Items.Add(new CBBITem { text = "all", value = 0 });
                foreach (var item in listNCC)
                {
                    CBNhaCC.Items.Add(new CBBITem
                    {
                        text = item.Name_NhaCC,
                        value = item.MaNhaCungCap
                    });
                }
                CBNhaCC.SelectedIndex = 0;
            }
            else
            {
               listNCC = NhaCC_BLL.Instance.getlistNCC(matinh);

                if (CBNhaCC.Items != null)
                {
                    CBNhaCC.Items.Clear();
                }
                foreach (var item in listNCC)
                {
                    CBNhaCC.Items.Add(new CBBITem
                    {
                        text = item.Name_NhaCC,
                        value = item.MaNhaCungCap
                    });
                }

            }

        }
       private void SetGUI()
        {
            if (Convert.ToInt32(ma) != 0)
            {
                SanPham sp = SanPham_BLL.Instance.FindSP(ma);

                TB_Ma.Text = sp.MSP;
                TB_Name.Text = sp.NameSP;
                dateTimePicker1.Value = sp.NgayNhap;
                tbNumber.Text = sp.SoLuongSP.ToString();
                TB_Gia.Text = sp.Gia.ToString();
               CBNhaCC.SelectedIndex = sp.MaNhaCungCap;
                CBTinh.SelectedIndex =Convert.ToInt32( TinhTP_BLL.Instance.getMaTP_ByMaNCC(sp.MaNhaCungCap.ToString())); 

            }
        }
        private void BTCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btoke_Click(object sender, EventArgs e)
        {
            if (TB_Ma.Enabled == true)
            {
                AddSP();
            }
            else
                EditSP();
        }
        private void AddSP()
        {
            if (tbNumber.Text == "" || TB_Gia.Text == "" || TB_Ma.Text=="" || TB_Name.Text == "")
            {
                MessageBox.Show("Ban phai nhap du thong tin");
            }
            else
            {
                SanPham sp = new SanPham();
                sp.MSP = TB_Ma.Text;
                sp.NameSP = TB_Name.Text;
                sp.MaNhaCungCap = ((CBBITem)CBNhaCC.SelectedItem).value;
                sp.Gia = (float)Convert.ToInt32( TB_Gia.Text);
                sp.NgayNhap = dateTimePicker1.Value;
                sp.SoLuongSP = Convert.ToInt32(tbNumber.Text);
                
                SanPham_BLL.Instance.addSP_BLL(sp);


                this.Dispose();
                d(0, null);
            }
        }

        private void EditSP()
        {
            SanPham sp = new SanPham();
            sp.MSP = TB_Ma.Text;
            sp.NameSP = TB_Name.Text;
            sp.MaNhaCungCap = ((CBBITem)CBNhaCC.SelectedItem).value;
            sp.Gia = (float)Convert.ToInt32(TB_Gia.Text);
            sp.NgayNhap = dateTimePicker1.Value;
            sp.SoLuongSP = Convert.ToInt32(tbNumber.Text);
            SanPham_BLL.Instance.editSP(sp);
            this.Dispose();
            d(0, null);
            
        }
        private void CBTinh_TextChanged(object sender, EventArgs e)
        {
            setCBB_NhaCC(((CBBITem)CBTinh.SelectedItem).value.ToString());
        }
    }
}
