<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AddMember.aspx.cs" Inherits="CW_APPLICATION.AddMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
     <style>
         .defineborder{
              width:80%;
    border: 3px solid black;
 
   margin-left:100px;
         }
    
   
</style>




          <div class="defineborder">

              <h1  style="text-align:center">Add Member</h1>
              <p  style="text-align:center">
                  <asp:DropDownList ID="DropDownListCategory" runat="server" Height="30px" Width="605px" DataSourceID="SqlDataSource1" DataTextField="MembershipCategoryDescription" DataValueField="MembershipCategoryNumber">
                  </asp:DropDownList>
              </p>
              <p  style="text-align:center">
                  <asp:TextBox ID="addSurnameTextBox" runat="server" Height="28px" Width="590px" placeholder="Surname"></asp:TextBox>
              </p>
              <p  style="text-align:center">
                  <asp:TextBox ID="addFirstnameTextBox" runat="server" Height="28px" Width="590px" placeholder="Firstname"></asp:TextBox>
              </p>
              <p  style="text-align:center">
                  <asp:TextBox ID="memberAddressTextBox" runat="server" Height="28px" Width="590px" placeholder="Address"></asp:TextBox>
              </p>
              <p  style="text-align:center">
                  <asp:TextBox ID="memberDOBTextBox" runat="server" Height="28px" Width="590px" placeholder="DOB (mm/dd/yyyy)"></asp:TextBox>
              </p>
              <p  style="text-align:center">
    <asp:Button ID="btnAddMember" runat="server" BackColor="Red" Text="Add Member" Width="249px" OnClick="btnAddMember_Click"  />
              </p>
              <p  style="text-align:center">
    <asp:Label ID="successfulLabel" runat="server" style="color:red"></asp:Label>
           

              </p>




              <br />




              </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" SelectCommand="SELECT * FROM [MembershipCategory]"></asp:SqlDataSource>
    <br />
    <br />
</asp:Content>
