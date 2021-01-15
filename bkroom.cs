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
    public partial class bkroom : Form
    {
        public bkroom()
        {
            InitializeComponent();
        }

        private void bkroom_Load(object sender, EventArgs e)
        {
            try
            {
                
                var conn = new SqlConnection("Data Source=DESKTOP-G9FGO99;Initial Catalog=labfinal;Integrated Security=True");
                var comm = new SqlCommand("Select id,roomtype from [tblroom] where isavailable = 0 or isavailable is null", conn);

                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                var dataTable = new DataTable();
                dataTable.Load(reader);

                //while (reader.Read())
                //{
                //    avail_rooms.Items.Add(reader["id"]);

                //}

                grid_tables.DataSource = dataTable;
                grid_tables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                btn_bkrm.Enabled = false;
                conn.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btn_bkrm_Click(object sender, EventArgs e)
        {
            
            {

                var i = Convert.ToInt32(grid_tables.SelectedRows[0].Cells[0].Value);
               
                addcustomer1 ac = new addcustomer1(i);
                // ac.MdiParent = this;
                ac.Show();
                this.Close();
                // this.Hide();
            }
           

        }

        private void button1_Click(object sender, EventArgs e) { }

        //    {
        //        Form2 f2 = new Form2();
        //        f2.Show();
        //        this.Hide();
        //    }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            spPannal f2 = new spPannal();
            f2.Show();
            this.Hide();
        }

        private void bkroom_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

        private void grid_tables_SelectionChanged(object sender, EventArgs e)
        {
            btn_bkrm.Enabled = true;
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            spPannal f2 = new spPannal();
            f2.Show();
            this.Hide();
        }

        private void grid_tables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
