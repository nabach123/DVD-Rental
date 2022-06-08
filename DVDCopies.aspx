<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DVDCopies.aspx.cs" Inherits="CW_APPLICATION.DVDCopies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
                        
                <asp:Button ID="btnAddDVDCopies" runat="server" Height="31px" Text="Add DVD Copies" Width="153px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddDVDCopies_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnMaintainCopies" runat="server" Height="31px" Text="MaintainCopies" Width="133px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnMaintainCopies_Click"  />
        &nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnCopiesOnLoan" runat="server" Height="31px" Text="CopiesOnLoan" Width="147px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnCopiesOnLoan_Click"  />
        &nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnCopiesDetails" runat="server" Height="31px" Text="CopiesDetails" Width="171px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnCopiesDetails_Click"  />
        &nbsp;&nbsp;
                        
                </p>
    <p>
        &nbsp;&nbsp; &nbsp;</p>
</asp:Content>
