using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class MainPage : MaterialSkin.Controls.MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Registrationbutton_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
        }

        private void Administrativebutton_Click(object sender, EventArgs e)
        {
            Administrative obj = new Administrative();
            obj.Show();
        }

        private void Studentbutton_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.TopMost = true;
            obj.Show();
        }
    }
}
