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
    public partial class frmrptreceipt : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        public frmrptreceipt()
        {
            InitializeComponent();
        }

        private void frmrptreceipt_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            string qry = "select date,Invoice_no,cust_id,cust_name,book_id,book_name,totalrent from book_return  where Invoice_no=@in";
            cmd = new SqlCommand(qry, cn);
            cmd.Parameters.AddWithValue("@in",BookReturn.invoiceno);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dsreceipt ds = new dsreceipt();
            da.Fill(ds, "DataTable1");
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"../../rptreceipt.rdlc";
            ReportDataSource rds = new ReportDataSource("dsreceipt", ds.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }
    }
}
