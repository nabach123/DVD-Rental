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
    public partial class DashboardDetails : System.Web.UI.Page
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
            getDVDNotLoanDetails();
        }


        public void getDVDDetailsByActorSurname()
        {
            sda = new SqlDataAdapter("select  distinct DVDTitle.DVDNumber, DVDTitle.DVDTitle, DVDTitle.DateReleased  from DVDTitle inner join CastMember on DVDTitle.DVDNumber = CastMember.DVDNumber  inner  join Actor on CastMember.ActorNumber = Actor.ActorNumber   where Actor.ActorSurname = '" + dropDownListDVDDetails.SelectedValue + "'; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewDVDDetails.DataSource = dt;
            GridViewDVDDetails.DataBind();
           
        }


        // method to get dvd details which are in loan by using actor surname
        public void getDVDNotLoanDetails()
        {
            sda = new SqlDataAdapter("select  Distinct DVDTitle.DVDNumber, DVDTitle.DVDTitle, DVDTitle.DateReleased, DVDCopy.CopyNumber  from DVDTitle inner join CastMember on DVDTitle.DVDNumber = CastMember.DVDNumber  inner  " +
                "  join Actor on CastMember.ActorNumber = Actor.ActorNumber inner join DVDCopy on DVDTitle.DVDNumber = DVDCopy.DVDNumber inner  join loan on DVDCopy.CopyNumber = Loan.CopyNumber  where Loan.DateReturned is null and Actor.ActorSurname = '" + dropDownListDVDDetails1.SelectedValue + "'; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewDVDLoanDetails.DataSource = dt;
            GridViewDVDLoanDetails.DataBind();
            
        }

        protected void dropDownListDVDDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDVDDetailsByActorSurname();
        }

        protected void dropDownListDVDDetails1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDVDNotLoanDetails();
        }
    }
}