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
using System.Text.RegularExpressions;
namespace project
{
    public partial class studChangePassword : UserControl
    {
        OracleConnection conn = new OracleConnection(regProfessor.ordb);
        public studChangePassword()
        {
            InitializeComponent();
        }

        private void studChangePassword_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string old_p;
            if (notnull_validate() && pass_validate())
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "select stud_password from student where stud_id= :m_id";
                c.Parameters.Add("m_id", login.id);
                c.CommandType = CommandType.Text;
                OracleDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                  //  MessageBox.Show(login.id.ToString());
                    old_p = dr[0].ToString();
                   // MessageBox.Show(old_p);
                    if (String.Equals(old_p, old_pass.Text.ToString()))
                    {
                        if (String.Equals(new_pass.Text.ToString(), Cnew_pass.Text.ToString()))
                        {
                           // MessageBox.Show("enteredddd");
                            OracleCommand c2 = new OracleCommand();
                            c2.Connection = conn; //
                            c2.CommandText = "update users set uemail = :m , upassword =:pass where uemail = :mail and upassword =:p";
                            c2.Parameters.Add("m", login.mail);
                            c2.Parameters.Add("pass", new_pass.Text.ToString());
                            c2.Parameters.Add("mail", login.mail);
                            c2.Parameters.Add("p", old_p);
                            c2.CommandType = CommandType.Text;
                            int x = c2.ExecuteNonQuery();
                            if (x != -1)
                            {
                                OracleCommand c3 = new OracleCommand();
                                c3.Connection = conn;
                                c3.CommandText = "update student set stud_password =:pass where stud_email = :mail";
                                c3.Parameters.Add("pass", new_pass.Text.ToString());
                                c3.Parameters.Add("mail", login.mail);
                                c3.CommandType = CommandType.Text;
                                int x2 = c3.ExecuteNonQuery();
                                if (x2 != -1)
                                {
                                    MessageBox.Show("Password Updated Successfully");
                                }
                            }


                        }
                        else
                        {
                            MessageBox.Show("Your New Password doesn't match!");
                            old_pass.Text = "";
                            new_pass.Text = "";
                            Cnew_pass.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Old Password isn't Correct!");
                    }
                }
            }
            }
        public bool notnull_validate()
        {

            if (String.IsNullOrEmpty(old_pass.Text.ToString()))
            {
                MessageBox.Show("Enter Your old Password Please!");
                return false;
            }
            if (String.IsNullOrEmpty(new_pass.Text.ToString()))
            {
                MessageBox.Show("Enter Your new Password Please!");
                return false;
            }
            if (String.IsNullOrEmpty(Cnew_pass.Text.ToString()))
            {
                MessageBox.Show("Confirm Your Password Please!");
                return false;
            }


            else
            {
                return true;
            }
        }
        public bool pass_validate()
        {
            var input = new_pass.Text.ToString();




            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one lower case letter.");
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one upper case letter.");
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                MessageBox.Show("Password should not be less than 8 or greater than 15 characters.");
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one numeric value.");
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                MessageBox.Show("Password should contain at least one special case character.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
