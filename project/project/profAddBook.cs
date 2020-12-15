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
    public partial class profAddBook : UserControl
    {
        int profID = login.id;
        String connStr = "Data source=orcl;User Id=scott;Password=tiger;";

        public profAddBook()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int courseID = 0;
            String courseName = bunifuDropdown1.selectedValue.ToString();
            String bookName = bunifuMaterialTextbox2.Text;
            String bookAuthor = bunifuMaterialTextbox1.Text;
            String bookLink = bunifuMaterialTextbox4.Text;

            try
            {
                OracleConnection conn = new OracleConnection(connStr);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT course_id FROM Course WHERE course_name = :courseName";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("courseName", courseName);

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    courseID = int.Parse(dr[0].ToString());
                }
                dr.Close();


                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
              /*  cmd2.CommandText = "SELECT course_id FROM Course WHERE course_name = :courseName";
                cmd2.CommandType = CommandType.Text; */
                cmd2.CommandText = "insertBook";
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.Add("bookName", bookName);
                cmd2.Parameters.Add("bookAuthor", bookAuthor);
                cmd2.Parameters.Add("bookLink", bookLink);
                cmd2.Parameters.Add("courseID", courseID);

                cmd2.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure you filled all the required fields.");
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void profAddBook_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT course_name FROM Course WHERE professor_id = :profID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("profID", profID);

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bunifuDropdown1.AddItem(dr[0].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            profDeleteBook d = new profDeleteBook();
            d.Show();
        }
    }
}
