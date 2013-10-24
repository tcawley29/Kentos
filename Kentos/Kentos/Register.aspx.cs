using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kentos
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["EireVolConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataSource SQLUser = new SqlDataSource();
            SQLUser.ConnectionString = connectionString;
            SQLUser.InsertCommand = "INSERT INTO [Users] ([FirstName], [Surname], [Address1], [Address2], [Address3], [County], [Username], [Password], [Email]) VALUES (@FirstName, @Surname, @Address1, @Address2, @Address3, @County, @Username, @Password, @Email)";
            SQLUser.InsertParameters.Add("FirstName", txtFname.Text);
            SQLUser.InsertParameters.Add("Surname", txtSname.Text);
            SQLUser.InsertParameters.Add("Address1", txtAdd1.Text);
            SQLUser.InsertParameters.Add("Address2", txtAdd2.Text);
            SQLUser.InsertParameters.Add("Address3", txtAdd3.Text);
            SQLUser.InsertParameters.Add("County", txtCounty.Text);
            SQLUser.InsertParameters.Add("Username", txtUsername.Text);
            SQLUser.InsertParameters.Add("Password", txtPassword.Text);
            SQLUser.InsertParameters.Add("Email", txtEmail.Text);
            SQLUser.Insert();
            con.Close();
        }
    }
}