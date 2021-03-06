<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="MangerSettings.aspx.cs" Inherits="CW_APPLICATION.MangerSettings" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    
      <style>
         .defineborder{
              width:90%;
    border: 3px solid black;
 
   margin-left:100px;
         }



          .borderdefine {
              width: 80%;
              border: 5px solid black;
              float: left;
              margin-left: 150px;
          }
   
</style>
        <div class="defineborder">
    <h1  style="text-align:center">View UserList</h1>
            <br />
            <asp:GridView ID="GridViewDVD" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="16px" HorizontalAlign="Center" Width="932px" AutoGenerateColumns="False" DataKeyNames="UserNumber" DataSourceID="SqlDataSource1" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="UserNumber" HeaderText="UserNumber" InsertVisible="False" ReadOnly="True" SortExpression="UserNumber" />
                    <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                    <asp:BoundField DataField="UserType" HeaderText="UserType" SortExpression="UserType" />
                    <asp:BoundField DataField="UserPassword" HeaderText="UserPassword" SortExpression="UserPassword" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />


            </div>
</p>
         <div class="borderdefine">
             
            <h1 style="font-size:30px; font-weight:300; text-align:center"> Add User</h1>
             <p style="font-size:20px; font-weight:300; text-align:center"> 
        
            <asp:TextBox ID="userNameTextBox" runat="server" Width="400px" placeholder="username" ></asp:TextBox>


             </p>
             <p style="font-size:20px; font-weight:300; text-align:center"> 
        
                 <asp:DropDownList ID="DropDownListUserType" runat="server" Height="28px" Width="400px">
                     <asp:ListItem>Manger</asp:ListItem>
                     <asp:ListItem>Assistant</asp:ListItem>
                 </asp:DropDownList>


             </p>
             <p style="font-size:20px; font-weight:300; text-align:center" id="userPasswordtextBox"> 
        
            <asp:TextBox ID="passwordTextBox" runat="server" Width="400px" placeholder="password" TextMode="Password" ></asp:TextBox>


             </p>
             <p style="font-size:20px; font-weight:300; text-align:center"> 
        
            <asp:Button ID="bntAddUser" runat="server" Text="Add User" Width="226px" BackColor="Red" OnClick="bntAddUser_Click" />


             </p>
             <p style="font-size:20px; font-weight:300; text-align:center"> 
        
    <asp:Label ID="successfulLabel" runat="server" style="color:red"></asp:Label>
           

                 </p>



             <br />



             </div>

    
     <br />
            <br />
     <br />
            <br /> <br />
            <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString2 %>" SelectCommand="SELECT * FROM [Users]" DeleteCommand="DELETE FROM [Users] WHERE [UserNumber] = @UserNumber" InsertCommand="INSERT INTO [Users] ([UserName], [UserType], [UserPassword]) VALUES (@UserName, @UserType, @UserPassword)" UpdateCommand="UPDATE [Users] SET [UserName] = @UserName, [UserType] = @UserType, [UserPassword] = @UserPassword WHERE [UserNumber] = @UserNumber">
        <DeleteParameters>
            <asp:Parameter Name="UserNumber" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserType" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="UserName" Type="String" />
            <asp:Parameter Name="UserType" Type="String" />
            <asp:Parameter Name="UserPassword" Type="String" />
            <asp:Parameter Name="UserNumber" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <br />
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DVDConnectionString2 %>" SelectCommand="SELECT * FROM [MembershipCategory]"></asp:SqlDataSource>
    <br />
            <br />
    
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
