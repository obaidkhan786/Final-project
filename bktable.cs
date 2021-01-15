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
    public partial class addcostumer : Form
    {
        private int itableid;
        public addcostumer(int tableid)
        {
            InitializeComponent();
            itableid = tableid;
        }

        private void addcostumer_Load(object sender, EventArgs e)
        {
            textBox1.Text = itableid.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                var comm = new SqlCommand();
                comm.CommandText = "Insert into customer (name) values(' " + textBox3.Text + "')";
                comm.Connection = conn;
                conn.Open();

                comm.ExecuteNonQuery();
                conn.Close();

                comm = new SqlCommand();
                comm.CommandText = "update [tables] set isavalible = 1 where id = " + itableid.ToString();
                comm.Connection = conn;
                conn.Open();

                comm.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Added Sucessfully");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void addcostumer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Supervisorpanal sp = new Supervisorpanal();
            sp.Show();

        }
    }
}
