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
    public partial class StaffTypes : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");
        public StaffTypes()
        {
            InitializeComponent();
        }

        private void StaffTypes_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Staff_Types", dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ST = txtST.Text;
            
            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Staff_Types where Staff_Type ='" + ST + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtSTSal.Text = myR["Staff_Fee"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No Staff Type with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void clearAll()
        {
            txtST.Clear();
            txtSTSal.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string StaffType = txtST.Text;
            string StaffSal = txtSTSal.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("insert into Staff_Types values ('"+StaffType+ "','"+StaffSal+"')", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string StaffType = txtST.Text;
            string StaffSal = txtSTSal.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("update Staff_Types set Staff_Fee = '"+StaffSal+"' where Staff_Type = '"+StaffType+"';", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string StaffType = txtST.Text;

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("delete from Staff_Types where Staff_Type = '"+StaffType+"';", con);
                cl.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            Program.showTable(con, "select * from Staff_Types", dataGridView1);

        }

        private void button6_Click(object sender, EventArgs e)
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
