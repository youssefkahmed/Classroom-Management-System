using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace project
{
    public partial class profAddGrade : Form
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public profAddGrade()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into grade values (:s_id,:assi_id,:grade,:bouns)";
            c.Parameters.Add("s_id",studAnswer.st_id);
            c.Parameters.Add("assi_id", studAnswer.assignid);
            c.Parameters.Add("grade",int.Parse(grad.Text.ToString()));
            c.Parameters.Add("bouns", int.Parse(boun.Text.ToString()));
            c.CommandType = CommandType.Text;
            int r = c.ExecuteNonQuery();

            if (r != -1)
            {
                MessageBox.Show("Grade Saved Successfully");
            }
            this.Close();
        }
    }
}
