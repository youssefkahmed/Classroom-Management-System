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
    public partial class profSeeBestStudentGrade : UserControl
    {
        BestGrades cr;
        public profSeeBestStudentGrade()
        {
            InitializeComponent();
        }

        private void profSeeBestStudentGrade_Load(object sender, EventArgs e)
        {
            cr = new BestGrades();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int assign_id = int.Parse(assignment_id.Text.ToString());
            cr.SetParameterValue(0,assign_id);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
