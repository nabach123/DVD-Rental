<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DVDCopiesOnLoan.aspx.cs" Inherits="CW_APPLICATION.DVDCopiesOnLoan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style>
         .defineborder{
              width:80%;
    border: 3px solid black;
 
   margin-left:100px;
         }
    
   
</style>
     <div class="defineborder">
          <h1 style="text-align:center"> DVD Copies On loan </h1>
          <p style="text-align:center"> 
              <asp:GridView ID="datagridViewCopies" runat="server" Height="141px" HorizontalAlign="Center" Width="809px">
              </asp:GridView>
          </p>
          <p style="text-align:center"> &nbsp;</p>



</asp:Content>
