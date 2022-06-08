using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class Member_s_loans_in_last_31_days : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();

            getDVDDetailsByActorSurname();
        }



        // method to get Member’s loans in last 31 days 
        public void getDVDDetailsByActorSurname()
        {
            sda = new SqlDataAdapter("select Member.MemberNumber,  (Member. MemberFirstName +''+Member.MemberLastName) as MemberName, DVDTitle.DVDTitle, DVDCopy.CopyNumber, Loan.DateOut from Loan inner join Member on Loan.MemberNumber =  Member.MemberNumber	 inner join DVDCopy on loan.CopyNumber = DVDCopy.CopyNumber	 inner join DVDTitle on DVDCopy.DVDNumber = DVDTitle.DVDNumber where Member.MemberNumber = 1  and loan.DateOut>=GETDATE()-31  and Member.MemberLastName = '" + DropDownListMemberLastName.SelectedValue + "'; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewLoanIn31Days.DataSource = dt;
            GridViewLoanIn31Days.DataBind();

        }

        protected void DropDownListMemberLastName_SelectedIndexChanged(object sender, EventArgs e)
        {
         getDVDDetailsByActorSurname();
        }
    }
}