using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class Member : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("addmember.aspx");
        }

        protected void btnViewMemberDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewmemberdetails.aspx");
        }

        protected void btnViewMemberLoanOn31Days_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member’s_loans_in_last_31_days.aspx");
        }

        protected void btnViewMemberDetails0_Click(object sender, EventArgs e)
        {
            Response.Redirect("Members_without_loans_in_last_31_days.aspx");
            
        }


    }
}