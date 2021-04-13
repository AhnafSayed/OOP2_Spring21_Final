using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_Database1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddCourse(object sender, EventArgs e)
        {
            string c_code = tbCCode.Text;
            string c_name = tbCName.Text;

            string connString = @"Server=rockhouse-ryzen\sqlexpress;Database=GUI_Database;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = string.Format("insert into courses values ('{0}','{1}')", c_code, c_name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            if (r > 0)
            {
                MessageBox.Show("Course Added!");
            }
            else
            {
                MessageBox.Show("Cannot Add Course!");
            }
            conn.Close();
        }
    }
}
