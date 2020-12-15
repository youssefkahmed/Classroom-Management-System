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
    public partial class adminShowComplaints : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public adminShowComplaints()
        {
            InitializeComponent();
        }

        private void adminShowComplaints_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
             conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select complain_id,stud_id,complaint from complaints where status = :status";
            c.Parameters.Add("status", "pending");
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                adminShowComplaint asc = new adminShowComplaint();
                asc.comp_id(int.Parse(dr[0].ToString()));
                asc.stud_id(int.Parse(dr[1].ToString()));
                asc.complaint(dr[2].ToString());
                flowLayoutPanel1.Controls.Add(asc);

            }
            conn.Close();
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
