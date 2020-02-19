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
    public partial class SqlConn : Form
    {
        public SqlConn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Server=SAIRAMSAGAR\\SAIRAMSAGAR;database = MyData;Integrated Security = true";
            con.ConnectionString = Helper.c;
            con.Open();
            //bind sql command into conection object and we need to pass sqlcommand
            //SqlCommand cmd = new SqlCommand("insert into Employee values('samanth',8000)", con);
            //SqlCommand cmd = new SqlCommand("update Employee set EmpName='Lakshman Samanth' where EmpId=4",con);
            //SqlCommand cmd = new SqlCommand("Delete from Employee where EmpId=5", con);
            //SqlCommand cmd = new SqlCommand("insert into employee values('" + txtName.Text + "'," + txtSalary.Text + ")", con);
            SqlCommand cmd = new SqlCommand("update Employee set EmpSal=" + txtSalary.Text + " where EmpName='" + txtName.Text + "'", con);

            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>0)
            {
                MessageBox.Show("Success update");

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Server = SAIRAMSAGAR; database = MyData; Integrated Security = true";
            con.ConnectionString = Helper.c;
            con.Open();
            MessageBox.Show("Bayern");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
