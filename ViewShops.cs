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
    public partial class ViewShops : Form
    {
        public ViewShops()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nimesh\Documents\FoodInspectorAppDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void Populate()
        {
            /*Con.Open();
            string Query = "select = Form PatientTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientDGV.DataSource = ds.Tables[0];
            Con.Close();*/
        }
        private void ViewPatients_Load(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void PatientDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text = PatientDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientDGV.SelectedRows[0].Cells[2].Value.ToString();
            PPhoneTb.Text = PatientDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientDGV.SelectedRows[0].Cells[6].Value.ToString();
            if(PNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PatientDGV.SelectedRows[0].Cells[1].Value.ToString());
            }
        }

        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
            key = 0;
        }

        private void PDeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Patient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTbl where PNum" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted");
                    Con.Close();
                    Reset();
                    Populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewShops VP = new ViewShops();
            VP.Show();
            this.Hide();
        }

        private void PEditBtn_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "update ShopTbl set PName = '" + PNameTb.Text + "',Page= " + PAgeTb.Text + ",PPhone='" + PPhoneTb.Text + "' ,PGender='" + PGenCb.SelectedItem.ToString() + "' ,PBGroup='" + PBGroupCb.SelectedItem.ToString() + "' ,PAddress= '" + PAddressTb.Text + "' where PNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated");
                    Con.Close();
                    Reset();
                    Populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PHI donor = new PHI();
            donor.Show();
            this.Hide();
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

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void label7_Click(object sender, EventArgs e)
        {
           
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

        private void PatientDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
