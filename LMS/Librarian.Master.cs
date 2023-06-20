using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMS
{
    public partial class Librarian : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserType"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                int userType = Convert.ToInt32(Session["UserType"]);
                if (userType != 1)
                {
                    Response.Redirect("LibrarionNoAccess.aspx");
                }
            }
        }
    }
}