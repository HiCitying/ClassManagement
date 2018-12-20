<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:GridView ID="GridView1" runat="server"
                BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" 
                CellPadding="3" PageSize="1" AutoGenerateColumns="False" 
                ShowFooter="True" 
                onrowcancelingedit="GridView1_RowCancelingEdit" 
                onrowediting="GridView1_RowEditing" 
                onrowupdating="GridView1_RowUpdating" 
                onrowdeleting="GridView1_RowDeleting">
                <Columns>
        <asp:TemplateField HeaderText="课程号">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox_cno" runat="server" Text='<%# Bind("cno") %>'/>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label_cno" runat="server" Text='<%# Bind("cno") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                    <asp:TextBox ID="TextBoxTeam" runat="server"/>
            </FooterTemplate>
        </asp:TemplateField>
                    
        <asp:TemplateField HeaderText="课程名">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox_cname" runat="server" Text='<%# Bind("cname") %>'/>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label_cname" runat="server" Text='<%# Bind("cname") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                    <asp:TextBox ID="TextBoxTeam" runat="server"/>
            </FooterTemplate>
        </asp:TemplateField>
                    
        <asp:TemplateField HeaderText="最大人数">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox_cmax" runat="server" Text='<%# Bind("cmax") %>'/>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label_cmax" runat="server" Text='<%# Bind("cmax") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                    <asp:TextBox ID="TextBoxTeam" runat="server"/>
            </FooterTemplate>
        </asp:TemplateField>
                    
        <asp:TemplateField HeaderText="剩余人数">
            <EditItemTemplate>
                <asp:TextBox ID="TextBox_cleft" runat="server" Text='<%# Bind("cleft") %>'/>
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label_cleft" runat="server" Text='<%# Bind("cleft") %>'/>
            </ItemTemplate>
            <FooterTemplate>
                    <asp:TextBox ID="TextBoxTeam" runat="server"/>
            </FooterTemplate>
        </asp:TemplateField>
        <asp:CommandField ShowEditButton="True" ShowDeleteButton HeaderText="操作" />
    </Columns>
    </asp:GridView>
       <asp:Button ID="Button1" runat="server" Text="增  加" OnClick="Button1_Click" />
            </div>
        </form>
</body>
</html>
