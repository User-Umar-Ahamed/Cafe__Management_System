using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.AllUserControl
{
    public partial class UC_Additems : UserControl
    {
        Function fn = new Function();
        String query;

        public UC_Additems()
        {
            InitializeComponent();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Additems_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            query = "insert into items (name,Category,price) values ('" + TxtItemName.Text + "','" + TxtCatergory.Text + "',"+TxtPrice.Text+")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            TxtCatergory.SelectedIndex = -1;
            TxtItemName.Clear();
            TxtPrice.Clear();
        }
    
        private void UC_Additems_Leave_1(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
