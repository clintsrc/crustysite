using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crustysite
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string Name = NameTxt.Text;
            string Email = EmailTxt.Text;
            string Password = PasswordTxt.Text;
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            /* Server-side validation */
            if (!System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                Output.Text = "Invalid email format.";
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr)) {
                string query = "INSERT INTO Info(name, email, password) VALUES (@Name, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                Output.Text = "Added Successfully!";
            }
        }
    }
}