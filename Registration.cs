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
    public partial class Registration : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        SqlCommand cmd;
        
        public Registration()
        {
            InitializeComponent();
        }

        private void NewRecordbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("INSERT INTO RegisterTable VALUES ('"+FnametextBox.Text+"','"+LnametextBox.Text+"','"+IDtextBox.Text+"','"+EmailtextBox.Text+"','"+ClassOptions.Text+"','"+AdditionalNotestextBox.Text+"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved");
            con.Close();
            Clear();
        }

        void Clear()
        {
            FnametextBox.Text = LnametextBox.Text = IDtextBox.Text = EmailtextBox.Text = ClassOptions.Text = AdditionalNotestextBox.Text = Regtxt.Text = "";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            if (IDtextBox.Text == "")
            {
                MessageBox.Show("No Records Available");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("SELECT * FROM RegisterTable WHERE Student_ID = '" + IDtextBox.Text + "'", con);
                cmd.Parameters.AddWithValue("Student_ID", IDtextBox.Text);
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);
                GridView1.DataSource = dt;
                con.Close();
                Clear();
            }
        }

        private void AlterRecordsbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            cmd = new SqlCommand("UPDATE RegisterTable SET First_Name=@First_Name, Last_Name=@Last_Name, Student_ID=@Student_ID, Email=@Email, Class=@Class, Additional_Notes=@Additional_Notes Where Registration_ID=@Registration_ID", con);
            cmd.Parameters.AddWithValue("First_Name", FnametextBox.Text);
            cmd.Parameters.AddWithValue("Last_Name", LnametextBox.Text);
            cmd.Parameters.AddWithValue("Student_ID", Convert.ToInt32(IDtextBox.Text));
            cmd.Parameters.AddWithValue("Email", EmailtextBox.Text);
            cmd.Parameters.AddWithValue("Class", ClassOptions.Text);
            cmd.Parameters.AddWithValue("Additional_Notes", AdditionalNotestextBox.Text);
            cmd.Parameters.AddWithValue("Registration_ID", Regtxt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record has been altered");
            con.Close();
            Clear();
        }

        private void QueryCoursebutton_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM ClassTable", con);
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt);
            GridView1.DataSource = dt;
            con.Close();
            Clear();
            
        }

        private void Registration_Load(object sender, EventArgs e)
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
                ClassOptions.ValueMember = "Class_Name";
                ClassOptions.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
