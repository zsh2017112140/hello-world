using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class shenfen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_register(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Button_register1(object sender, EventArgs e)
        {
            Response.Redirect("Register1.aspx");
        }
    }
}