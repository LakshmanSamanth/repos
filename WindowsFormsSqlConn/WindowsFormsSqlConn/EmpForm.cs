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
    public partial class EmpForm : Form
    {
        public EmpForm()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Helper.c);
            //SqlCommand cmd = new SqlCommand("Insert into emp values(@p1,@p2)", con);

            //Type ONE:
            //SqlParameter pname = new SqlParameter("@p1", SqlDbType.VarChar, 50);
            //pname.Value = txtName.Text;
            //cmd.Parameters.Add(pname);
            //SqlParameter psalary = new SqlParameter("@p2", SqlDbType.Int);
            //psalary.Value = txtSalary.Text;
            //cmd.Parameters.Add(psalary);


            //Type TWO
            //SqlParameter pname = cmd.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            //pname.Value = txtName.Text;

            //SqlParameter psalary = cmd.Parameters.Add("@p2", SqlDbType.Int);
            //psalary.Value = txtSalary.Text;

            //Type THREE
            //cmd.Parameters.AddWithValue("@p1", txtName.Text);
            //cmd.Parameters.AddWithValue("@p2", txtSalary.Text);

            //Stored Procedures
            //SqlCommand cmd = new SqlCommand("insertdata", con);
            //cmd.CommandType = CommandType.StoredProcedure; // Why???

            //SqlParameter pname = cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50);
            //pname.Value = txtName.Text;

            //SqlParameter psalary = cmd.Parameters.Add("@Salary", SqlDbType.Int);
            //psalary.Value = txtSalary.Text;


            //Stored procedure for Select Statement
            SqlCommand cmd = new SqlCommand("selectdata", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter pname = cmd.Parameters.Add("@Name", SqlDbType.VarChar, 50);
            pname.Direction = ParameterDirection.Output;
            SqlParameter psalary = cmd.Parameters.Add("@Salary", SqlDbType.Int);
            psalary.Value = txtSalary.Text;

            







            /////////////////////////
            con.Open();
            //int i = cmd.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    MessageBox.Show("Inserted");
            //}

            SqlDataReader dr = cmd.ExecuteReader();   
            string str = "";
            while (dr.Read())
            {
                str += dr["ID"] + "\t";
                str += dr["Name"] + "\t";
                str += dr["Salary"] + "\n";
            }
            MessageBox.Show(str);
            con.Close();


        }
    }
}
