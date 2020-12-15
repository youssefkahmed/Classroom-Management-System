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
    public partial class profUpdateGrade : UserControl
    {
        static String connStr = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn = new OracleConnection(connStr);
        
        public profUpdateGrade()
        {
            InitializeComponent();
        }

        private void profUpdateGrade_Load(object sender, EventArgs e)
        {
            int[] profCourses = new int[25];
            int index = 0;

            OracleConnection conn = new OracleConnection(connStr);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT course_id FROM course where professor_id = :profID";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("profID", login.id);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                profCourses[index] = int.Parse(dr[0].ToString());
                index++;
            }
            dr.Close();

            for(int i = 0; i < index; i++)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT stud_id FROM enrolled_course WHERE course_id = :courseID";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("courseID", profCourses[i]);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bunifuDropdown1.AddItem(dr[0].ToString());
                }
                dr.Close();
            }

            for (int i = 0; i < index; i++)
            {
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT assign_id FROM assignment WHERE course_id = :courseID";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("courseID", profCourses[i]);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    bunifuDropdown2.AddItem(dr[0].ToString());
                }
                dr.Close();
            }
            
            conn.Close();

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = int.Parse(bunifuDropdown1.selectedValue), assignmentID = int.Parse(bunifuDropdown2.selectedValue),
                    grade = int.Parse(bunifuMaterialTextbox2.Text), bonus = int.Parse(bunifuMaterialTextbox1.Text);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "update grade set grade= :grade, bouns=:bonus where stud_id = :studentID and assign_id= :assignmentID ";
                cmd.Parameters.Add("grade", grade);
                cmd.Parameters.Add("bonus", bonus);
                cmd.Parameters.Add("studentID", studentID);
                cmd.Parameters.Add("assignmentID", assignmentID);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
                 
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure you filled all the required fields.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
