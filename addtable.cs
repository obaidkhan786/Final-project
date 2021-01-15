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
    public partial class addtable : Form
    {
        public addtable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                var comm = new SqlCommand();
                comm.CommandText = "Insert into tables (id,seatno) values(' " + txt_tblno.Text + " ',' " + txt_tblcap.Text + "')";
                comm.Connection = conn;
                conn.Open();

                comm.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Sucessfuly Inserted");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
    }
}       
