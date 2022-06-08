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
    public partial class MaintainCopies : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();


        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();
            getDetailsOfCopiesWherePurchasedAboveYear();
        }


        // method to get all data from stock all DVD copies which are more than 365 days old
        public void getDetailsOfCopiesWherePurchasedAboveYear()
        {

            sda = new SqlDataAdapter("SELECT dc.Copynumber DVDNumber, DatePurchased FROM DVDCopy dc, Loan l WHERE dc.CopyNumber=l.CopyNumber AND dc.DatePurchased < GETDATE()-365 AND l.DateDue >= l.DateReturned; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewCopiesDetails.DataSource = dt;
            dataGridViewCopiesDetails.DataBind();
            if(dt.Rows.Count > 0)
            {
                MessageBox.Show(dataGridViewCopiesDetails.Rows[0].ToString());
            }
           
        }


        // remoes copies button
        protected void btnRemoveCopies_Click(object sender, EventArgs e)
        {





            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

            string query = "Delete from loan where  where copynumber in ('" + dataGridViewCopiesDetails.Rows[0].ToString() + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();

            string query1 = "Delete from dvdcopy where  where copynumber in ('" + dataGridViewCopiesDetails.Rows[0].ToString() + "')";
            SqlConnection connection1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand(query1, connection1);
            connection.Open();
            cmd1.ExecuteNonQuery();



            connection.Close();
            successfulLabel.Text = "Successfully Added";
         //   clearDetails();





        }
    }
}