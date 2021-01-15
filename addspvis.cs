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

namespace WindowsFormsApp8
{
    public partial class addspvis : Form
    {
        public addspvis()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                var comm = new SqlCommand();
                comm.CommandText = "Insert into [user] (id,name,email) values (' " + txt_id.Text + " ',' " + txt_name.Text + "',' " + txt_email.Text + " ')";
                comm.Connection = conn;
                conn.Open();

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Sucessfuly Added");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
