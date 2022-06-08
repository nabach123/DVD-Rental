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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dataGridViewUserDetails.Visible = false;
        }

        protected void btnManager_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select usertype from users where username='"+Helper.username+"' and userpassword='"+Helper.password+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewUserDetails.DataSource = dt;
            dataGridViewUserDetails.DataBind();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            string usertype = dataGridViewUserDetails.Rows[0].Cells[0].Text;


            if(usertype == "Manager")
            {
                Response.Redirect("MangerSettings.aspx");
            }
            else
            {
                MessageBox.Show("Only Manager can Access", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }









        }

        protected void btnAssistant_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssistantSettings.aspx");
        }
    }
}