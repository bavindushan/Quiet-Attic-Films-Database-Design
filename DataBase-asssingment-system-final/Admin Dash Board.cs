using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_asssingment
{
    public partial class Admin_Dash_Board : Form
    {
        public Admin_Dash_Board()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clients_Manager c = new  Clients_Manager();
            c.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Production_Manager p = new Production_Manager();
            p.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties_Manager p = new Properties_Manager();
            p.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Location_Manager l = new Location_Manager();
            l.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Staff_Manager s = new Staff_Manager();
            s.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clients_Manager a = new Clients_Manager();
            a.Show();
            Hide();
        }

        private void bttn_Back_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            user_Account_Manager l = new user_Account_Manager();
            l.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffTypes l = new StaffTypes();
            l.Show();
            Hide();
        }
    }
}
