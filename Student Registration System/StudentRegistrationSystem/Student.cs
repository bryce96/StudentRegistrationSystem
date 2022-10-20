using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentRegistrationSystem
{
    public partial class Student : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        SqlCommand cmd;
        public Student()
        {
            InitializeComponent();
        }

        private void RecordSearchbtn_Click(object sender, EventArgs e)
        {
            
            if (IDtxt.Text == "")
            {
                MessageBox.Show("No Records Availible");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM RegisterTable WHERE Student_ID = '" + IDtxt.Text + "'", con);
                cmd.Parameters.AddWithValue("Student_ID", IDtxt.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                GridView3.DataSource = dt;
                con.Close();
                Clear();
            }

            void Clear()
            {
                IDtxt.Text = "";
            }
        }

        private void PrintRecordbtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printStudentRecords;
            printDialog.UseEXDialog = true;

            if (DialogResult.OK == printDialog.ShowDialog())
            {
                printStudentRecords.DocumentName = "Student Record";
                printStudentRecords.Print();
            }
        }

        private void Calcbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT RegisterTable.Student_ID, ClassTable.Class_Name, ClassTable.Class_Cost FROM RegisterTable INNER JOIN ClassTable ON RegisterTable.Class = ClassTable.Class_Name WHERE Student_ID= '" + IDtxt.Text+ "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView3.DataSource = dt;
            con.Close();

            int totalCost = 0;
            for (int i = 0; i < GridView3.Rows.Count; ++i)
            {
                totalCost += Convert.ToInt32(GridView3.Rows[i].Cells[2].Value);
            }

            OptionsOutput.Text = ("Your total cost for this semester is $" + totalCost);
            Clear();
        }

        void Clear()
        {
            IDtxt.Text = "";
        }

        private void CreditHours_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT RegisterTable.Student_ID, ClassTable.Class_Name, ClassTable.Credit_Hours FROM RegisterTable INNER JOIN ClassTable ON RegisterTable.Class = ClassTable.Class_Name WHERE Student_ID= '" + IDtxt.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView3.DataSource = dt;
            con.Close();

            int totalHours = 0;
            for (int i = 0; i < GridView3.Rows.Count; ++i)
            {
                totalHours += Convert.ToInt32(GridView3.Rows[i].Cells[2].Value);
            }

            OptionsOutput.Text = ("Your total number of credit hours for this semester is " + totalHours);
            Clear();
        }
    }
}
