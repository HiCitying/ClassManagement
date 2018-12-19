<%@ Page Language="C#" MasterPageFile="~/UserPage.master"  AutoEventWireup="true" CodeFile="Teacher.aspx.cs" Inherits="Teacher" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHoldertitle">
    <div>
    <table class="auto-style1">
        <tr>
            <td>
                <asp:Label ID="Label_Welcome" runat="server" Text="欢迎:"></asp:Label>
            </td>
            <td align="right">
                <asp:Button ID="Button_Logout" runat="server" Text="退出" OnClick="Button_Logout_Click" />
            </td>
        </tr>
    </table>
        <br />
    </div>
</asp:Content>

<asp:Content  ID="Content2" runat="server" contentplaceholderid="ContentPlaceHolder11">
    <asp:Label Width="100%" ID="Label11" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="ContentPlaceHolder21">
    <asp:Label ID="Label21" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content4" runat="server" contentplaceholderid="ContentPlaceHolder31">
    <asp:Label ID="Label31" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content5" runat="server" contentplaceholderid="ContentPlaceHolder41">
    <asp:Label ID="Label41" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content6" runat="server" contentplaceholderid="ContentPlaceHolder51">
    <asp:Label ID="Label51" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content7" runat="server" contentplaceholderid="ContentPlaceHolder61">
    <asp:Label ID="Label61" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content8" runat="server" contentplaceholderid="ContentPlaceHolder71">
    <asp:Label ID="Label71" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content9" runat="server" contentplaceholderid="ContentPlaceHolder12">
    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content10" runat="server" contentplaceholderid="ContentPlaceHolder22">
    <asp:Label ID="Label22" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content11" runat="server" contentplaceholderid="ContentPlaceHolder32">
    <asp:Label ID="Label32" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content12" runat="server" contentplaceholderid="ContentPlaceHolder42">
    <asp:Label ID="Label42" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content13" runat="server" contentplaceholderid="ContentPlaceHolder52">
    <asp:Label ID="Label52" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content14" runat="server" contentplaceholderid="ContentPlaceHolder62">
    <asp:Label ID="Label62" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content15" runat="server" contentplaceholderid="ContentPlaceHolder72">
    <asp:Label ID="Label72" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content16" runat="server" contentplaceholderid="ContentPlaceHolder13">
    <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content17" runat="server" contentplaceholderid="ContentPlaceHolder23">
    <asp:Label ID="Label23" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content18" runat="server" contentplaceholderid="ContentPlaceHolder33">
    <asp:Label ID="Label33" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content19" runat="server" contentplaceholderid="ContentPlaceHolder43">
    <asp:Label ID="Label43" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content20" runat="server" contentplaceholderid="ContentPlaceHolder53">
    <asp:Label ID="Label53" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content21" runat="server" contentplaceholderid="ContentPlaceHolder63">
    <asp:Label ID="Label63" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content22" runat="server" contentplaceholderid="ContentPlaceHolder73">
    <asp:Label ID="Label73" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content23" runat="server" contentplaceholderid="ContentPlaceHolder14">
    <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content24" runat="server" contentplaceholderid="ContentPlaceHolder24">
    <asp:Label ID="Label24" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content25" runat="server" contentplaceholderid="ContentPlaceHolder34">
    <asp:Label ID="Label34" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content26" runat="server" contentplaceholderid="ContentPlaceHolder44">
    <asp:Label ID="Label44" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content27" runat="server" contentplaceholderid="ContentPlaceHolder54">
    <asp:Label ID="Label54" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content28" runat="server" contentplaceholderid="ContentPlaceHolder64">
    <asp:Label ID="Label64" runat="server" Text=""></asp:Label>
</asp:Content>
<asp:Content ID="Content29" runat="server" contentplaceholderid="ContentPlaceHolder74">
    <asp:Label ID="Label74" runat="server" Text=""></asp:Label>
</asp:Content>


<asp:Content ID="Content30" runat="server" contentplaceholderid="ContentPlaceHolder75">
    <asp:SqlDataSource ID="SqlDataSource_TeacherL" runat="server" ConnectionString="<%$ ConnectionStrings:ClassManagementConnectionString %>" SelectCommand=""></asp:SqlDataSource>
    </asp:Content>



