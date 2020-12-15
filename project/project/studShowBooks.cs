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
    public partial class studShowBooks : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public studShowBooks()
        {
            InitializeComponent();
        }

        private void studShowBooks_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select book.book_name, book.author,book.book_link , book.course_id from book, course where course.course_id = book.course_id and course.teaching_year= :yr";
            c.Parameters.Add("yr", login.year);
            OracleDataReader dr = c.ExecuteReader();
            while (dr.Read())
            {
                studShowBook ssb = new studShowBook();
                ssb.book_name(dr[0].ToString());
                ssb.author(dr[1].ToString());
                ssb.link = dr[2].ToString();
                ssb.c_id(int.Parse(dr[3].ToString()));
                flowLayoutPanel1.Controls.Add(ssb);
            }
        }
    }
}
