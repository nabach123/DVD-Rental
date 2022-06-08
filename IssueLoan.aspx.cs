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
    public partial class IssueLoan : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();

        int memberId;
        int loantypeId;
        int ageOfMember;
        int loanedbyMember;
        int loanCapacity;
        bool isAgeRestricted;
        int standardCharge;
        DateTime loanDay;
        int copyId;
        private string connectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            gridViewMemberDetails.Visible = false;
            
        }

        protected void btnAddDVD_Click(object sender, EventArgs e)
        {
           // loanIssue();
        }

        protected void SqlDataSource2_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        



       
        public void clearDetails()
        {
            dateDueTextBox.Text = "";

           

        }

        protected void btnAddDVD_Click1(object sender, EventArgs e)
        {
            loanIssue();
        }

        protected void dropDownListMemberNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
//           
//           
        }


        public void checkAge()
        {
            memberId = Convert.ToInt32(dropDownListMemberNumber.SelectedValue);

            string query = " select count (Loan.LoanNumber) from loan where Loan.MemberNumber= '" + dropDownListLoanTypeNumber.SelectedValue.ToString() + "' and Loan.DateReturned is Null ";

            string query2 = " select Member.MemberNumber, (Member.MemberFirstName + ' ' + Member.MemberLastName) as MemberName," +
           "DATEDIFF(year, Member.MemberDateOfBirth, GETDATE()) As age," +
             "MembershipCategory.MembershipCategoryDescription,MembershipCategory.MembershipCategoryTotalLoans " +
"from MembershipCategory inner join Member on Member.membershipCategoryNumber = MembershipCategory.MembershipCategoryNumber " +
"where Member.MemberNumber = '" + dropDownListMemberNumber.SelectedValue.ToString() + "' ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                //cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                adapter.Fill(dt);

                datagridViewTotalLoans.DataSourceID = "";
                datagridViewTotalLoans.DataSource = dt;
                datagridViewTotalLoans.DataBind();
                connection.Close();

                loanedbyMember = Convert.ToInt32(datagridViewTotalLoans.Rows[0].Cells[0].Text);
            }



            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlCommand cmd2 = new SqlCommand(query2, connection2);
                //cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataSet dt2 = new DataSet();
                adapter2.Fill(dt2);

                gridViewMemberDetails.DataSourceID = "";
                gridViewMemberDetails.DataSource = dt2;
                gridViewMemberDetails.DataBind();
                connection2.Close();

                loanCapacity = Convert.ToInt32(gridViewMemberDetails.Rows[0].Cells[4].Text);
                ageOfMember = Convert.ToInt32(gridViewMemberDetails.Rows[0].Cells[2].Text);




                //loanCapacity= Codt2.Tables[0].Rows[0].ItemArray[4];
                // age = (int)dt2.Tables[0].Rows[0].ItemArray[2];

                //Response.Write("UserType = " + loanCapacity);
                //Response.Write("UserType = " + age);

                if (loanedbyMember > loanCapacity)
                {
                    MessageBox.Show(" Loans Limit has been reached");



                }
            }
        }


                protected void recordCopyB_Click(object sender, EventArgs e)
        {



            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlCommand cmd2 = new SqlCommand(" select DVDDetail.DVDNumber, DVDDetail.DVDTitle, DVDDetail.StandardCharge,DVDCategory.CategoryDescription,"
          + "DVDCategory.AgeRestricted from DVDDetail left join DVDCategory on DVDCategory.CategoryNumber = DVDDetail.CategoryNumber" +
           " left join DVDCopy on DVDCopy.DVDNumber = DVDDetail.DVDNumber where DVDCopy.CopyNumber = '" + dropDownListCopyNumber.SelectedValue.ToString() + "'", connection2);
                //cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataSet dt3 = new DataSet();
                adapter2.Fill(dt3);

                datagridViewTotalLoans.DataSourceID = "";
                datagridViewTotalLoans.DataSource = dt3;
                datagridViewTotalLoans.DataBind();
                connection2.Close();

                copyId = Convert.ToInt32(dropDownListCopyNumber.SelectedValue);

                standardCharge = Convert.ToInt32(datagridViewTotalLoans.Rows[0].Cells[2].Text);
                isAgeRestricted = Convert.ToBoolean(datagridViewTotalLoans.Rows[0].Cells[4].Text);
                

                if (isAgeRestricted && ageOfMember < 18)
                {
                    MessageBox.Show("Age Restricted");
                   
                }
            }
        }



        // check memberloan
          public void checkMemberLoans()
        {

            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                SqlCommand cmd2 = new SqlCommand(" select DVDDetail.DVDNumber, DVDDetail.DVDTitle, DVDDetail.StandardCharge,DVDCategory.CategoryDescription,"
          + "DVDCategory.AgeRestricted from DVDDetail left join DVDCategory on DVDCategory.CategoryNumber = DVDDetail.CategoryNumber" +
           " left join DVDCopy on DVDCopy.DVDNumber = DVDDetail.DVDNumber where DVDCopy.CopyNumber = '" + dropDownListCopyNumber.SelectedValue.ToString() + "'", connection2);
                //cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                DataSet dt3 = new DataSet();
                adapter2.Fill(dt3);

                datagridViewTotalLoans.DataSourceID = "";
                datagridViewTotalLoans.DataSource = dt3;
                datagridViewTotalLoans.DataBind();
                connection2.Close();

                copyId = Convert.ToInt32(dropDownListCopyNumber.SelectedValue);

                standardCharge = Convert.ToInt32(datagridViewTotalLoans.Rows[0].Cells[2].Text);
                isAgeRestricted = Convert.ToBoolean(datagridViewTotalLoans.Rows[0].Cells[4].Text);


                if (isAgeRestricted && ageOfMember < 18)
                {
                    MessageBox.Show("Age Restricted");

                }
            }
        }

        // method to issue loan
        public void loanIssue()
        {

          

                if (dateDueTextBox.Text != "")
                {
                  //  var days = (DateTime.Now - Convert.ToDateTime(dateDueTextBox.Text));
                 
                    int totalcharge= standardCharge;

                    string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DVD;Integrated Security=True";

                    string query = "Insert into loan(loantypenumber, copynumber,membernumber, dateout,datedue) values ('" + dropDownListLoanTypeNumber.SelectedValue + "', '" + dropDownListCopyNumber.SelectedValue + "', '" + dropDownListMemberNumber.SelectedValue + "','" + DateTime.Now + "',  '" + dateDueTextBox.Text + "')";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    cmd.ExecuteNonQuery();

                    connection.Close();
             
               MessageBox.Show("DVD Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearDetails();
                }

                else
                {
                MessageBox.Show("Invalid Details", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

           

        }

    }
