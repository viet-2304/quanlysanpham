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
using static System.Windows.Forms.DataFormats;

namespace _102190248_PhamSiViet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            setCBB_Tinh();
            setCBB_NhaCC(0);
            setCBB_Sort();
            show(0, null);
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
                    value = Convert.ToInt32( item.MaTinhTP)
                });
            }
            CBTinh.SelectedIndex = 0;
        }

        private void setCBB_NhaCC(int  matinh)
        {

            if( matinh== 0)
            {
                List<NhaCungCap> listNCC = NhaCC_BLL.Instance.getALLNCC();
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
                List<NhaCungCap> listNCC = NhaCC_BLL.Instance.getlistNCC(matinh.ToString()); 
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
                CBNhaCC.SelectedItem = listNCC[0].MaNhaCungCap;
              
            }
            
        }
        
        private void setCBB_Sort()
        {
            List<SP_Show> list_show = SanPham_BLL.Instance.GetSP_BLL(0, null);
            if (CBSort.Items != null)
            {
                CBSort.Items.Clear();
            }
            CBSort.Items.Add(new CBBITem { text = "Tên Sản phẩm", value = 0 });
            CBSort.Items.Add(new CBBITem { text = "Giá sản phẩm", value = 1 });
            CBSort.Items.Add(new CBBITem { text = "Ngày nhập", value = 2 });
            CBSort.Items.Add(new CBBITem { text = "Tình Trạng", value = 3 });
            CBSort.Items.Add(new CBBITem { text = "Nhà cung cấp", value = 4 });
            CBSort.Items.Add(new CBBITem { text = "Tỉnh", value = 5 });
            CBSort.SelectedIndex = 0;
        }

        private void show(int mancc, string search)
        {
            using (QLSP db = new QLSP())
            {
                dataGridView1.DataSource = SanPham_BLL.Instance.GetSP_BLL(mancc, search);
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
           
            show( ((CBBITem)CBNhaCC.SelectedItem).value, TBSearch.Text);
        }

        private void BTAdd_Click(object sender, EventArgs e)
        {
            _102190248_DF f2 = new _102190248_DF("0");
            f2.d = show;
            this.Hide();
            f2.ShowDialog();
            this.Show();
            MessageBox.Show("add thành công");
           
        }

        private void TBSearch_TextChanged(object sender, EventArgs e)
        {
            show(0, TBSearch.Text);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            List<string> listmsp = new List<string>();
            if (dataGridView1.SelectedRows.Count != 0)
            {
                foreach (var row in dataGridView1.SelectedRows)
                {
                    string msp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    listmsp.Add(msp);
                }
               
                 SanPham_BLL.Instance.delesp(listmsp);
                MessageBox.Show("xóa thành công");
                show( 0,null);

            }
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
             if (dataGridView1.SelectedRows.Count == 1)
            {
                string masp = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                _102190248_DF f2 = new _102190248_DF(masp);
                f2.d = show;
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 sinh viên để sửa");
            }

        }

       /* private void CBTinh_TextChanged(object sender, EventArgs e)
        {

            setCBB_NhaCC(((CBBITem)CBTinh.SelectedItem).value);
        }*/

        private void BTSort_Click(object sender, EventArgs e)
        {
            List<SP_Show> list_spshow = SanPham_BLL.Instance.GetSP_BLL(0, null);
            int check_sort = ((CBBITem)CBSort.SelectedItem).value;
            switch (check_sort)
            {
                case 0:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_NameSP);
                    break;
                case 1:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_GiaSP);
                    break;
                case 2:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_Ngay);
                    break;
                case 3:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_TinhTranng);
                    break;
                case 4:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_NhaCC);
                    break;
                case 5:
                    SanPham_BLL.Instance.sort(list_spshow, SP_Show.Compare_ThanhPho);
                    break;
            }
            dataGridView1.DataSource = list_spshow;
        }

        private void CBTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            setCBB_NhaCC(((CBBITem)CBTinh.SelectedItem).value);
        }

       
    }
}
