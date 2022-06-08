<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DVDDetails.aspx.cs" Inherits="CW_APPLICATION.DVDDetails" %>
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
         <h1 style="text-align:center"> DVD Details </h1>
         <asp:GridView ID="dataGridViewDVDDetails" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="131px" HorizontalAlign="Center" Width="920px">
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
         <p style="text-align:center"> &nbsp;</p>
         <p style="text-align:center"> &nbsp;</p>
     <br />
</asp:Content>
