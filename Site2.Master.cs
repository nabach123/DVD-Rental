using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUser.Text = Helper.username;
        }

        protected void btnDVD_Click(object sender, EventArgs e)
        {
            Response.Redirect("DVD.aspx");
        }

        protected void btnDVDCopies_Click(object sender, EventArgs e)
        {
            Response.Redirect("dvdcopies.aspx");
        }

        protected void btnLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("loan.aspx");
        }

        protected void btnMember_Click(object sender, EventArgs e)
        {
            Response.Redirect("member.aspx");
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("user.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx");


        }
    }
}