using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2022
{
    public partial class Menu : Form
    {
        public Menu()
        {

            InitializeComponent();
        }

        private void customerRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Membershipform obj = new Membershipform();
            obj.MdiParent = this;
            obj.Show();

            
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book obj = new Book();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookRentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookRental obj = new BookRental();
            obj.MdiParent = this;
            obj.Show();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
           
        //}

        private void reportsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookReturn obj = new BookReturn();
            obj.MdiParent = this;
            obj.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void booksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptbook obj = new frmrptbook();
            obj.MdiParent = this;
            obj.Show();
        }

        private void memberrshipReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmrptMembership obj = new FrmrptMembership();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookRentalReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptrental obj = new frmrptrental();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookReturnReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmrptreturn obj = new frmrptreturn();
            obj.MdiParent = this;
            obj.Show();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void receiptReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
