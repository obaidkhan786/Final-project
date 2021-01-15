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
    public partial class addroom : Form
    {
        public addroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                    var comm = new SqlCommand();
                    comm.CommandText = "Insert into tblroom (id,roomtype) values(' " + txt_rmno.Text + " ',' " + txt_rmtype.Text + "')";
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

        private void addroom_Load(object sender, EventArgs e)
        {

        }
    }
}
