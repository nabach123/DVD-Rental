<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AssistantSettings.aspx.cs" Inherits="CW_APPLICATION.AssistantSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <style>
         .defineborder{
              width:60%;
    border: 3px solid black;
 
   margin-left:200px;
         }
    
   
</style>
     <br />
     <div class="defineborder">
    <h1  style="text-align:center">Change Password</h1>
         <p  style="text-align:center"> 
        
            <asp:TextBox ID="userNewPasswordTextBox" runat="server" Width="400px" placeholder="Password" TextMode="Password" ></asp:TextBox>


             </p>
         <p  style="text-align:center"> 
        
            <asp:TextBox ID="confirmPasswordTextBox" runat="server" Width="400px" placeholder="Confirm Paasword" TextMode="Password" ></asp:TextBox>


             </p>
         <p  style="text-align:center"> 
        
    <asp:Button ID="btnChangePassword" runat="server" BackColor="Red" Text="Change Password" Width="249px" OnClick="btnChangePassword_Click"  />


             </p>
         <p  style="text-align:center"> 
        
    <asp:Label ID="successfulLabel" runat="server" style="color:red"></asp:Label>
           

             </p>
         <p  style="text-align:center"> 
        
             &nbsp;</p>
         <p  style="text-align:center">&nbsp;</p>
         </div>
         
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
         
</asp:Content>
