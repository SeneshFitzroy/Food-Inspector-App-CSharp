using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodInspectorApp
{
    public partial class PHI : Form
    {
        public PHI()
        {
            InitializeComponent();
            Reset();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nimesh\Documents\FoodInspectorAppDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void Reset()
        {
            DNameTb.Text = "";
            DAgeTb.Text = "";
            DphoneTb.Text = "";
            DGenCb.SelectedIndex = -1;
            
            DAddressTb.Text = "";
            DivTb.Text = "";
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "" || DphoneTb.Text == "" || DAgeTb.Text == "" || DGenCb.SelectedIndex == -1 || DivTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into PHITbl values('" + DNameTb.Text + "'," + DAgeTb.Text + ",'" + DGenCb.SelectedItem.ToString() + "','" + DphoneTb.Text + "','" + DAddressTb.Text + "','" + DivTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PHI Successfully Saved");
                    Con.Close();
                    Reset();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            Shop patient = new Shop();
            patient.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewShops Vd = new ViewShops();
            Vd.Show();
            this.Hide();
        }


        private void label8_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
