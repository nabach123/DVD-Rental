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
    public partial class DVD_list_without_loans_in_last31days : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();

            getDetailsOfCopiesWithoutLoanIn31Days();
        }


        // method to get dvd title without loan in last 31 days
        public void getDetailsOfCopiesWithoutLoanIn31Days()
        {

            sda = new SqlDataAdapter("select DVDTitle.DVDTitle from DVDTitle except (select DVDTitle.DVDTitle from Loan inner join DVDCopy on Loan.CopyNumber = DVDCopy.CopyNumber inner join DVDTitle on DVDCopy.DVDNumber = DVDTitle.DVDNumber where Loan.DateOut >= GETDATE() - 31); ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewDVD.DataSource = dt;
            GridViewDVD.DataBind();
        }







    }
}