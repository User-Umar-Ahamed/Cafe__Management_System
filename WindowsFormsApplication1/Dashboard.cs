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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();

            if(user=="Guest")
            {
                Additembtn.Hide();
                UpdateItemsBtn.Hide();
                RemoveitemsBtn.Hide();
            }
            else if (user == "Admin")
            {
                Additembtn.Show();
                UpdateItemsBtn.Show();
                RemoveitemsBtn.Show();
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_Additems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItems1.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logoutlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void Additembtn_Click(object sender, EventArgs e)
        {
            uC_Additems1.Visible = true;
            uC_Additems1.BringToFront();
        }

        private void PlaceOrderBtn_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void UpdateItemsBtn_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
        }

        private void RemoveitemsBtn_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
        }

        private void uC_RemoveItems1_Load(object sender, EventArgs e)
        {

        }
    }
}
