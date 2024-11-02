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
    public partial class Clients_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");
        public Clients_Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clientid = text_ClientID.Text;
            try
            {
                con.Open();
               

                SqlCommand cmd = new SqlCommand("Select * from Client where Client_ID ='" + clientid + "'", con);

                SqlDataReader myrecords = cmd.ExecuteReader();
                if (myrecords.HasRows)
                {
                    while (myrecords.Read())
                    {
                        text_ClientName.Text = myrecords["Client_Name"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this Client ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            //Get the textbox content into a variable
            string clientname = text_ClientName.Text;
            string clientid = text_ClientID.Text;

            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Client(Client_ID, Client_Name) values ('"+ clientid + "','" + clientname + "')", con);

            try
            {
                con.Open();
                
                cmd.ExecuteNonQuery();

                con.Close();
           
                clearall();
                MessageBox.Show(" Added Successfully !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dataGridView1);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string clientid = text_ClientID.Text;
            string clientname = text_ClientName.Text;




            SqlCommand cmd = null;
            cmd = new SqlCommand("update Client set Client_Name = '" + clientname + "' where Client_ID ='" + clientid + "'", con);

            try
            {
                con.Open();
               
                cmd.ExecuteNonQuery();

                con.Close();
                
                clearall();
                MessageBox.Show(" Updated Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dataGridView1);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string clientid = text_ClientID.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Delete from Client where Client_ID = '" + clientid + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
                

                clearall();
                MessageBox.Show("Successfully Deleted", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Client", dataGridView1);
        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            text_ClientName.Text = "";
            text_ClientID.Text = "";
        }

       
        private void Clients_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con,"select * from Client",dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
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
