using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace project
{
    public partial class studShowAssignment : UserControl
    {
       
        public studShowAssignment()
        {
            InitializeComponent();
        }
        int id_c;
        public void Course_ID(int id)
        {
            id_c = id;
            label4.Text = id.ToString();
        }
        public void assign_id(int id)
        {
            label7.Text = id.ToString();
        }
        public void DeadLine(string deadline)
        {
            label5.Text = deadline;
        }
        public void Assignment(string ass)
        {
            label6.Text = ass;
        }
        

        private void studShowAssignment_Load(object sender, EventArgs e)
        {

        }
    }
}
