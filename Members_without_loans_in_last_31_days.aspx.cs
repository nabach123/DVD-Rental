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
    public partial class Members_without_loans_in_last_31_days : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();
            getAllMemberDetailsWithoutLoan();
        }


       public void getAllMemberDetailsWithoutLoan()
        {
            sda = new SqlDataAdapter("select a.MemberFirstName, a.MemberLastName, a.MemberAddress,a.MemberNumber, a.[last Loan], (select DateDiff(day,a.[last Loan], GETDATE()) as x) as InactiveDays, DVDTitle.DVDTitle from (select Member.MemberFirstName, Member.MemberLastName, Member.MemberAddress, member.MemberNumber, MAX(Loan.DateOut) as [last Loan] from member inner join loan on Loan.MemberNumber = Member.MemberNumber inner join DVDCopy on Loan.CopyNumber = DVDCopy.CopyNumber where loan.DateOut < GETDATE()-31 group by Member.MemberFirstName, Member.MemberLastName, Member.MemberAddress, member.MemberNumber ) as a left join Loan on loan.DateOut = a.[last Loan] left join DVDCopy on DVDCopy.CopyNumber = Loan.CopyNumber left join DVDTitle on DVDTitle.DVDNumber = DVDCopy.DVDNumber where a.[last Loan] < GETDATE()-31 and a.MemberNumber = Loan.MemberNumber; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewMember.DataSource = dt;
            GridViewMember.DataBind();
        }
    }
}