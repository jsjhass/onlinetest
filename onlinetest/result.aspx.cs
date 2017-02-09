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
    public partial class result : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUser.Text = Session["user"].ToString();
            lblMarks.Text = Session["marks"].ToString();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update UserMaster set Marks='" + Session["marks"].ToString() + "' where UserName='" + Session["user"].ToString() + "'", con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception er)
            {
                lblError.Text = "Error !" + er.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}