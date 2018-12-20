using System;
using System.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page 
{

    protected void Button_clear_Click(object sender, EventArgs e)
    {
        TextBox_UserID.Text = "";
        TextBox_Pwd.Text = "";
        RadioButtonList_type.SelectedValue = "学生";
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {
        string userId = TextBox_UserID.Text.Trim();
        string userpwd = TextBox_Pwd.Text.Trim();
        string usertype = "";
        switch (RadioButtonList_type.SelectedValue.Trim())
        {
            case "管理员":
                usertype = "Admin";
                break;
            case "教师":
                usertype = "Teachers";
                break;
            case "学生":
                usertype = "Students";
                break;
            default:
                break;
        }

        mySqlData ms = new mySqlData();

        switch (usertype)
        {
            case "Admin":
                if (ms.MyRead(usertype, userId, "SELECT [apwd] FROM Admin where [ano] = @userId").Equals(userpwd) == true)
                {
                    Session.Add("usertype", usertype);
                    Session.Add("userID", userId);
                    Response.Redirect("Admin.aspx");
                }
                break;
            case "Teachers":
                if (ms.MyRead(usertype, userId, "SELECT [tpwd] FROM [Teachers] where [tno] = @userId").Equals(userpwd) == true)
                {
                    Session.Add("usertype", usertype);
                    Session.Add("userID", userId);
                    Response.Redirect("Teacher.aspx");
                }
                break;
            case "Students":
                if (ms.MyRead(usertype, userId, "SELECT [spwd] FROM [Students] where [sno] = @userId").Equals(userpwd) == true)
                {
                    Session.Add("usertype", usertype);
                    Session.Add("userID", userId);
                    Response.Redirect("Student.aspx");
                }
                break;
            default:
                break;
        }
    }
}