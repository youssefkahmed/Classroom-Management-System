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
    public partial class adminShowComplaint : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public adminShowComplaint()
        {
            InitializeComponent();
        }
    
   
    private void adminShowComplaint_Load(object sender, EventArgs e)
        {

        }
        int c_id;
        public void comp_id(int id)
        {
            c_id = id;
        }
        public void stud_id(int id)
        {
            student_id.Text = id.ToString();
        } 
        public void complaint(string s)
        {
            complain_id.Text = s;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "delete from complaints where complain_id= :c_id";
            c.Parameters.Add("c_id", c_id);
            c.CommandType = CommandType.Text;
            int x = c.ExecuteNonQuery();
            if (x != -1)
            {
                MessageBox.Show("Complaint Deleted");
            }
            seen.Enabled = false;
            seen.IdleFillColor = Color.FromArgb(35, 32, 35);
            seen.IdleForecolor = Color.FromArgb(35, 32, 35);
            seen.IdleLineColor = Color.FromArgb(35, 32, 35);
        }

        private void complain_id_Click(object sender, EventArgs e)
        {

        }
    }
}
