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
    public partial class profShowAnswersAssignment : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public profShowAnswersAssignment()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profShowAnswersAssignment_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select assignment_answers.stud_id , assignment_answers.assign_id , assignment_answers.answer from course , assignment , assignment_answers where course.course_id = assignment.course_id and assignment.assign_id= assignment_answers.assign_id and course.professor_id = :p_id";
            c.Parameters.Add("p_id", login.id);
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                studAnswer sa = new studAnswer();
                sa.s_id(int.Parse(dr[0].ToString()));
                sa.assig_id(int.Parse(dr[1].ToString()));
                sa.answer(dr[2].ToString());
                flowLayoutPanel1.Controls.Add(sa);

            }
            conn.Close();
        }
    }
}
