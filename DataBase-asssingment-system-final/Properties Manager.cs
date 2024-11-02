﻿using System;
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
    public partial class Properties_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");

        public Properties_Manager()
        {
            InitializeComponent();
        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            string propertyid = text_propertyid.Text;

            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("Select * from Property where Property_ID ='" + propertyid + "'", con);

                SqlDataReader myrecord = cmd.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {

                        text_propertyname.Text = myrecord["Property_Name"].ToString();
                        cbx_propertytype.Text = myrecord["Property_Type"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No record from this Property ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearall();
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
            string propID = text_propertyid.Text;
            string propertyname = text_propertyname.Text;
            string propertytype = cbx_propertytype.SelectedItem.ToString();


            SqlCommand cmd = null;
            cmd = new SqlCommand("insert into Property(Property_ID,Property_Name,Property_Type) values ('"+propID+"','" + propertyname + "','" + propertytype + "')", con);

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
            Program.showTable(con, "select * from Property", dgvPropertiesManager);
        }

        private void bttn_Update_Click(object sender, EventArgs e)
        {
            //Get the textbox content into a variable
            string propertyname = text_propertyname.Text;
            string propertytype = cbx_propertytype.SelectedItem.ToString();
            string propertyid = text_propertyid.Text;

            SqlCommand cmd = null;
            cmd = new SqlCommand("update Property set Property_Name ='" + propertyname + "', Property_Type='" + propertytype + "' where Property_ID='" + propertyid + "'", con);

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
            Program.showTable(con, "select * from Property", dgvPropertiesManager);
        }

        private void bttn_Delete_Click(object sender, EventArgs e)
        {
            string propertyid = text_propertyid.Text;

            try
            {

                con.Open();
               
                SqlCommand cmd = new SqlCommand("Delete from Property where Property_ID = '" + propertyid + "' ", con);
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
            Program.showTable(con, "select * from Property", dgvPropertiesManager);
        }

        private void bttn_Clearall_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
            text_propertyid.Text = "";
            text_propertyname.Text = "";
            cbx_propertytype.Text = "";
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

        private void text_propertyid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Properties_Manager_Load(object sender, EventArgs e)
        {
            Program.showTable(con, "select * from Property", dgvPropertiesManager);
        }
    }
}
