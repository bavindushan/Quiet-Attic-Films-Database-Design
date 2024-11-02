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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");
        // which account level
        public static string accountLevel;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string acname = txtUserName.Text;
            string acpsw = txtPassword.Text;
            bool foundMatch = false;

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Login;", con);
                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        string userName = myR["username"].ToString();
                        string password = myR["psw"].ToString();

                        if (userName == acname && password == acpsw)

                        {
                            foundMatch = true;
                            if (userName == "admin")
                            {
                                // grant permission for admin
                                Admin_Dash_Board d = new Admin_Dash_Board();
                                d.Show();
                                Hide();
                                accountLevel = "admin";

                            }
                            else
                            {
                                // grant permission for staff
                                staff_dashboard d = new staff_dashboard();
                                d.Show();
                                Hide();
                                accountLevel = "staff";
                            }
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No User Accounts Available !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (!foundMatch)
                {
                    // display error message
                    MessageBox.Show("Wrong Account Credentials !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
