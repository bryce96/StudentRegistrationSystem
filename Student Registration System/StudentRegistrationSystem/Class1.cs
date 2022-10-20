using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegistrationSystem
{
    class connection
    {
        SqlConnection con;

        public connection()
        {
            con = new SqlConnection("Data Source = DESKTOP-CF2L1B1\\SQLEXPRESS; Initial Catalog = StudentRegistration; Integrated Security = True");
        }

        public SqlConnection opencon()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {

            }

            return con;
        }

        public void conclose()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
