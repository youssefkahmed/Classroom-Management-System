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
    public partial class profDeleteBook : Form
    {
        int profID = login.id;
       static String connStr = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn = new OracleConnection(connStr);
        public profDeleteBook()
        {
            InitializeComponent();
        }

        private void profDeleteBook_Load(object sender, EventArgs e)
        {
           
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT book_name FROM book,course WHERE course.professor_id = :profID and course.course_id = book.course_id";
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "delbook";
            cmd.Parameters.Add("bname", bunifuDropdown1.selectedValue);
           cmd.ExecuteNonQuery();
            MessageBox.Show("Book Deleted Successfully");
             this.Close();
            
            
        }
    }
}
