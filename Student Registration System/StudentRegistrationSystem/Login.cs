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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True");
        SqlCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM LoginTable WHERE Username = '" + Usernametxt.Text + "' and Password = '" + Passwordtxt.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login Successful");
                Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Login, Please try again");
                Clear();
            }
            con.Close();
        }

        void Clear()
        {
            Usernametxt.Text = Passwordtxt.Text = "";
        }
    }
}
