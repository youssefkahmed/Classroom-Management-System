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
    public partial class studSubmitAssignment : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public studSubmitAssignment()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            DateTime d1 = default(DateTime);
            DateTime thisDay = DateTime.Today;
            int studID = 0;
            
            OracleCommand c11 = new OracleCommand();
            c11.Connection = conn;
            c11.CommandText = "select answer_id from assignment_answers where assign_id = :ass_id and stud_id = :s_id";
            c11.Parameters.Add("ass_id",int.Parse(Id.Text.ToString()));
            c11.Parameters.Add("s_id", login.id);
            //int s = c11.ExecuteNonQuery();
            //MessageBox.Show(s.ToString());

            OracleDataReader dr1 = c11.ExecuteReader();
            while (dr1.Read()) {
                studID = int.Parse(dr1[0].ToString());
            }

            if (studID == 0)
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select deadline from assignment where assign_id= :ass_id";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("ass_id", int.Parse(Id.Text.ToString()));
                OracleDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    d1 = DateTime.Parse(dr[0].ToString());

                }
                int res = DateTime.Compare(thisDay, d1);
                if (res <= 0)
                {
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "submit_answer";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("assi_id", int.Parse(Id.Text));
                    cmd.Parameters.Add("student_id", login.id);
                    cmd.Parameters.Add("ans", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Answer is Sent");
                }
                else
                {
                    MessageBox.Show("Sorry You Have Missed The Deadline, You Can't Submit The Assignment");
                }
            }
            else
            {
                MessageBox.Show("Sorry, you already submitted an answer to this assignment");
            }
        }

        private void studSubmitAssignment_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
