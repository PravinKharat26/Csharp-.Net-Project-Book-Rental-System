using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project2022
{
    public partial class BookReturn : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        static public int invoiceno;
        
        public BookReturn()
        {
            InitializeComponent();
        }
        private void Date()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            txtdate.Text = date.ToString();
        }

        private void showcustomer()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            string qry = "select customer_name from book_rental";
            cmd = new SqlCommand(qry, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbcustomer.Items.Add(dr[0]);
            }
            cn.Close();

        }

        private void generateinvoiceid()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            String sql = "select max(Invoice_no)+1 from book_return";
            cmd = new SqlCommand(sql, cn);
            cn.Open();
            object obj = cmd.ExecuteScalar();
            if (obj == DBNull.Value)
                obj = 1;
            txtinvoice.Text = Convert.ToString(obj);
            cn.Close();
        }
        private void BookReturn_Load(object sender, EventArgs e)
        {
            filldatagridview();
            showcustomer();
            Date();
            generateinvoiceid();
        }
        private void filldatagridview()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string qry = "select * from book_rental";
            cmd = new SqlCommand(qry, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvrental.DataSource = dt;
            cn.Close();

        }

        private void cmbcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "select * from book_rental where customer_name=@cn";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@cn", cmbcustomer.SelectedItem);
                DataTable dt = new DataTable();
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvrental.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvrental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvrental_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            //    var i = Convert.ToInt32(dgvrental.Rows[e.RowIndex].Cells[3].Value);
            //    var j = Convert.ToInt32(System.DateTime.Now);
                lblcid.Text = "Customer id:";
                lblcustid.Text = dgvrental.Rows[e.RowIndex].Cells[6].Value.ToString();
                lblbid.Text = "Book id:";
                lblbookid.Text = dgvrental.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblbname.Text = "Book name:";
                lblbookname.Text = dgvrental.Rows[e.RowIndex].Cells[10].Value.ToString();

                if (System.DateTime.Now > Convert.ToDateTime(dgvrental.Rows[e.RowIndex].Cells[3].Value))
                {
                    TimeSpan ts = System.DateTime.Now -Convert.ToDateTime(dgvrental.Rows[e.RowIndex].Cells[3].Value);
                    int days = ts.Days;
                    txtextradays.Text = days.ToString();
                    txtfine.Text = (days * 10).ToString();

                    int i = Convert.ToInt32(dgvrental.Rows[e.RowIndex].Cells[5].Value);
                    int j = Convert.ToInt32(txtfine.Text);
                    int k = i + j;
                    txtrent.Text =k.ToString();
                    
                    
                }
                else if (System.DateTime.Now < Convert.ToDateTime(dgvrental.Rows[e.RowIndex].Cells[3].Value))
                {
                    TimeSpan ts = Convert.ToDateTime(dgvrental.Rows[e.RowIndex].Cells[3].Value) - System.DateTime.Now;
                    int days = ts.Days;
                    txtextradays.Text = "0";
                    txtfine.Text = "0";
                    int j =Convert.ToInt32( days);
                    int l =Convert.ToInt32( dgvrental.Rows[e.RowIndex].Cells[4].Value);
                    int i =l - j;
               

                    //int i = Convert.ToInt32(dgvrental.Rows[e.RowIndex].Cells[5].Value);
                    //int j = Convert.ToInt32(txtfine.Text);
                    int k = i * 1;
                    txtrent.Text = i.ToString();


                }
                else
                {
                    int a=0;
                    txtextradays.Text = a.ToString();
                    txtfine.Text = a.ToString();
                    txtrent.Text = dgvrental.Rows[e.RowIndex].Cells[5].Value.ToString();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
            
        }

        private void txtextradays_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
    
                
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "insert into book_return(date,cust_name,extradays,fine,totalrent,cust_id,book_id,book_name,Invoice_no) values (@date,@cn,@ed,@fine,@trent,@cid,@bid,@bname,@in)";

                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@date", txtdate.Text);
                cmd.Parameters.AddWithValue("@cn",cmbcustomer.Text);
                cmd.Parameters.AddWithValue("@ed",txtextradays.Text);
                cmd.Parameters.AddWithValue("@fine", txtfine.Text);
                cmd.Parameters.AddWithValue("@trent", txtrent.Text);
                cmd.Parameters.AddWithValue("@cid",lblcustid.Text);
                cmd.Parameters.AddWithValue("@bid",lblbookid.Text);
                cmd.Parameters.AddWithValue("@bname",lblbookname.Text);
                cmd.Parameters.AddWithValue("@in", txtinvoice.Text);


              
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Record Saved Successfully*****");
                invoiceno = Convert.ToInt32(txtinvoice.Text);
                frmrptreceipt obj = new frmrptreceipt();
                obj.Show();
                this.Close();
                generateinvoiceid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfine_TextChanged(object sender, EventArgs e)
        {

        }

        //public static object Invoice_no {  }
    }
}
