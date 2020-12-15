using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class mainAdmin : Form
    {
        public mainAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //animation
            if (sideMenu.Width == 53)
            {
                //expand panel
                sideMenu.Visible = false;
                sideMenu.Width = 300;
                panelAnimator.ShowSync(sideMenu);
            }
            else
            {
                //minimize panel
                sideMenu.Visible = false;
                sideMenu.Width = 53;
                panelAnimator.ShowSync(sideMenu);
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            regProfessor1.Visible = true;
            adminShowComplaints1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowRequests1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void mainAdmin_Load(object sender, EventArgs e)
        {
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowComplaints1.Visible = false;
            adminShowRequests1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            adminShowComplaints1.Visible = true;
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowRequests1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            adminAddHoliday1.Visible = true;
            adminShowRequests1.Visible = false;
            regProfessor1.Visible = false;
            adminShowComplaints1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            adminShowRequests1.Visible = true;
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowComplaints1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            regStudent1.Visible = true;
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowComplaints1.Visible = false;
            adminShowRequests1.Visible = false;
            adminSeeAll1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            adminSeeAll1.Visible = true;
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowComplaints1.Visible = false;
            adminShowRequests1.Visible = false;
            regStudent1.Visible = false;
            adminSearchForUsers1.Visible = false;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            adminSearchForUsers1.Visible = true;
            regProfessor1.Visible = false;
            adminAddHoliday1.Visible = false;
            adminShowComplaints1.Visible = false;
            adminShowRequests1.Visible = false;
            regStudent1.Visible = false;
            adminSeeAll1.Visible = false;
        }
    }
}
