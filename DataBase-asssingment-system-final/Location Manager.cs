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
    public partial class Location_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");

        public Location_Manager()
        {
            InitializeComponent();
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string lid = text_locationid.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Select * from Location where Location_ID ='" + lid + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {

                        text_locationname.Text = myR["Location_Name"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this Location ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void bttn_Add_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locationname = text_locationname.Text;
            string locationID = text_locationid.Text;




            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Location(Location_ID,Location_Name) values ('"+ locationID + "','" + locationname + "')", con);

            try
            {
                con.Open();
               
                cmd.ExecuteNonQuery();

                con.Close();
               

                MessageBox.Show(" Added Successfully!", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clearall();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Location", dataGridView1);
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locationid = text_locationid.Text;
            string locationname = text_locationname.Text;


            SqlCommand cmd = null;
            cmd = new SqlCommand("update Location set Location_Name='" + locationname + "' where Location_ID ='" + locationid + "'", con);

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
            Program.showTable(con, "select * from Location", dataGridView1);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string locationid = text_locationid.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Delete from Location where Location_ID = '" + locationid + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
               


                MessageBox.Show(" Deleted Successfully !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
                
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Location", dataGridView1);
        }

        private void bttn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall() 
        {
            text_locationid.Text = "";
            text_locationname.Text = "";
        }

        private void Location_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Location", dataGridView1);

        }

        private void btn_Back_Click(object sender, EventArgs e)
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
