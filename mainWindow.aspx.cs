using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection("Data Source=192.168.1.32/LM-FIN12; Initial Catalog=MikeTestDatabase; User Id=FormSubmit; Password=Lawless???;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into MikeTestDatabase..testForm values('" + txtRegNo.Text + "','" + txtPassword.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtMobile.Text + "','" + txtEmail.Text + "')", c);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Record Submitted Successfully";
            c.Close();

            
        }
    }
}