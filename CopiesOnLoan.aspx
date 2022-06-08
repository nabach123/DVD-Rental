<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="CopiesOnLoan.aspx.cs" Inherits="CW_APPLICATION.CopiesOnLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
     <style>
  .defineborder{
           
    width:80%;
    border: 3px solid black;
 
   margin-left:100px;
 
 
    }
     
</style>
     <div class="defineborder">

         <h1  style="text-align:center">  Copies On Loan</h1>
         <p  style="text-align:center">  
             <asp:GridView ID="GridViewCopiesOnLoan" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" HorizontalAlign="Center" Width="967px">
                 <AlternatingRowStyle BackColor="#CCCCCC" />
                 <FooterStyle BackColor="#CCCCCC" />
                 <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                 <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                 <SortedAscendingCellStyle BackColor="#F1F1F1" />
                 <SortedAscendingHeaderStyle BackColor="#808080" />
                 <SortedDescendingCellStyle BackColor="#CAC9C9" />
                 <SortedDescendingHeaderStyle BackColor="#383838" />
             </asp:GridView>
         </p>
         <p  style="text-align:center">  &nbsp;</p>
         </div>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
