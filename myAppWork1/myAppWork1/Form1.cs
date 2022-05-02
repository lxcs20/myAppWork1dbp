using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myAppWork1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLoanBook btnLoanBook = new frmLoanBook();
            btnLoanBook.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReturn btnReturn = new frmReturn();
            btnReturn.Show();
        }

        private void btnMemberCard_Click(object sender, EventArgs e)
        {

        }

        private void btnReprt_Click(object sender, EventArgs e)
        {
            frmReport btnReport = new frmReport();
            btnReport.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddBook btnAddBook = new frmAddBook();
            btnAddBook.Show();
        }

        private void btnManag_Click(object sender, EventArgs e)
        {
            frmManagment btnManag = new frmManagment();
            btnManag.Show();
        }
    }
}
