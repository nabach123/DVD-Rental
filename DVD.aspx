<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DVD.aspx.cs" Inherits="CW_APPLICATION.DVD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                        
                <asp:Button ID="btnAddDVD" runat="server" Height="31px" Text="Add DVD" Width="96px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddDVD_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnAddCrew" runat="server" Height="31px" Text="Add Crew" Width="96px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddCrew_Click" />
        &nbsp;
                        
                &nbsp;&nbsp;
                        
                <asp:Button ID="btnAddDVDDetails" runat="server" Height="31px" Text="DVD Details" Width="122px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddDVDDetails_Click" />
        &nbsp;&nbsp;
                        
                <asp:Button ID="btnAddDVDWithoutLoans" runat="server" Height="31px" Text="DVDs Without Loans" Width="188px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddDVDWithoutLoans_Click" />
        </p>
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="Image1" runat="server" Height="415px" ImageUrl="~/NewFolder1/audio-video-blank-dvd-500x500.jpeg" Width="850px" />
    </p>
    <p>
    </p>
</asp:Content>
