using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyHang.View
{
    public partial class form_InBaoCao : Form
    {
        public form_InBaoCao()
        {
            InitializeComponent();
        }

        private List<ReportParameter> reportParameters = new List<ReportParameter>();

        public Object dataSource = null;

        private void InBaoCao_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet_Loai", dataSource));            
            //reportParameters.Add(new ReportParameter("tenTaiKhoan", "Phuc"));
            //reportViewer1.LocalReport.SetParameters(reportParameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
