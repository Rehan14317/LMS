using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LMS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnLogin_Click(object sender, EventArgs e)   
        {
            //Step 1- Prepare a SQL query
            string query = "Select * from UserMaster Where [LoginId]='" + txtLoginId.Text + "' and [Password]='" + txtPassword.Text + "';";
            //Step 2- Make the connection to the Data Base
            SqlConnection connection = new SqlConnection("Server=PREDATORZ-17\\SQLEXPRESS;Database=LibraryManagement;Integrated Security = True;");
            try
            {
                connection.Open();
                //Step 3- Prepare object for SQL adaptor
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                //Step 4: to captur query data create object of DataTable
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                //Step 5- Check we are having any record in datatable or not
                if (dataTable.Rows.Count > 0)
                {
                    Session["LoginId"] = dataTable.Rows[0]["LoginId"];
                    Session["Password"] = dataTable.Rows[0]["Password"];
                    //Session["UserName"] = dataTable.Rows[0]["UserName"];
                    Session["usertype"] = dataTable.Rows[0]["usertype"];
                    Session["Id"] = dataTable.Rows[0]["Id"];
                    connection.Close();
                    int type = Convert.ToInt32(dataTable.Rows[0]["usertype"]);
                    if (type == 1)//Admin OR Librarion
                    {
                        Response.Redirect("LibrarionHome.aspx");
                    }
                    else//Student
                    {
                        Response.Redirect("StudentIssueBook.aspx");

                    }
                }
                else 
                {
                  
                    lblMessage.Text = "Invalid Credentials.";
                }
                


            }
            catch (Exception )
            {

            }
            finally
            {
                connection.Close();
            }
        }
    }
}