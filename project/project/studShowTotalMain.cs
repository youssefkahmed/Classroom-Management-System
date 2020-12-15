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
    public partial class studShowTotalMain : UserControl
    {
        public studShowTotalMain()
        {
            InitializeComponent();
        }

        private void studShowTotalMain_Load(object sender, EventArgs e)
        {
            studentShowTotal sft = new studentShowTotal();
            sft.SetParameterValue(0, login.id);
            crystalReportViewer1.ReportSource = sft;
        }
         
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
