using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace project2022
{
    public partial class Membershipform : Form

    {
        SqlConnection cn;
        SqlCommand cmd;
        public Membershipform()
        {
            InitializeComponent();
        }

        private void dgvcustomer_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblcid.Text = dgvcustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtfees.Text = dgvcustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtdate.Text = dgvcustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtname.Text = dgvcustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtaddress.Text = dgvcustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcontact.Text = dgvcustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtaadhar.Text = dgvcustomer.Rows[e.RowIndex].Cells[6].Value.ToString();
            string g = dgvcustomer.Rows[e.RowIndex].Cells[7].Value.ToString();
            if (g == "Male")
                rdbmale.Checked =true;
            else if (g == "Female")
                rdbfemale.Checked =true;

           

        }
        private void filldatagridview()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
            string qry = "select * from membership";
            cmd = new SqlCommand(qry, cn);
            DataTable dt = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgvcustomer.DataSource = dt;
            cn.Close();

        }
        private string getradiovalue()
        {
            if (rdbmale.Checked)
                return rdbmale.Text;
            else if (rdbfemale.Checked)
                return rdbfemale.Text;
            else
                return null;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (validate() == true)
            {
                try
                {
                    cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                    string sqry = "insert into membership (deposit,date,cname,address,contact,aadhaar_no,gender) values (@dep,@date,@name,@add,@con,@aadhar,@gender)";
                    cmd = new SqlCommand(sqry, cn);
                    cmd.Parameters.AddWithValue("@dep",txtfees.Text);
                    cmd.Parameters.AddWithValue("@date",txtdate.Text);
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@add", txtaddress.Text);
                    cmd.Parameters.AddWithValue("@con", txtcontact.Text);
                    cmd.Parameters.AddWithValue("@aadhar", txtaadhar.Text);
                    cmd.Parameters.AddWithValue("@gender", getradiovalue());
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("*****Customer registered successfully*****");
                    filldatagridview();
                    clearrecords();
                    Date();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Date()
        {
            string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
            txtdate.Text = date.ToString();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            filldatagridview();
            Date();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sqry = "update membership set deposit=@dep,date=@date,cname=@name,address=@add,contact=@con,aadhaar_no=@aadhar,gender=@gender where cust_id=@cid";
                cmd = new SqlCommand(sqry, cn);
                cmd.Parameters.AddWithValue("@dep",txtfees.Text);
                cmd.Parameters.AddWithValue("@date", txtdate.Text);
                cmd.Parameters.AddWithValue("@name", txtname.Text);
                cmd.Parameters.AddWithValue("@add", txtaddress.Text);
                cmd.Parameters.AddWithValue("@con", txtcontact.Text);
                cmd.Parameters.AddWithValue("@aadhar", txtaadhar.Text);
                cmd.Parameters.AddWithValue("@gender", getradiovalue());
                cmd.Parameters.AddWithValue("@cid",lblcid.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Records updated successfully*****");
                filldatagridview();
                clearrecords();
                Date();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearrecords()
        {
            lblcid.Text = "";
            //txtfees.Text = "";
          //  txtdate.Text = "";
            txtname.Text= "";
            txtaddress.Text = "";
            txtaadhar.Text = "";
            txtcontact.Text = "";
            rdbmale.Checked = false;
            
            rdbfemale.Checked = false;
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string sqry = "delete from membership where cust_id=@cid";
                cmd = new SqlCommand(sqry, cn);
                
                cmd.Parameters.AddWithValue("@cid", lblcid.Text);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("*****Record deleted successfully*****");
                filldatagridview();
                clearrecords();
                Date();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clearrecords();
            Date();
        }

        private bool validate()
        {
            if(txtname.Text=="")
            {
                MessageBox.Show("please enter name", "Name??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return false;
            }
            else if(txtaddress.Text=="")
            {
                MessageBox.Show("please enter address", "address??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
                return false;
            }

            else if (txtaadhar.Text == "")
            {
                MessageBox.Show("please enter aadhar no.", "aadhar no??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaadhar.Focus();
                return false;
            }
            else if (txtcontact.Text == "")
            {
                MessageBox.Show("please enter contact no.", "contact no??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcontact.Focus();
                return false;
            }
            else if (rdbmale.Checked==false && rdbfemale.Checked==false)
            {
                MessageBox.Show("please select gender", "gender??", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaadhar.Focus();
                return false;
            }
             
              
            else
                return true;
        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdbmale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbfemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
