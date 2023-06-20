using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LMS
{
    public partial class Issue_Book : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                BindIssueBook();
            }

        }

        public void BindIssueBook()
        {
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            
            //DataBinding For Student List
            string query1 = "select UserName,Id from UserMaster where usertype=0";
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query1, connection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            ddlStudentList.DataSource = dataTable;
            ddlStudentList.DataTextField = "UserName";
            ddlStudentList.DataValueField = "Id";

            //DataBinding For Book List
            string query2 = "select BookName,Id from BookMaster";
            SqlDataAdapter da2 = new SqlDataAdapter(query2, connection);
            da2.Fill(dataTable);
            ddlBookList.DataSource = dataTable;
            ddlBookList.DataTextField = "BookName";
            ddlBookList.DataValueField = "Id";

            ddlStudentList.DataBind();
            ddlBookList.DataBind();
        }


        private void BindGrid()
        {
            string query = "Select IssueBook.FK_bookId, IssueBook.Fk_UserMasterId,BookMaster.BookName,BookMaster.AuthorName,UserMaster.UserName, IssueBook.BookIssueDate,UserMaster.ClassName,UserMaster.Address from BookMaster Inner Join IssueBook ON BookMaster.ID = IssueBook.FK_bookId Inner Join UserMaster On IssueBook.Fk_UserMasterId = UserMaster.Id Order By UserName";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    gvIssueBook.DataSource = dataTable;
                    gvIssueBook.DataBind();
                }
            }
            catch (Exception )
            {

            }
        }
        protected void BtnSaveIssueBook_Click(object sender, EventArgs e)
        {
            string query = "insert into IssueBook(Fk_UserMasterId,FK_bookId) values ('" + ddlStudentList.SelectedValue + "','" + ddlBookList.SelectedValue + "')";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                lblMessage.Text = "Data saved successfully.";
                BindGrid();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Error.........";
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }

}
