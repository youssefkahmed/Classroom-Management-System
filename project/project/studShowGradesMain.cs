using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class studShowGradesMain : UserControl
    {
        public studShowGradesMain()
        {
            InitializeComponent();
        }

      

        private void studShowGradesMain_Load(object sender, EventArgs e)
        {
            studentShowGrades cr = new studentShowGrades();
           // MessageBox.Show(login.id.ToString());
            cr.SetParameterValue(0, login.id);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
