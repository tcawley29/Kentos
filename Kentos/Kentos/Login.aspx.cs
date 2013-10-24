using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kentos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.Params["logout"]))
            {
                FormsAuthentication.SignOut();
                Response.Redirect("./");
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            if (ValidUser(txtUsername.Text, txtPassword.Text))
            {
                Response.Redirect("itsligo.ie");
            }
            else
            {
                Response.Redirect("hotmail.com");
            }
        }

            bool ValidUser(string user, string pass)
            {
                string connStr =ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "select * from LoginTable where email = @username and password = @password";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@username", user);
                    cmd.Parameters.AddWithValue("@password", pass);
                    return cmd.ExecuteScalar() is string;
                }
            }
            protected void LinkButton1_Click(object sender, EventArgs e)
            {
                Response.Redirect("itsligo.ie");
            }
        }
    }