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
    public partial class AddPublisher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void BtnSavePublisher_Click(object sender, EventArgs e)
        {
            string query = "Insert into Publisher ([PublisherName],[Address],[Pincode],[CreatedBy] ) values('" + txtPublisherName.Text + "','" + txtAddress.Text + "','" + txtPincode.Text + "','" + Session["Id"] + "');";
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
            }
            finally
            {
                connection.Close();
            }
        }
        private void BindGrid()
        {
            string query = "select * from Publisher";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    gvPublisher.DataSource = dataTable;
                    gvPublisher.DataBind();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}