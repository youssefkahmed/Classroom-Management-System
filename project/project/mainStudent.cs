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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
            bunifuCustomLabel1.Text = login.name;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //animation
            if (sideMenu.Width == 53)
            {
                //expand panel
                sideMenu.Visible = false;
                sideMenu.Width = 240;
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
            studChooseCourses1.Visible = true;
            studShowGradesMain1.Visible = false;
            studSendComplaint1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            studShowGradesMain1.Visible = true;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studSendComplaint1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studSendComplaint1.Visible = true;
            studSubmitAssignment1.Visible =false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            studSubmitAssignment1.Visible = true;
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void studShowGradesMain1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowAssignments1.Visible = false;
            studShowTotalMain1.Visible = true;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            studShowAssignments1.Visible = true;
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowTotalMain1.Visible = false;
            studChangePassword1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            studChangePassword1.Visible = true;
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studShowBooks1.Visible = false;
        }

        private void studShowAssignments1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            studShowBooks1.Visible = true;
            studSendComplaint1.Visible = false;
            studShowGradesMain1.Visible = false;
            studChooseCourses1.Visible = false;
            studSubmitAssignment1.Visible = false;
            studShowTotalMain1.Visible = false;
            studShowAssignments1.Visible = false;
            studChangePassword1.Visible = false;
        }
    }
}
