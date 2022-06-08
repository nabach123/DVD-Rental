<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="IssueLoan.aspx.cs" Inherits="CW_APPLICATION.IssueLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <style>
         .defineborder{
              width:80%;
    border: 3px solid black;
 
   margin-left:100px;
         }
    
   
</style>
        <div class="defineborder">
    
    <h1  style="text-align:center"> Issue Loan</h1>
            <p  style="text-align:center"> 
                <asp:DropDownList ID="dropDownListLoanTypeNumber" runat="server" Height="30px" Width="705px" DataSourceID="SqlDataSource4" DataTextField="LoanType" DataValueField="LoanTypeNumber">
                </asp:DropDownList>
            </p>
            <p  style="text-align:center"> 
                <asp:DropDownList ID="dropDownListCopyNumber" runat="server" Height="30px" Width="705px" DataSourceID="SqlDataSource2" DataTextField="CopyNumber" DataValueField="CopyNumber">
                </asp:DropDownList>
            </p>
            <p  style="text-align:center"> 
                <asp:DropDownList ID="dropDownListMemberNumber" runat="server" Height="30px" Width="705px" DataSourceID="SqlDataSource3" DataTextField="MemberFirstName" DataValueField="MemberNumber" OnSelectedIndexChanged="dropDownListMemberNumber_SelectedIndexChanged">
                </asp:DropDownList>
            </p>
            <p  style="text-align:center"> 
                <asp:TextBox ID="dateDueTextBox" runat="server" Height="26px" Width="705px" placeholder="Date Due (dd/MM/YYYY)"></asp:TextBox>
            </p>
            <p  style="text-align:center"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnAddDVD" runat="server" BackColor="Red" Text="Issue Loan" Width="249px" OnClick="btnAddDVD_Click1"  />
            </p>
            <p  style="text-align:center"> 
    <asp:Label ID="successfulLabel" runat="server" style="color:red"></asp:Label>
           

            </p>
            <p  style="text-align:center"> &nbsp;</p>


            </div>
    </p>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" SelectCommand="SELECT * FROM [LoanType]"></asp:SqlDataSource>
    <asp:GridView ID="gridViewMemberDetails" runat="server">
    </asp:GridView>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:GridView ID="datagridViewTotalLoans" runat="server">
    </asp:GridView>
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" SelectCommand="SELECT * FROM [Member]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" OnSelecting="SqlDataSource2_Selecting" SelectCommand="SELECT * FROM [DVDCopy]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" SelectCommand="SELECT * FROM [LoanType]"></asp:SqlDataSource>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
