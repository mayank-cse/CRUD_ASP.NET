using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Web.Configuration;
namespace CRUD
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Code for insertion
        protected void insert_Click(object sender, EventArgs e)
        {

            string con = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into stigma.[dbo].[CRUD] (StudentID, [First Name], [Last Name], [Date of Birth], [Email ID]) values ('" + txtID.Text + "','" + txtFname.Text + "','" + txtLname.Text + "','" + txtDOB.Text + "','" + txtEmail.Text + "')";
            Response.Write("<script>alert('" + insert + "')</script>");
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Write("<script>alert('Inserted successfully!')</script>");

            }
            else
            {
                Response.Write("<script>alert('Insertion not successfull!')</script>");
            }
            db.Close();
        }

        private bool alert(char v)
        {
            throw new NotImplementedException();
        }
        //code for Deletion
        protected void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                SqlConnection db = new SqlConnection(con);
                db.Open();
                string delete = "DELETE FROM [dbo].[CRUD] WHERE StudentID = '" + txtID + "'";
                SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[CRUD] WHERE StudentID = '" + txtID + "'", db);
                int m = cmd.ExecuteNonQuery();
                if (m != 0)
                {
                    Response.Write("<script>alert('Deleted successfully!')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Delete not successfull!')</script>");
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Code for updation
        protected void update_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
                SqlConnection db = new SqlConnection(con);
                db.Open();
                string delete = "UPDATE stigma.[dbo].[CRUD] SET [First Name] = '" + txtFname.Text + "', [Last Name] = '" + txtLname.Text + "',  [Date of Birth] = '" + txtDOB.Text + "',[Email ID] = '" + txtEmail.Text + "' WHERE StudentID = '" + txtFname.Text + "'";
                SqlCommand cmd = new SqlCommand(delete, db);
                int m = cmd.ExecuteNonQuery();
                if (m != 0)
                {
                    Response.Write("<script>alert('Updated successfully!')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Update not successfull!')</script>");
                }
                db.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }

}