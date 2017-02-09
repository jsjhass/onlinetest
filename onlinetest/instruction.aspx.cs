using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace onlinetest
{
    public partial class instruction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void start_Click(object sender, EventArgs e)
        {
            Response.Redirect("test.aspx");
        }
    }
}