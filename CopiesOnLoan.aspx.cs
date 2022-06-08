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
    public partial class CopiesOnLoan : System.Web.UI.Page
    {


        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();
            getDetailsAllCopiesLoan();
        }

        // method to get dvd copie on loan
        public void getDetailsAllCopiesLoan()
        {

            sda = new SqlDataAdapter("SELECT DVDTitle.DVDTitle, Loan.DateOut, DVDCopy.CopyNumber, Member.MemberFirstName , x.total FROM DVDTitle INNER JOIN DVDCopy ON DVDTitle.DVDNumber = DVDCopy.DVDNumber left JOIN Loan ON DVDCopy.CopyNumber = Loan.CopyNumber left join Member on Loan.MemberNumber = Member.MemberNumber inner join (select DateOut, Count(DateOut) as total from Loan group by DateOut) as x on Loan.DateOut = x.DateOut where DVDCopy.CopyNumber = Loan.CopyNumber and Loan.DateOut is not null and Loan.DateReturned is null group by DVDTitle.DVDTitle, Loan.DateOut, DVDCopy.CopyNumber, Member.MemberFirstName, x.total order by Loan.DateOut, DVDTitle.DVDTitle; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewCopiesOnLoan.DataSource = dt;
            GridViewCopiesOnLoan.DataBind();

        }











    }
}