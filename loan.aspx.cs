using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class loan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReturnLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("returnloan.aspx");
        }

        protected void btnIssueLoan_Click(object sender, EventArgs e)
        {
            Response.Redirect("issueloan.aspx");
        }
    }
}