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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(Helper.c);
        SqlDataAdapter da;

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataDataSet.Emp' table. You can move, or remove it, as needed.
           // this.empTableAdapter.Fill(this.myDataDataSet.Emp);

             da = new SqlDataAdapter("select * from emp", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "Emp");
            dataGridView1.DataSource = ds.Tables[0];
            SqlCommand cmdInsert = new SqlCommand("Insert into emp values(@p1,@p2)", con);


            SqlParameter pname = cmdInsert.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            pname.SourceColumn = "Name";
            pname.SourceVersion = DataRowVersion.Current;

            SqlParameter psal = cmdInsert.Parameters.Add("@p2", SqlDbType.Int);
            pname.SourceColumn = "Salary";
            psal.SourceVersion = DataRowVersion.Current;

            da.InsertCommand = cmdInsert;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            da.Update(ds, "Emp");
            SqlCommand cmdUpdate = new SqlCommand("Update emp set Name = @p1, Salary = @p2 where ID = @p3", con);

            SqlParameter upName = cmdUpdate.Parameters.Add("@p1", SqlDbType.VarChar, 50);
            SqlParameter upSalary = cmdUpdate.Parameters.Add("@p2", SqlDbType.Int);
            SqlParameter upID = cmdUpdate.Parameters.Add("p3", SqlDbType.Int);


            upName.SourceColumn = "Name";
            upName.SourceVersion = DataRowVersion.Current;

            upSalary.SourceColumn = "Salary";
            upSalary.SourceVersion = DataRowVersion.Current;

            upID.SourceColumn = "ID";
            upID.SourceVersion = DataRowVersion.Original;

            da.UpdateCommand = cmdUpdate;

            
        }
    }
}
