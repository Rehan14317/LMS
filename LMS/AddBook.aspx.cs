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
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPublisherId();
                BindGrid();
            }
        }
        public void BindPublisherId()
        {
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            string query1 = "select PublisherName,Id from Publisher";

            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query1, connection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            ddlfk_PublisherID.DataSource = dataTable;
            ddlfk_PublisherID.DataTextField = "PublisherName";
            ddlfk_PublisherID.DataValueField = "Id";
            ddlfk_PublisherID.DataBind();
           

        }
        protected void btnSaveBook_Click(object sender, EventArgs e)
        {
            string query = "Insert into BookMaster ([Fk_PublisherId],[BookName],[AuthorName],[NoOfCoppies],[CreatedBy] ) values('"+ ddlfk_PublisherID.SelectedValue +"','"+ txtBookName.Text + "','" + txtAuthorName.Text + "','" + txtcopies.Text + "','" + Session["Id"] + "')";
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
                lblMessage.Text = "Error!!!!!!!!!";
            }
            finally
            {
                connection.Close();
            }
        }
        private void BindGrid()
        {
            string query = "select BookMaster.Id as 'Book Id',Publisher.Id, Publisher.PublisherName,BookMaster.BookName,BookMaster.AuthorName,BookMaster.NoOfCoppies,BookMaster.CreatedDate from Publisher Right Outer Join BookMaster on Publisher.Id = BookMaster.Fk_PublisherId Order By 'Book Id'";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    gvBook.DataSource = dataTable;
                    gvBook.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}