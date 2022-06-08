using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CW_APPLICATION
{
    public partial class AddCrew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bntAddProducer_Click(object sender, EventArgs e)
        {
            addProducer();
        }

        // method to add producer
        public void addProducer()
        {
            if (producerNameTextBox.Text != "")
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                string query = "Insert into Producer(ProducerName) values ('" + producerNameTextBox.Text + "' )";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
                responseLabelProducer.Text = "Successfully Added";

          
                clearDetails();
            }

            else
            {
                responseLabelProducer.Text = "Invalid Details";
            }

        }

        //method to add studio
        public void addStudio()
        {
            if (studioTextBox.Text != "")
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                string query = "Insert into Studio(StudioName) values ('" + studioTextBox.Text + "' )";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();
                responseLabelStudio.Text = "Successfully Added";


                clearDetails();
            }

            else
            {
                responseLabelStudio.Text = "Invalid Details";
            }

        }




        //method to clear details
        public void clearDetails()
        {
            producerNameTextBox.Text = "";
            studioTextBox.Text = "";
            actorSurnameTextBox.Text = "";
            actorFirstNameTextBox.Text = "";
            DropDownListActor.SelectedIndex = 0;
            DropDownListDVD.SelectedIndex = 0;
            
        }

        protected void btnStudio_Click(object sender, EventArgs e)
        {
            addStudio();
        }

        protected void btnAddCastMember_Click(object sender, EventArgs e)
        {

            try
            {
          
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from castmember where DVDnumber=@DVDnumber and actornumber=@actornumber", con);
                cmd.Parameters.AddWithValue("@DVDnumber", DropDownListDVD.SelectedValue);
                cmd.Parameters.AddWithValue("@actornumber", DropDownListActor.SelectedValue);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                // check insert details match or not
                if (dt.Rows.Count == 0)
                {
                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                    string query1 = "Insert into castmember(DVDnumber, actornumber) values ('" + DropDownListDVD.SelectedValue + "', '" + DropDownListActor.SelectedValue + "' )";
                    SqlConnection connection1 = new SqlConnection(connectionString);
                    SqlCommand cmd1 = new SqlCommand(query1, connection1);
                    connection1.Open();
                    cmd1.ExecuteNonQuery();

                    connection1.Close();
                    responseLabelCastMember.Text = "Successfully Added";
                    clearDetails();


                }
                else
                {
                 responseLabelCastMember.Text = "Already Exists";
                }

            }

            catch (Exception ex)
            {

                //  MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        protected void btnAddActor_Click(object sender, EventArgs e)
        {
            addActor();
        }


        // method to add actor details
        public void addActor()
        {
            if (actorFirstNameTextBox.Text != "" && actorSurnameTextBox.Text!="")
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                string query = "Insert into actor(actorsurname, actorfirstname) values ('" + actorSurnameTextBox.Text + "', '"+actorFirstNameTextBox.Text+"' )";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                responseAddActorLabel.Text = "Successfully Added";
                clearDetails();
            }

            else
            {
                responseAddActorLabel.Text = "Invalid Details";
            }

        }
    }
}