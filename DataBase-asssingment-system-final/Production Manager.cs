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
using static System.Windows.Forms.AxHost;

namespace DataBase_asssingment
{
    public partial class Production_Manager : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-GELPRRQ;Initial Catalog='Quiet Attic Films';Integrated Security=True");

        public Production_Manager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttn_Search_Click(object sender, EventArgs e)
        {
            // setting vars
            string productionid = txtproductionid.Text;
            string clId = "";
          

            // getting production name to textbox

            try
            {

                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from Production join Client on Production.Client_ID = Client.Client_ID where Production_ID ='" + productionid + "'", con);

                SqlDataReader myR = cmd.ExecuteReader();
                if (myR.HasRows)
                {
                    while (myR.Read())
                    {
                        txtproductionname.Text = myR["Production_Name"].ToString();
                        //clId = myR["Client_ID"].ToString();
                        cmbClientName.SelectedItem = myR["Client_Name"];
                        cmbProdType.SelectedItem = myR["Production_Type"];
                        startdtp.Value = DateTime.Parse(myR["Start_Date"].ToString());
                        enddtp.Value = DateTime.Parse(myR["End_Date"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, No Production with this ID !", "No Records !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txtproductionname.Text != "" && txtproductionname.Text != "")
            {
                // getting textbox text to vars
                string productionid = txtproductionid.Text;
                string productionname = txtproductionname.Text;
                string productionClient = cmbClientName.SelectedItem.ToString();
                string stratdate = startdtp.Value.ToString("yyyy-MM-dd");
                string enddate = enddtp.Value.ToString("yyyy-MM-dd");
                string productiontype = cmbProdType.SelectedItem.ToString();

                // inserting data
                SqlCommand cmd = null;
                cmd = new SqlCommand("insert into Production (Production_ID, Production_Name,Client_ID,Start_Date,End_Date,Production_Type) values ('"+ productionid + "','" + productionname + "',(select Client_ID from Client where Client_Name = '"+ productionClient + "'),'" + stratdate + "','" + enddate + "','"+productiontype+"')", con);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("Successfully Added !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                Clearall();
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Please fill all the input fields !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txtproductionid.Text != ""  && txtproductionname.Text != "")
            {
                //MessageBox.Show(cmbClientName.SelectedItem.ToString());
                

                //Get the textbox content into a variable
                string productionid = txtproductionid.Text;
                string productionname = txtproductionname.Text;
                string clientname = cmbClientName.SelectedItem.ToString();
                string startdate = startdtp.Value.ToString("yyyy-MM-dd");
                string enddate = enddtp.Value.ToString("yyyy-MM-dd");
                string productiontype = cmbProdType.SelectedItem.ToString();

                SqlCommand cmd = null;
                cmd = new SqlCommand("update Production set Production_Name = '" + productionname + "', Client_ID = (select Client_ID from Client where Client_Name = '"+clientname+"'), Start_Date='" + startdate + "', End_Date='" + enddate + "', Production_Type = '"+productiontype+"' where Production_Id='" + productionid + "'", con);

                try
                {
                    con.Open();

                    cmd.ExecuteNonQuery();

                    con.Close();


                    MessageBox.Show("Successfully Updated !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Please fill all the input fields !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txtproductionid.Text != "")
            {
                string productionid =txtproductionid.Text;


                try
                {

                    con.Open();

                    SqlCommand cmd = new SqlCommand("Delete from Production where Production_ID = '" + productionid + "' ", con);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Successfully Deleted !", "Success !", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                    con.Close();
                }
                Clearall();
                Program.showTable(con, "select * from Production", dataGridView1);
            }
            else
            {
                MessageBox.Show("Please provide the Production ID !", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();

        }

        private void btn_Clearall_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            txtproductionid.Text = "";
            
            txtproductionname.Text = "";
            startdtp.Value = DateTime.Today;
            enddtp.Value = DateTime.Today;
        }

        private void Production_Manager_Load(object sender, EventArgs e)
        {
            // load clients
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select * from Client", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cmbClientName.Items.Add(myrecord["Client_Name"]);
                    }
                }
                else
                {
                    MessageBox.Show("Client Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
            // asign Production cmbs
            loadProdCmbs();
            // load dgvs
            loadDgvs();
            // load locations
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("SELECT Location_Name FROM Location", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    cmbLocPP.Items.Clear();
                    while (myrecord.Read())
                    {
                        cmbLocPP.Items.Add(myrecord["Location_Name"]);
                    }
                }
                else
                {
                    MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void loadProdCmbs()
        {
            cmbProdPS.Items.Clear();
            cmbProdPP.Items.Clear();
            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select * from Production", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        cmbProdPS.Items.Add(myrecord["Production_Name"]);
                        cmbProdPP.Items.Add(myrecord["Production_Name"]);
                    }
                }
                else
                {
                    MessageBox.Show("Production Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }
        }

        private void loadDgvs()
        {
            Program.showTable(con, "select Production_ID , Production_Name, Client_Name , Start_Date , End_Date , Production_Type from Production join Client on Production.Client_ID = Client.Client_ID;", dataGridView1);
            Program.showTable(con, "SELECT Production_Name, Property_Name, Location_Name FROM Production_Property_Location JOIN Production ON Production_Property_Location.Production_ID = Production.Production_ID JOIN Property ON Production_Property_Location.Property_ID = Property.Property_ID JOIN Location ON Production_Property_Location.Location_ID = Location.Location_ID ORDER BY Production_Name ASC;", dataGridView2);
            Program.showTable(con, "SELECT Production_Name, Staff_Name, Staff_Type FROM Production_Staff JOIN Production ON Production_Staff.Production_ID = Production.Production_ID JOIN Staff ON Production_Staff.Staff_ID = Staff.Staff_ID ORDER BY Production_Name ASC;", dataGridView3);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void cmbProdPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdPS.SelectedIndex != -1)
            {
                string selProd = cmbProdPS.SelectedItem.ToString();

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("SELECT Staff_Name FROM Staff WHERE Staff_ID NOT IN (SELECT s.Staff_ID FROM Production_Staff ps JOIN Staff s ON ps.Staff_ID = s.Staff_ID WHERE ps.Production_ID = (select Production_ID from Production where Production_Name = '" + selProd + "'));", con);
                    SqlDataReader myrecord = cl.ExecuteReader();
                    if (myrecord.HasRows)
                    {
                        cmbStaffPS.Items.Clear();
                        while (myrecord.Read())
                        {
                            cmbStaffPS.Items.Add(myrecord["Staff_Name"]);
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
        }

        private void cmbProdPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProdPP.SelectedIndex != -1)
            {
                string selProd = cmbProdPP.SelectedItem.ToString();

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("SELECT Property_Name FROM Property WHERE Property_ID NOT IN (SELECT s.Property_ID FROM Production_Property_Location ps JOIN Property s ON ps.Property_ID = s.Property_ID WHERE ps.Production_ID = (select Production_ID from Production where Production_Name = '" + selProd + "'));", con);
                    SqlDataReader myrecord = cl.ExecuteReader();
                    if (myrecord.HasRows)
                    {
                        cmbPropPP.Items.Clear();
                        while (myrecord.Read())
                        {
                            cmbPropPP.Items.Add(myrecord["Property_Name"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to assign this Staff member?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            // inputs
            string selProd = cmbProdPS.SelectedItem.ToString();
            string selStaff = cmbStaffPS.SelectedItem.ToString();

            if (DialogResult == DialogResult.Yes && selProd != "" && selStaff != "")
            {

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("insert into Production_Staff values ((select Production_ID from Production where Production_Name = '" + selProd + "'),(select Staff_ID from Staff where Staff_Name = '" + selStaff + "'));", con);
                    cl.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
                // load dgvs
                loadDgvs();

                // clear selections in cmbs
                cmbProdPS.SelectedIndex = -1;
                cmbStaffPS.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Are you sure to assign this Property and Location?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            string selProd = cmbProdPP.SelectedItem.ToString();
            string selProp = cmbPropPP.SelectedItem.ToString();
            string selLoc = cmbLocPP.SelectedItem.ToString();

            if (DialogResult == DialogResult.Yes && selProd != "" && selProp != "" && selLoc != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("insert into Production_Property_Location values ((select Production_ID from Production where Production_Name = '"+selProd+"'),(select Property_ID from Property where Property_Name = '"+selProp+"'),(select Location_ID from Location where Location_Name = '"+selLoc+"'))", con);
                    cl.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Success!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
            // load dgvs
            loadDgvs();
            // clear cmbs
            cmbProdPP.SelectedIndex = -1;
            cmbPropPP.Items.Clear();
            //cmbLocPP.Items.Clear();
        }

        private void cmbPropPP_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cmbPropPP.SelectedIndex != -1)
            {
                string selProp = cmbPropPP.SelectedItem.ToString();

                try
                {
                    con.Open();
                    SqlCommand cl = null;
                    cl = new SqlCommand("SELECT Location_Name FROM Location WHERE Location_ID NOT IN (SELECT s.Location_ID FROM Production_Property_Location ps JOIN Location s ON ps.Location_ID = s.Location_ID WHERE ps.Location_ID = (select Location_ID from Location where Location_Name = '"+selProp+"'));", con);
                    SqlDataReader myrecord = cl.ExecuteReader();
                    if (myrecord.HasRows)
                    {
                        cmbPropPP.Items.Clear();
                        while (myrecord.Read())
                        {
                            cmbLocPP.Items.Add(myrecord["Location_Name"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                    con.Close();
                }
            }
            */

        }

        private void cmbStaffPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = "Staff";
            string staffName = cmbStaffPS.SelectedItem.ToString();

            try
            {
                con.Open();
                SqlCommand cl = null;
                cl = new SqlCommand("select Staff_Type from Staff where Staff_Name = '"+staffName+"';", con);
                SqlDataReader myrecord = cl.ExecuteReader();
                if (myrecord.HasRows)
                {
                    while (myrecord.Read())
                    {
                        label8.Text += " / " + myrecord["Staff_Type"].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Table Empty !", "Empty Table !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                con.Close();
            }

        }
    }
}
