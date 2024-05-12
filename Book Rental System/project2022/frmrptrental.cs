using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Configuration;
using System.Data.SqlClient;



namespace project2022
{
    public partial class frmrptrental : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        
        public frmrptrental()
        {
            InitializeComponent();
        }

        private void frmrptrental_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            string sql = "select * from book_rental";
            cmd = new SqlCommand(sql, cn);
            DSrental ds = new DSrental();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "DataTable1");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"../../rptrental.rdlc";
            ReportDataSource rds = new ReportDataSource("DSrental", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
