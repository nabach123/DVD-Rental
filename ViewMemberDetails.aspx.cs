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
    public partial class ViewMemberDetails : System.Web.UI.Page
    {


        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();
            getMemberDetails();
        }

        public void getMemberDetails()
        {
            sda = new SqlDataAdapter("select Member.MemberNumber , Member.MemberFirstName, (SELECT DATEDIFF(year, MemberDOB, GETDATE()) AS  age) as Age, MembershipCategory.MembershipCategoryDescription, MembershipCategory.MembershipCategoryTotalLoans, x.TotalLoan, Case when (x.TotalLoan>=MembershipCategory.MembershipCategoryTotalLoans) then 'too many dvd' else 'ok' end as Remarks from Member join MembershipCategory on Member.MembershipCategoryNumber = MembershipCategory.MembershipCategoryNumber left join (select loan.MemberNumber, count(loan.membernumber) as TotalLoan from Loan where loan.DateReturned is null group by Loan.MemberNumber) as x on Member.MemberNumber = x.MemberNumber; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            GridViewMemberDetails.DataSource = dt;
            GridViewMemberDetails.DataBind();
        }












    }
}