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
    public partial class AddMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            addMember();
        }

        // method to add member
        public void addMember()
        {

            try
            {
                if (addSurnameTextBox.Text != "" && addFirstnameTextBox.Text != "" && memberAddressTextBox.Text != "" && memberAddressTextBox.Text!="")
                {
                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                    string query = "Insert into member(membershipcategorynumber, memberlastname,memberfirstname, memberaddress,memberDOB) values ('" + DropDownListCategory.SelectedValue + "', '" + addSurnameTextBox.Text + "', '" + addFirstnameTextBox.Text + "','" + memberAddressTextBox.Text + "', '" + memberDOBTextBox.Text + "' )";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    connection.Close();
                    successfulLabel.Text = "Successfully Added";
                    clearDetails();
                }

                else
                {
                    successfulLabel.Text = "Invalid Details";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }






        }


        public void clearDetails()
        {
            addFirstnameTextBox.Text = "";
            addSurnameTextBox.Text = "";
            memberDOBTextBox.Text = "";
            DropDownListCategory.SelectedIndex = 0;
            memberAddressTextBox.Text = "";
        }
    }
}