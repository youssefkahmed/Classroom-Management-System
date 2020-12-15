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
   
    public partial class profAddAssignment : UserControl
    {
        string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        OracleConnection conn;
        public profAddAssignment()
        {
            InitializeComponent();
        }

        private void course_id_onItemSelected(object sender, EventArgs e)
        {

        }

        private void profAddAssignment_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select COURSE_ID from COURSE where PROFESSOR_ID = :p_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("p_id", login.id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                course_id.AddItem(dr[0].ToString());
              
            }
            dr.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {

            int c_id = int.Parse(course_id.selectedValue.ToString());
            string deadline_t = deadline.Value.ToString("dd-MMM-yy");
            string ass = assignment.Text;
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into assignment values (assignment_id.nextval , :cour_id , :deadline , :assign)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("cour_id", c_id);
            cmd.Parameters.Add("deadline", deadline_t);
            cmd.Parameters.Add("assign", ass);
            int x = cmd.ExecuteNonQuery();
            if (x != -1)
            {
                MessageBox.Show("Assignment Added Successfully");
                assignment.Text = "";
            }
        }
    }
}
