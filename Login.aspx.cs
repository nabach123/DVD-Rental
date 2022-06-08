using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CW_APPLICATION
{
    public partial class Login : System.Web.UI.Page
    {
        // declare variable to save user details
       
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
         
       try
            {
              // sql connection
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from users where username=@username and userpassword=@userpassword", con);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@userpassword", txtPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
               cmd.ExecuteNonQuery();
                con.Close();

                // check insert details match or not
                if (dt.Rows.Count > 0)
                {
                    Session["username"] = txtUserName.Text.ToString();
                    FormsAuthentication.RedirectFromLoginPage(txtUserName.Text,false);

                    
                 //  LabelSuccess.Text = "Successful";
                     Helper.username = txtUserName.Text;
                    Helper.password = txtPassword.Text;
                    MessageBox.Show("Successfully Login", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Response.Redirect("home.aspx");   
                    
                }
                else 
                {
                    MessageBox.Show("Invalid Details", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {            
          //  MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboarddetails.aspx");
        }
    }
}