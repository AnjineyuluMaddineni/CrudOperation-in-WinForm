using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudOperation_in_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string empid = textBox1.Text.ToString();
            string empname = textBox2.Text.ToString();
            int empage = int.Parse(textBox3.Text);
            string insertQuery = "insert into EmployeeList(EmpID,EmpName,EmpAge) values('" + empid + "','" + empname + "','" + empage + "')";
            SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConn);
            insertCommand.ExecuteNonQuery();
            //Step 3: Dispose the SqlCommand and close the SqlConnection
            insertCommand.Dispose();
            sqlConn.Close();
            label4.Text = "Inserted successfully";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string empid = textBox1.Text.ToString();
            string empname = textBox2.Text.ToString();
            //int empage = int.Parse(textBox3.Text);
            string updateQuery = "Update EmployeeList set EmpName='" + empname +"' where EmpID='" + empid + "'";
            SqlCommand updatecommand = new SqlCommand(updateQuery, sqlConn);
            updatecommand.ExecuteNonQuery();
            //Step 3:Dispose SqlCommand and close the connection

            updatecommand.Dispose();
            sqlConn.Close();
            label5.Text = "Updated Successfully";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string empid = textBox1.Text.ToString();
            string deletequery = "Delete from EmployeeList where EmpID='" +empid+"'";
            SqlCommand Deletecommand = new SqlCommand(deletequery, sqlConn);
           Deletecommand.ExecuteNonQuery();
            //Step 3:Dispose SqlCommand and close the connection

            Deletecommand.Dispose();
            sqlConn.Close();
            label6.Text = "Deleted Successfully";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connString = "Data source=Anji\\SQLEXPRESS; Initial catalog=chandu;User ID=sa;Password=12345";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();
            //Step 2:Execute insertCommand by passing insertQuery
            string selectQuery = "select* from EmployeeList";
            SqlCommand selectCommand = new SqlCommand(selectQuery, sqlConn);
            SqlDataAdapter sda = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            sqlConn.Close();
            dataGridView1.DataSource = dt;
            label7.Text = "Slected Successfully";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
