
using Microsoft.Reporting.WinForms;
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
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }
        BLL_QuanLySP bll;
        public string CatID;
        public void HienThiReport()
        {
            List<DT0_SP_DM> ds_SP_With_Cat = bll.GetSPVsCat(Convert.ToInt32(CatID));
            int i = 1;
            foreach(DT0_SP_DM item in ds_SP_With_Cat)
            {
                item.STT = i;
                i++;
            }
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportEmbeddedResource = "OnThi.Report1.rdlc";
            //reportViewer1.LocalReport.ReportPath = @"D:\Hoc\C#\bai tap c#\OnThi\OnThi\Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource _dataSource = new ReportDataSource("Ds_InBaoCao", ds_SP_With_Cat);

            reportViewer1.LocalReport.DataSources.Add(_dataSource);
            this.reportViewer1.RefreshReport();
        }
        private void Frm_Report_Load(object sender, EventArgs e)
        {
            bll = new BLL_QuanLySP();
            HienThiReport();
        }

       
    }
}
