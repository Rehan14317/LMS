using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class Student : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usertype"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                int userType = Convert.ToInt32(Session["usertype"]);
                if (userType != 2)
                {
                    Response.Redirect("StudentNoAccess.aspx");
                }
            }
        }
    }
}