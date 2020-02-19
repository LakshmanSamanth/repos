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

namespace WindowsFormsSqlConn
{
    public partial class DisconnDeleteGV : Form
    {
        public DisconnDeleteGV()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(Helper.c);
        SqlDataAdapter da;

        private void DisconnDeleteGV_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from emp", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "emp");
            dataGridView1.DataSource = ds.Tables[0];



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
