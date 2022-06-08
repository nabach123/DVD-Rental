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
    public partial class AddCopies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddDVD_Click(object sender, EventArgs e)
        {
            addDVDCopy();
        }

        public void addDVDCopy()
        {

            try
            {
                if (datePurchasedTextBox.Text != "" )
                {
                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                    string query = "Insert into DVDCopy(DVDNumber,DatePurchased ) values ('" + DropDownListDVDNumber.SelectedValue + "', '" + datePurchasedTextBox.Text + "' )";
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
            DropDownListDVDNumber.SelectedIndex = 0;
            datePurchasedTextBox = null;    
        }
    }
}