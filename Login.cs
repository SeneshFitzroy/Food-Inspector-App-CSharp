using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FoodInspectorApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Connection string to the SQL Server database
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nimesh\Documents\FoodInspectorAppDB.mdf;Integrated Security=True;Connect Timeout=30");

        // Event handler for the label click to open Admin login
        private void label4_Click(object sender, EventArgs e)
        {
            Adminlogin Adm = new Adminlogin();
            Adm.Show();
            this.Hide();
        }

        // Event handler for the login button click
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the database connection
                Con.Open();

                // SQL command to check if the user exists with the provided credentials
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM EmployeeTbl WHERE EmpId = @EmpId AND EmpPass = @EmpPass", Con))
                {
                    // Add parameters to the SQL command
                    cmd.Parameters.AddWithValue("@EmpId", EmpIdTb.Text);
                    cmd.Parameters.AddWithValue("@EmpPass", EmpPassTb.Text);

                    // Execute the command and get the result
                    int result = (int)cmd.ExecuteScalar();

                    // Check the result to determine if the login is successful
                    if (result == 1)
                    {
                        // If login is successful, show the main form and hide the login form
                        Mainform Main = new Mainform();
                        Main.Show();
                        this.Hide();
                    }
                    else
                    {
                        // If login fails, show an error message
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the database connection is closed
                Con.Close();
            }
        }

        // Event handler for the label click to exit the application
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Event handler for the form load event
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
