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
//using System.Threading;


namespace project2022
{
    public partial class login : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        public login()
        {

            //Thread t = new Thread(new ThreadStart(StartForm));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            //t.Abort();
           
        }
  
        //public void StartForm()
        //{
           
        //        Application.Run(new splashscreen());
                
     
        //}
        private void btnlogin_Click(object sender, EventArgs e)
        {
           
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBconn"].ConnectionString);
                string qry = "select * from admin where uname=@u and password=@pass";
                cmd = new SqlCommand(qry, cn);
                cmd.Parameters.AddWithValue("@u", txtusername.Text);
                cmd.Parameters.AddWithValue("@pass", txtpassword.Text);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    MessageBox.Show("******Login Successful******");
                    cn.Close();
                    Menu obj = new Menu();
                    obj.Show();
                    this.Hide();
                  
                }
                else
                {
                    MessageBox.Show("Login Unsuccessful");
                    txtusername.SelectAll();
                    txtusername.Focus();
                    cn.Close();
                }


            }
            catch(Exception ex)
            
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            
           

        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelmsg.Location = new Point(labelmsg.Location.X + 5, labelmsg.Location.Y);
            if (labelmsg.Location.X > this.Width)
            {
                labelmsg.Location = new Point(0 - labelmsg.Width, labelmsg.Location.Y);
            } 
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
