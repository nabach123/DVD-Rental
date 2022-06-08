using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class DVDCopies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddDVDCopies_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addcopies.aspx");
        }

        protected void btnMaintainCopies_Click(object sender, EventArgs e)
        {
            Response.Redirect("maintaincopies.aspx");
        }

        protected void btnCopiesOnLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("copiesonloan.aspx");
        }

        protected void btnCopiesDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("copiesdetails.aspx");
        }
    }
}