using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace CW_APPLICATION
{
    public partial class MangerSettings : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
           



        }

        protected void bntAddUser_Click(object sender, EventArgs e)
        {
            addUser();
        }


        // method to add users 
        public void addUser()
        {

            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

            string query = "Insert into Users(username, usertype, userpassword) values ('" + userNameTextBox.Text + "', '"+DropDownListUserType.SelectedValue+"','"+passwordTextBox.Text+"' )";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();

            connection.Close();
            successfulLabel.Text = "Successfully Added";


            clearDetails();

        }


        // method to clear all details
        public void clearDetails()
        {
            userNameTextBox.Text = "";
            passwordTextBox.Text = "";
            DropDownListUserType.SelectedIndex = 0;
        }



    }
}