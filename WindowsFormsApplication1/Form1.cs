using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
           if (UsernameTxtbx.Text == "Admin" && PasswordTxtbx.Text == "Admin123")
           {
               Dashboard ds = new Dashboard("Admin");
               ds.Show();
               this.Hide();
           }
           else
           {
               MessageBox.Show(" Invalid Login Credentials Please Check Username or Password and Try Again ");

           }
        
        
        
        
        
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
