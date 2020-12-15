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
    public partial class studShowAssignments : UserControl
    {
        
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public studShowAssignments()
        {
            InitializeComponent();
        }

        private void studShowAssignments_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            DateTime thisDay = DateTime.Today;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select COURSE_ID,DEADLINE,ASSIGNMENT, ASSIGN_ID from ASSIGNMENT where COURSE_ID in (select COURSE_ID  from ENROLLED_COURSE where STUD_ID= :studid  ) and DEADLINE >= :dline";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("studid", login.id);
            cmd.Parameters.Add("dline", thisDay);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                studShowAssignment ssa = new studShowAssignment();

                ssa.Course_ID(int.Parse(dr[0].ToString()));
                ssa.DeadLine(dr[1].ToString());
                ssa.Assignment(dr[2].ToString());
                ssa.assign_id(int.Parse(dr[3].ToString()));
                flowLayoutPanel1.Controls.Add(ssa);
            }
            conn.Close();
        }

       
    }
}