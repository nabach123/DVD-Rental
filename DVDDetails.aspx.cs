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
    public partial class DVDDetails : System.Web.UI.Page
    {


        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";
            con.Open();
            getDVDDetails();

        }

        public void getDVDDetails()
        {
           // sda = new SqlDataAdapter(" select Distinct DVDTitle,DateReleased, Producer.ProducerName,Studio.StudioName, Actor.ActorSurname, Actor.actorFirstname from DVDTitle inner join Producer on DVDTitle.DVDNumber = Producer.ProducerNumber inner join Studio on DVDTitle.StudioNumber = Studio.StudioNumber inner join CastMember on DVDTitle.DVDNumber = CastMember.DVDNumber inner join actor on CastMember.ActorNumber = Actor.ActorNumber     order by DateReleased; ", con);

            sda = new SqlDataAdapter("select Distinct DVDTitle,DateReleased, Producer.ProducerName,Studio.StudioName, string_agg(Actor.ActorSurname, ',') within group (order by Actor.ActorSurname)  as Cast from DVDTitle inner join Producer on DVDTitle.DVDNumber = Producer.ProducerNumber inner join Studio on DVDTitle.StudioNumber = Studio.StudioNumber inner join CastMember on DVDTitle.DVDNumber = CastMember.DVDNumber inner join actor on CastMember.ActorNumber = Actor.ActorNumber group by DVDTitle.DateReleased, 	Producer.ProducerName, 	Studio.StudioName 	order by DateReleased ; ", con);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridViewDVDDetails.DataSource = dt;
            dataGridViewDVDDetails.DataBind();


        }
    }
}