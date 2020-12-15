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
    public partial class mainProfessor : Form
    {
        public mainProfessor()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //animation
            if (sideMenu.Width == 53)
            {
                //expand panel
                sideMenu.Visible = false;
                sideMenu.Width = 260;
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainProfessor_Load(object sender, EventArgs e)
        {
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
            bunifuCustomLabel1.Text = login.name;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
          profShowAnswersAssignment1.Visible = true;
           profUpdateGrade1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
           profUpdateGrade1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = true;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            profShowHolidays1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            profSeeBestStudentGrade1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            profAddLecture1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            profUpdateLecture1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            profAddAssignment1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            profAddBook1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profChangePassword1.Visible = false;
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            profChangePassword1.Visible = true;
            profShowAnswersAssignment1.Visible = false;
            profUpdateGrade1.Visible = false;
            profRequestHoliday1.Visible = false;
            profSeeBestStudentGrade1.Visible = false;
            profAddLecture1.Visible = false;
            profUpdateLecture1.Visible = false;
            profAddAssignment1.Visible = false;
            profShowHolidays1.Visible = false;
            profAddBook1.Visible = false;
        }
    }
}
