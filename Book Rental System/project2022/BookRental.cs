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
    public partial class BookRental : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public BookRental()
        {
            InitializeComponent();
        }

        private void BookRental_Load(object sender, EventArgs e)
        {
            filldatagridview1();
            filldatagridview2();
            Date();
            showbook();
            showcustomer();
            
            
            
        }
        private void showcustomer()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            string qry = "select cname from membership";
            cmd = new SqlCommand(qry, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbcust.Items.Add(dr[0]);
            }
            cn.Close();

        }
        private void showbook()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString);
            string qry = "select bookname from book";
            cmd = new SqlCommand(qry, cn);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                cmbbook.Items.Add(dr[0]);
            }
            cn.Close();

        }
        private void Date()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            txtdate.Text = date.ToString();
        }
        private void filldatagridview1()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string qry = "select * from book";
            cmd = new SqlCommand(qry, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvBook.DataSource = dt;
            cn.Close();

        }
        private void filldatagridview2()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string qry = "select * from membership";
            cmd = new SqlCommand(qry, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvcust.DataSource = dt;
            cn.Close();

        }
        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvBook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblbook.Text=dgvBook.Rows[e.RowIndex].Cells[0].Value.ToString();
            lblbook2.Text=dgvBook.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblid.Text = "Book id:";
            lblisbn.Text = "ISBN:";
            lblbname.Text = "Book name:";
            lblbookname.Text = dgvBook.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            
        }
       
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblbook_Click(object sender, EventArgs e)
        {

        }

        private void lblcust_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "insert into book_rental(date,book_id,isbn,rentupto_date,no_ofdays,total_rent,cust_id,customer_name,cust_contact,cust_address,book_name) values (@date,@id,@isbn,@rud,@nod,@trent,@custid,@cname,@ccon,@cadd,@bn)";

                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@date",txtdate.Text);
                cmd.Parameters.AddWithValue("@id",lblbook.Text);
                cmd.Parameters.AddWithValue("@isbn",lblbook2.Text);
                cmd.Parameters.AddWithValue("@rud",dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@nod",txtdays.Text);
                cmd.Parameters.AddWithValue("@trent",txttotalrent.Text);
                cmd.Parameters.AddWithValue("@custid",lblcust.Text);
                cmd.Parameters.AddWithValue("@cname",lblcustname.Text);
                cmd.Parameters.AddWithValue("@ccon", lblcust3.Text);
                cmd.Parameters.AddWithValue("@cadd", lbladdress.Text);
                cmd.Parameters.AddWithValue("@bn", lblbookname.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Record Saved Successfully*****");
                        
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan ts = dateTimePicker1.Value - System.DateTime.Now;
            int days=ts.Days;
           if(days==0)
               
            days=1;

            days++;
            txtdays.Text = days.ToString();

            int a,b,c;
            a =Convert.ToInt32(txtdays.Text);
            b =Convert.ToInt32(txtrent.Text);
            c = a * b;

            txttotalrent.Text = c.ToString();
           
        }

        private void txtrent_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void dgvcust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            lblcust.Text =  dgvcust.Rows[e.RowIndex].Cells[0].Value.ToString();
            //lblcust2.Text =  dgvcust.Rows[e.RowIndex].Cells[3].Value.ToString();
            lblcust3.Text =  dgvcust.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblcid.Text = "Customer id:";
            lblcon.Text = "Contact:";
            lblcname.Text = "Customer name:";
            lblcustname.Text = dgvcust.Rows[e.RowIndex].Cells[3].Value.ToString();
            lbladd.Text = "Customer Address:";
            lbladdress.Text = dgvcust.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

       
        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void cmbbook_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cmbbook_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "select * from book where bookname=@bid";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@bid", cmbbook.SelectedItem);
                DataTable dt = new DataTable();
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvBook.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbcust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "select * from membership where cname=@cn";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@cn", cmbcust.SelectedItem);
                DataTable dt = new DataTable();
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dgvcust.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        
    }
}
