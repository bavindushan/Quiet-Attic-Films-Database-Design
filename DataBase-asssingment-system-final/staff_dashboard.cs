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
    public partial class staff_dashboard : Form
    {
        public staff_dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            Clients_Manager a = new Clients_Manager();
            a.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Production_Manager p = new Production_Manager();
            p.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clients_Manager c = new Clients_Manager();
            c.Show();
            Hide();
        }
    }
}
