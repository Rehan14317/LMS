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
    public partial class StudentIssueBook : System.Web.UI.Page
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
            string query = "Select  UserMaster.UserName,BookMaster.BookName,BookMaster.AuthorName,Count(IssueBook.Fk_UserMasterId)As 'No of Same Books' From UserMaster Inner Join IssueBook on UserMaster.Id = IssueBook.Fk_UserMasterId Inner Join BookMaster on IssueBook.FK_bookId = BookMaster.Id where LoginId = '" + Session["LoginId"] + "' Group By UserName,BookName,AuthorName,NoOfCoppies,FK_bookId";
            //Step 2- Make the connection to the Data Base

            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {

                    gvIssue.DataSource = dataTable;
                    gvIssue.DataBind(); 
                    
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}