using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnThi
{
    public partial class DanhSachSV : Form
    {
        public DanhSachSV()
        {
            InitializeComponent();
        }
        BLL_QuanLySP bll;
        private void DanhSachSV_Load(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            cbo_DanhMuc.Items.Add("Chọn tát cả");
            foreach (var item in bll.GetDanhSachDM())
            {
                cbo_DanhMuc.Items.Add(item.CatName);
            }
            cbo_DanhMuc.SelectedIndex = 0;
        }

        private void cbo_DanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            if(cbo_DanhMuc.SelectedIndex == 0)
            {
                dataGridView1.DataSource = bll.GetDSSP();
               
            }else
            {
                int catID = bll.GetCatID(cbo_DanhMuc.SelectedItem.ToString());
                dataGridView1.DataSource = bll.GetSPWithIDCat(catID);
            }
            lbl_slsp.Text = dataGridView1.RowCount.ToString();
        }

        public void setDataToControl(tblPro pro)
        {
            txt_Name.Text = pro.ProName;
            txt_Des.Text = pro.ProDescription;
            lbl_masp.Text = pro.ProID.ToString();
        }
        public void setControlToData(ref tblPro pro)
        {
            bll = new BLL_QuanLySP();
            pro.ProID = Convert.ToInt32(lbl_masp.Text);
            pro.ProName = txt_Name.Text;
            pro.ProDescription = txt_Des.Text;
            pro.CatID = bll.GetCatID(cbo_DanhMuc.SelectedItem.ToString());
        }
        public void setGridViewToData(ref tblPro pro)
        {
            pro.ProID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_ProID"].Value.ToString());
            pro.ProName = dataGridView1.CurrentRow.Cells["col_ProName"].Value.ToString();
            pro.ProDescription = dataGridView1.CurrentRow.Cells["col_ProDescription"].Value.ToString();
            pro.ProStatus = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_ProStatus"].Value.ToString());
            pro.CatID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["col_CatID"].Value.ToString());
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tblPro pro = new tblPro();
            setGridViewToData(ref pro);
            setDataToControl(pro);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            tblPro pro = new tblPro();
            pro.ProStatus = 1;
            setControlToData(ref pro);
            int result = bll.AddProduct(pro);
            if (result > 0)
            {
                MessageBox.Show("Thêm thành công");
                cbo_DanhMuc_SelectedIndexChanged(sender, e);
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {

            bll = new BLL_QuanLySP();
            tblPro pro = new tblPro();
            setControlToData(ref pro);
            bool result = bll.Edit(pro);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                cbo_DanhMuc_SelectedIndexChanged(sender, e);
            }
            else
                MessageBox.Show("Thêm không thành công");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
           
           for(int i = dataGridView1.RowCount - 1; i > 0; i--)
            {
                if (dataGridView1.Rows[i].Cells["col_Check"].Selected)
                {
                    bll.Delete(Convert.ToInt32(dataGridView1.Rows[i].Cells["col_ProID"].Value.ToString()));
                }
            }
            cbo_DanhMuc_SelectedIndexChanged(sender, e);
        }

        private void btn_xembc_Click(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            Frm_Report frm_Report = new Frm_Report();
            frm_Report.CatID = bll.GetCatID(cbo_DanhMuc.SelectedItem.ToString()).ToString();
            frm_Report.Show();
        }
    }
}
