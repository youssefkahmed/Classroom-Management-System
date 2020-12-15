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
    public partial class MsgLoginSuccess : Form
    {
        public MsgLoginSuccess()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (login.type == 0)
            {
                mainAdmin ad = new mainAdmin();
                ad.ShowDialog();
            }
            else if (login.type == 1)
            {
                mainProfessor prof = new mainProfessor();
                prof.ShowDialog();
            }
            else if (login.type == 2)
            {
                MainForm stud = new MainForm();
                stud.ShowDialog();

            }
            this.Close();
        }
    }
}
