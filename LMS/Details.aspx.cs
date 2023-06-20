using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace LMS
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              
                BindGrid();
            }

        }

        private void BindGrid()
        {
            string query = "select UserMaster.UserName, Count(IssueBook.Fk_UserMasterId) as 'Number of Books' from UserMaster Inner Join IssueBook on UserMaster.Id = IssueBook.Fk_UserMasterId Group By UserName,Fk_UserMasterId";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    gvDetails.DataSource = dataTable;
                    gvDetails.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}