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
    public partial class DVDCopiesDetails : System.Web.UI.Page
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

        public void getDVDDetailsByActorSurname()
        {
            sda = new SqlDataAdapter("select loan.LoanNumber, loan.CopyNumber, loan.DateOut, loan.DateDue, loan.DateReturned, Member.MemberFirstName, Member.MemberLastName, DVDTitle.DVDTitle from loan inner join Member on Member.MemberNumber = loan.MemberNumber    inner join DVDCopy on DVDCopy.CopyNumber = loan.CopyNumber  inner join DVDTitle on DVDTitle.DVDNumber = DVDCopy.DVDNumber where loan.CopyNumber = '" + DropDownListCopyNumber.SelectedValue + "'  order by Loan.DateOut desc; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void DropDownListCopyNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDVDDetailsByActorSurname();
        }
    }
}