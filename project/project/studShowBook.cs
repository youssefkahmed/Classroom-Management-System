using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace project
{
    public partial class studShowBook : UserControl
    {
        public string link; 
        public studShowBook()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link);
        }

        private void studShowBook_Load(object sender, EventArgs e)
        {

        }
        public void c_id(int id)
        {
            cid.Text = id.ToString();
        }
        public void book_name(string name)
        {
            n.Text = name;
        }
        public void author(string aut)
        {
            a.Text = aut;
        }
    }
}
