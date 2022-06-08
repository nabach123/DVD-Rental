<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ReturnLoan.aspx.cs" Inherits="CW_APPLICATION.ReturnLoan" %>
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
    
   
</style></p>
      <div class="defineborder">
    
    <h1  style="text-align:center">Return Loan</h1>
          <p  style="text-align:center">&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:DropDownList ID="DropDownListCopyNumber" runat="server" Height="31px" Width="654px" DataSourceID="SqlDataSource1" DataTextField="CopyNumber" DataValueField="CopyNumber" OnSelectedIndexChanged="DropDownListCopyNumber_SelectedIndexChanged">
              </asp:DropDownList>
          </p>
          <p  style="text-align:center">
    <asp:Button ID="btnReturnLoan" runat="server" BackColor="Red" Text="Return DVD Copy" Width="249px" OnClick="btnReturnLoan_Click"  />
                     </p>
          <p  style="text-align:center">
              &nbsp;</p>
          <asp:GridView ID="GridViewLoan" runat="server" HorizontalAlign="Center" OnLoad="GridViewLoan_Load">
          </asp:GridView>
          <p  style="text-align:center">
              &nbsp;</p>


          </div>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString %>" SelectCommand="SELECT * FROM [Loan] WHERE ([DateReturned] IS NULL)"></asp:SqlDataSource>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
