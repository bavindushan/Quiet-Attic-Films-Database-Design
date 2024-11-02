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

namespace DataBase_asssingment
{
    public partial class user_Account_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");

        public user_Account_Manager()
        {
            InitializeComponent();
        }

        private void user_Account_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Login", dgvUserAccounts);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string user = txtUserID.Text;
            try
            {
                con.Open();


                SqlCommand cmd = new SqlCommand("Select * from Login where userID ='" + user + "'", con);

                SqlDataReader myrecords = cmd.ExecuteReader();
                if (myrecords.HasRows)
                {
                    while (myrecords.Read())
                    {
                        txtPassword.Text = myrecords["psw"].ToString();
                        txtUsername.Text = myrecords["username"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this User ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string uid = txtUserID.Text;


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Login(userID,username,psw) values ('"+uid+"','" + username + "','" + password + "')", con);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show(" Added Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clearall();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Login", dgvUserAccounts);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string uid = txtUserID.Text;
            

            SqlCommand cmd = null;
            cmd = new SqlCommand("update Login set username ='" + username + "', psw='" + password + "' where userID = '"+uid+"';", con);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show(" Updated Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Login", dgvUserAccounts);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string user = txtUserID.Text;

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Delete from Login where userID = '" + user + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();



                MessageBox.Show("Deleted Successfully !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clearall();

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Login", dgvUserAccounts);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUserID.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (Login.accountLevel == "admin")
            {
                Admin_Dash_Board s = new Admin_Dash_Board();
                s.Show();
                Hide();
            }
            else
            {
                staff_dashboard s = new staff_dashboard();
                s.Show();
                Hide();
            }
        }
    }
}
