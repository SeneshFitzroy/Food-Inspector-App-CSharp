using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodInspectorApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DSF11\SQLEXPRESS;Initial Catalog=FoodInspectorAppDB;Integrated Security=True;Connect Timeout=30");

        private void GetData()
        {
            try
            {
                Con.Open();
                // Add your data retrieval logic here (e.g., query to populate controls)
                MessageBox.Show("Database connected successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // You can add initialization code here if needed
        }

        private void label18_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PHI donor = new PHI();
            donor.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employee Vd = new Employee();
            Vd.Show();
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
            // Add functionality if needed
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Add paint logic if needed
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Add paint logic if needed
        }

        private void label10_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void OPlusNumLbl_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            // Add functionality if needed
        }

        private void label12_Click(object sender, EventArgs e)
        {
            // Add functionality if needed
        }
    }
}
