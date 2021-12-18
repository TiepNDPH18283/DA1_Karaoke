using _2_BUS.BUS_Service;
using _2_BUS.IBUS_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class frm_ThongKeThietBi : Form
    {
        public frm_ThongKeThietBi()
        {
            InitializeComponent();
            _ThietBi_Service = new BUS_ThietBi_Service();
            _LoaiThietBi_Service = new BUS_LoaiThietBi_Service();
            LoadCBB();
            comboBox1.SelectedIndex = 0;
        }
        private IBUS_LoaiThietBi_Service _LoaiThietBi_Service;
        private IBUS_ThietBi_Service _ThietBi_Service;
        private void LoadData()
        {
            var data =
                (from a in _ThietBi_Service.GetlstThietBis()
                 join b in _LoaiThietBi_Service.GetlstLoaiThietBis() on a.IdmaLoaiTb equals b.MaLoaiTb
                 select new
                 {
                     a.MaTb,
                     a.TenTb,
                     b.TenLoai,
                     b.XuatXu,
                     a.SoLuong
                 }).ToList();
            dataGridView1.DataSource = data;
        }
        private void LoadCBB()
        {
            comboBox1.Items.Add("Tất cả");
            foreach (var x in _ThietBi_Service.GetlstThietBis())
            {
                comboBox1.Items.Add(x.TenTb);
            }
        }
        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Tất cả")
            {
                LoadData();
            }
            else
            {
                var data = (from a in _ThietBi_Service.GetlstThietBis()
                            from b in _LoaiThietBi_Service.GetlstLoaiThietBis()
                            where a.IdmaLoaiTb.Equals(b.MaLoaiTb)
                            && a.TenTb.Equals(comboBox1.Text)
                            select new
                            {
                                a.MaTb,
                                a.TenTb,
                                b.TenLoai,
                                b.XuatXu,
                                a.SoLuong
                            }).ToList();
                dataGridView1.DataSource = data;
            }
        }
    }
}
