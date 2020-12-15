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
    public partial class studAnswer : UserControl
    {
        public static int assignid;
        public static int st_id;
        public studAnswer()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            profAddGrade pag = new profAddGrade();
            pag.Show();
        }

        private void studAnswer_Load(object sender, EventArgs e)
        {

        }
        public void assig_id(int ass)
        {
            assign_id.Text = ass.ToString();
            assignid = ass;
        }
        public void s_id(int s)
        {
            stud_id.Text = s.ToString();
            st_id = s;
        
        }
        public void answer(string ans)
        {
            assign_ans.Text = ans;
        }
    }
}
