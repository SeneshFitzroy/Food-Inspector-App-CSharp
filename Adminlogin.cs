using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodInspectorApp
{
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter the Admin Password");
            }
            else if(AdminPassTb.Text == "Password")
            {
                AdminForm Emp = new AdminForm();
                Emp.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("Wrong Password.Contact the System Admin");
                AdminPassTb.Text = "";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
