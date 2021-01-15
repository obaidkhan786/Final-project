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
    public partial class addcustomer1 : Form
    {
        private int itableid;
        public addcustomer1(int tableid)
            {
                InitializeComponent();
                itableid = tableid;
            }

        private void addcustomer1_Load(object sender, EventArgs e)
        {

            textBox1.Text = itableid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
         
        {
            {
                try
                {

                    var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                    var comm = new SqlCommand();
                    comm.CommandText = "Insert into customer (name,phoneno) values(' " + textBox3.Text + "',' " + textBox2.Text + "')";
                    comm.Connection = conn;
                    conn.Open();

                    comm.ExecuteNonQuery();
                    conn.Close();

                    comm = new SqlCommand();
                    comm.CommandText = "update [tblroom] set isavailable = 1 where id = '" + itableid.ToString() + "'";
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
        }

        private void addcustomer1_FormClosed(object sender, FormClosedEventArgs e)
        {
            bkroom f2 = new bkroom();
            f2.Show();
            this.Hide();
        }
    }
}
