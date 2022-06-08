<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CW_APPLICATION.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!DOCTYPE html>
<html5 xmlns="http://www.w3.org/1999/xhtml">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.1/font/bootstrap-icons.css"/>
    <style>

        .wrapper1
        {
            height:100vh !important;
            display:flex;
            align-items:center;
            flex-direction:column;
            justify-content:center;
            width:100% !important;
            padding:20px;
            background-color:aqua !important;
        }

        .logincontainer
        {
            border-radius:2px;
            background-color:#00ff90;
            width:90%; 
            max-width:450px;
            position:relative;
            padding:20px;
            border:1px white solid;
            box-shadow:0 15px 10px -10px #acacac;
            top: 0px;
            left: -2px;
        }

    </style>
    <header>
        <login id="form1" runat="server">
        <div class="wrapper1">
            <div class="logincontainer p-4 rounded ">
                <h3>
                <i class="bi-person-circle fs-3 me-2" style="color:darkblue"></i> User Login&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    

                </h3>

                <hr />

                <asp:TextBox runat="server" ID="txtUserName" placeholder="Enter Username" CssClass="form-control"/>
               <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="username is required" ControlToValidate="txtUserName" ForeColor="Red"></asp:RequiredFieldValidator>

                <br />

                <asp:TextBox runat="server" ID="txtPassword" placeholder="Enter Password"  TextMode="Password" 
                    CssClass="form-control"/>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="password is required" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>

                <br />


                  
                <asp:Button runat="server" ID="btnLogin" CssClass="btn btn-info form-control" Text="Login" OnClick="btnLogin_Click" />
                  <br />
                             
                           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="LabelSuccess" runat="server" Text=""  style="color:green"></asp:Label>
                  <asp:Label ID="LabelInvalid" runat="server" Text=""  style="color:red"></asp:Label>
 
                <br />
            </div>

        </div>
    </login>
    </header>

</asp:Content>
