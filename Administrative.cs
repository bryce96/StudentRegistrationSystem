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
    public partial class Administrative : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        SqlCommand cmd;
        public Administrative()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO RegisterTable VALUES ('" + First_Name.Text + "','" + Last_Name.Text + "','" + Student_ID.Text + "','" + Email.Text + "','" + Classbox.Text + "','" + Additional_Notes.Text + "' )", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            con.Close();
            Clear();
        }

        void Clear()
        {
            First_Name.Text = Last_Name.Text = Student_ID.Text = Email.Text = Classbox.Text = Additional_Notes.Text = ClassSelection.Text = Registrationtxt.Text = "";
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            if (Student_ID.Text == "")
            {
                MessageBox.Show("No Records Available");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM RegisterTable WHERE Student_ID = '" + Student_ID.Text + "'", con);
                cmd.Parameters.AddWithValue("Student_ID", Student_ID.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                GridView2.DataSource = dt;
                con.Close();
                Clear();
            }

        }

        private void Editbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand("UPDATE RegisterTable SET First_Name=@First_Name, Last_Name=@Last_Name, Student_ID=@Student_ID, Email=@Email, Class=@Class, Additional_Notes=@Additional_Notes Where Registration_ID=@Registration_ID", con);
            cmd.Parameters.AddWithValue("First_Name", First_Name.Text);
            cmd.Parameters.AddWithValue("Last_Name", Last_Name.Text);
            cmd.Parameters.AddWithValue("Student_ID", Convert.ToInt32(Student_ID.Text));
            cmd.Parameters.AddWithValue("Email", Email.Text);
            cmd.Parameters.AddWithValue("Class", Classbox.Text);
            cmd.Parameters.AddWithValue("Additional_Notes", Additional_Notes.Text);
            cmd.Parameters.AddWithValue("Registration_ID", Registrationtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been altered");
            con.Close();
            Clear();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand("DELETE FROM RegisterTable WHERE Registration_ID=@Registration_ID", con);
            cmd.Parameters.AddWithValue("Registration_ID", Registrationtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been deleted");
            con.Close();
            Clear();
        }

        private void Sortbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM RegisterTable ", con);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            GridView2.DataSource = dt;
            GridView2.Sort(GridView2.Columns[1], ListSortDirection.Ascending);
            con.Close();
        }

        private void ClassStatsbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM RegisterTable WHERE Class = '" + ClassSelection.Text + "'", con);
            cmd.Parameters.AddWithValue("Class", ClassSelection.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            string TotalCount = Convert.ToString(count);
            StatsOutput.Text = ("There are " + TotalCount + " students in this course.");
            con.Close();
            Clear();
        }

        private void Administrative_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT (Class_Name) FROM ClassTable", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Class_Name", typeof(string));
                dt.Load(reader);
                Classbox.ValueMember = "Class_Name";
                Classbox.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }

            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT (Class_Name) FROM ClassTable", con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Class_Name", typeof(string));
                dt.Load(reader);
                ClassSelection.ValueMember = "Class_Name";
                ClassSelection.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
