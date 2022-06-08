<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="CW_APPLICATION.Member" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnAddMember" runat="server" Height="31px" Text="Add Member" Width="153px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnAddMember_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnViewMemberDetails" runat="server" Height="31px" Text="Member Details" Width="214px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnViewMemberDetails_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnViewMemberLoanOn31Days" runat="server" Height="31px" Text="Member Loan Details" Width="306px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnViewMemberLoanOn31Days_Click"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        
                <asp:Button ID="btnViewMemberDetails0" runat="server" Height="31px" Text="Member without Loan" Width="214px" BackColor="#CCCCCC" BorderColor="#CCCCCC" OnClick="btnViewMemberDetails0_Click"  />
        </p>
    <p>
    </p>
</asp:Content>
