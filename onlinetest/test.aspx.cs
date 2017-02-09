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
    public partial class test : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
        int totalseconds = 0;
        int seconds = 0;
        int minutes = 0;
        string time = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler<EventArgs>(Timer1_Tick);

            if (!Page.IsPostBack)
            {
                Session["time"] = 100;
                Session["qn"] = 1;
                Session["marks"] = 0;
                try
                {
                    con.Open();
                    SqlDataAdapter adp = new SqlDataAdapter("select * from QuestionMaster where QuestionNumber=" + Session["qn"].ToString() + "", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    lblQues.Text = "Q. " + Session["qn"].ToString() + " . " + ds.Tables[0].Rows[0]["Question"].ToString();
                    rblOption.Items.Add(ds.Tables[0].Rows[0]["Option1"].ToString());
                    rblOption.Items.Add(ds.Tables[0].Rows[0]["Option2"].ToString());
                    rblOption.Items.Add(ds.Tables[0].Rows[0]["Option3"].ToString());
                    rblOption.Items.Add(ds.Tables[0].Rows[0]["Option4"].ToString());
                }
                catch (Exception er)
                {
                    lbError.Text = "Error " + er.Message;
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void Timer1_Tick(Object sender, EventArgs e)
        {
            Session["time"] = Convert.ToInt16(Session["time"]) - 1;
            if (Convert.ToInt16(Session["time"]) < 0)
            {
                Response.Redirect("result.aspx");
            }
            else
            {
                totalseconds = Convert.ToInt16(Session["time"]);
                seconds = totalseconds % 60;
                minutes = totalseconds / 60;
                time = minutes + " : " + seconds;
                lblRemTime.Text = "Remaining Time : " + time;
            }

        }
        protected void next_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("select RightOption from QuestionMaster where QuestionNumber=" + Session["qn"].ToString() + "", con);
                string s1 = Convert.ToString(cmd1.ExecuteScalar());
                if (s1 == rblOption.SelectedValue)
                {
                    Session["marks"] = Convert.ToString(Convert.ToInt32(Session["marks"].ToString()) + 1);
                }
            }
            catch (Exception er)
            {
                lbError.Text = "Error !" + er.Message;
            }
            finally
            {
                con.Close();
            }
            Session["qn"] = Convert.ToString(Convert.ToInt32(Session["qn"].ToString()) + 1);
            if (Convert.ToInt32(Session["qn"].ToString()) > 10)
            {
                Response.Redirect("result.aspx");
            }
            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("select * from QuestionMaster where QuestionNumber=" + Session["qn"].ToString() + "", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                rblOption.Items.Clear();
                lblQues.Text = "";
                lblQues.Text = "Q. " + Session["qn"].ToString() + " . " + ds.Tables[0].Rows[0]["Question"].ToString() + " ?";
                rblOption.Items.Add(ds.Tables[0].Rows[0]["Option1"].ToString());
                rblOption.Items.Add(ds.Tables[0].Rows[0]["Option2"].ToString());
                rblOption.Items.Add(ds.Tables[0].Rows[0]["Option3"].ToString());
                rblOption.Items.Add(ds.Tables[0].Rows[0]["Option4"].ToString());

            }
            catch (Exception er)
            {
                lbError.Text = "Error " + er.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}