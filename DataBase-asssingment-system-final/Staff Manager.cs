using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_asssingment
{
    public partial class Staff_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");

        public Staff_Manager()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string staffid = txt_staffid.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Select * from Staff where Staff_ID ='" + staffid + "'", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {

                        txt_Staffname.Text = myrecord["Staff_Name"].ToString();
                        cbx_Stafftype.Text = myrecord["Staff_Type"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Staff Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string staffID = txt_staffid.Text;
            string staffname = txt_Staffname.Text;
            string stafftype = cbx_Stafftype.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Staff(Staff_ID,Staff_Name,Staff_Type) values ('"+staffID+"','" + staffname + "','" + stafftype + "')", con);

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
            Program.showTable(con, "select * from Staff", dataGridView1);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string staffid = txt_staffid.Text;
            string staffname = txt_Staffname.Text;
            string stafftype = cbx_Stafftype.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("update Staff set Staff_Name='" + staffname + "', Staff_Type='" + stafftype + "' where Staff_ID='" + staffid + "'", con);

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
            Program.showTable(con, "select * from Staff", dataGridView1);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string staffid = txt_staffid.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Delete from Staff where Staff_ID = '" + staffid + "' ", con);
                cmd.ExecuteNonQuery();

                con.Close();
                


                MessageBox.Show("Deleted Successfully !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearall();
               
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.Message);
                con.Close();
            }
            Program.showTable(con, "select * from Staff", dataGridView1);
        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            txt_staffid.Text = "";
            txt_Staffname.Text = "";
            cbx_Stafftype.Text = "";
        }

        private void Staff_Manager_Load(object sender, EventArgs e)
        {
            
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Staff_Types;", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cbx_Stafftype.Items.Add(myrecord["Staff_Type"].ToString());

                    }
                }
                else
                {
                    MessageBox.Show("Staff Types Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            
            Program.showTable(con, "select * from Staff", dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
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
