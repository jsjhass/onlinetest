using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace onlinetest
{
    public partial class registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserMaster values(@UserName,@Email,@Marks)", con);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Marks", 0);
                cmd.ExecuteNonQuery();
            }
            catch (Exception er)
            {
                lblError.Text = "Error ! " + er.Message;
            }
            finally
            {
                con.Close();
            }
            Session["user"] = txtUserName.Text;
            Response.Redirect("instruction.aspx");
        }
    }
}