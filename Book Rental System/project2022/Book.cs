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
    public partial class Book : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public Book()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

     
        private void btncalculate_Click_1(object sender, EventArgs e)
        {
           

        }
        private void clearall()
        {
            lblbid.Text = "";
            txtisbn.Text = "";
            cmbcategory.SelectedItem = null;
            cmbpublisher.SelectedItem = null;
            txtbookname.Text = "";
            txtauthor.Text = "";
            txtprice.Text = "";
            //txtrent.Text = "";
            txtstock.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                try
                {
                    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string qry = "insert into book (isbn,category,publisher,bookname,author,price,stock) values (@isbn,@cat,@publish,@bname,@author,@price,@stock)";

                    cmd = new SqlCommand(qry, cn);
                    cmd.Parameters.AddWithValue("@isbn", txtisbn.Text);
                    cmd.Parameters.AddWithValue("@cat", cmbcategory.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@publish", cmbpublisher.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@bname", txtbookname.Text);
                    cmd.Parameters.AddWithValue("@author", txtauthor.Text);
                    cmd.Parameters.AddWithValue("@price", txtprice.Text);
                    //cmd.Parameters.AddWithValue("@rent", txtrent.Text);
                    cmd.Parameters.AddWithValue("@stock", txtstock.Text);

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("*****Record Saved Successfully*****");
                    filldatagridview();
            

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool validate()
        {
            if (txtisbn.Text == "")
            {
                MessageBox.Show("please enter ISBN No.", "ISBN??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtisbn.Focus();
                return false;
            }
            else if (cmbcategory.Text == "")
            {
                MessageBox.Show("please select book category", "category??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbcategory.Focus();
                return false;
            }

            else if (cmbpublisher.Text == "")
            {
                MessageBox.Show("please select publisher", "publisher??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbpublisher.Focus();
                return false;
            }
            else if (txtbookname.Text == "")
            {
                MessageBox.Show("please enter book name", "book name??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbookname.Focus();
                return false;
            }
            else if (txtauthor.Text == "")
            {
                MessageBox.Show("please enter author name", "author??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthor.Focus();
                return false;
            }
            else if (txtauthor.Text == "")
            {
                MessageBox.Show("please enter author name", "author??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtauthor.Focus();
                return false;
            }
            else if (txtprice.Text == "")
            {
                MessageBox.Show("please enter price", "price??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprice.Focus();
                return false;
            }
            //else if (txtrent.Text == "")
            //{
            //    MessageBox.Show("please enter rent", "rent??", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtrent.Focus();
            //    return false;
            //}
            else if (txtstock.Text == "")
            {
                MessageBox.Show("please enter stock(quantity)", "stock??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstock.Focus();
                return false;
            }
           
           
           
           
            else
                return true;
        }
        private void filldatagridview()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string qry = "select * from book";
            cmd = new SqlCommand(qry, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvbook.DataSource = dt;
            cn.Close();

        }
        private void Book_Load(object sender, EventArgs e)
        {
            filldatagridview();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "update book set isbn=@isbn,category=@cat,publisher=@publish,bookname=@bname,author=@author,price=@price,stock=@stock where bookid=@bid";

                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@isbn", txtisbn.Text);
                cmd.Parameters.AddWithValue("@cat", cmbcategory.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@publish", cmbpublisher.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@bname", txtbookname.Text);
                cmd.Parameters.AddWithValue("@author", txtauthor.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
               // cmd.Parameters.AddWithValue("@rent", txtrent.Text);
                cmd.Parameters.AddWithValue("@stock", txtstock.Text);
                cmd.Parameters.AddWithValue("@bid", lblbid.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Record Updated Successfully*****");
                filldatagridview();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "delete from book where bookid=@bid";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@bid", lblbid.Text);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Records deleted successfully*****");
               
                filldatagridview();
                clearall();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void dgvbook_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            lblbid.Text = dgvbook.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtisbn.Text = dgvbook.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbcategory.Text = dgvbook.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbpublisher.Text = dgvbook.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtbookname.Text = dgvbook.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtauthor.Text = dgvbook.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtprice.Text = dgvbook.Rows[e.RowIndex].Cells[6].Value.ToString();
            //txtrent.Text = dgvbook.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtstock.Text = dgvbook.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void txtbooksearch_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtisbn_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbpublisher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtauthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbookname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
