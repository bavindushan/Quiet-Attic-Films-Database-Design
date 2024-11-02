using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase_asssingment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static void showTable(SqlConnection con, string qry, DataGridView dgv)
        {
            // set show table record
            SqlDataAdapter adapt = new SqlDataAdapter(qry, con);

            DataSet ds = new DataSet();

            // fill dataset
            adapt.Fill(ds);

            // create object variable
            object dv = ds.Tables[0];

            // pass to form
            dgv.DataSource = dv;
        }
    }
}
