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
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnFeedback_Click(object sender, EventArgs e)
            {
            string query = "insert into Feedback(UserName,Email,Feedback) values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtFed.Text + "')";
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                connection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                lblMessage.Text = "Data Saved SuccesFully!!!!!";
                
            }
                 
            catch(Exception)
            {
                lblMessage.Text = "Error!!!!!!!!";
            }
            finally 
            {
                connection.Close();
            }
        
        
        }
    }
}