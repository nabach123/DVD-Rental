using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class DVD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddDVD_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddDVD.aspx");
        }

        protected void btnAddCrew_Click(object sender, EventArgs e)
        {
            Response.Redirect("addcrew.aspx");
        }

        protected void btnAddDVDAvailable_Click(object sender, EventArgs e)
        {
            Response.Redirect("DVDCopiesDetails.aspx");
        }

        protected void btnAddDVDWithoutLoans_Click(object sender, EventArgs e)
        {
            Response.Redirect("DVD_list_without_loans_in_last31days.aspx");
        }

        protected void btnAddDVDDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("DVDDetails.aspx");
        }
    }
}