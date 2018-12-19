using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
        SqlDataReader dr;
        System.Data.SqlClient.SqlConnection conn = new SqlConnection();
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["ClassManagementConnectionString"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;
        SqlParameter para = new SqlParameter();
        switch (usertype)
        {
            case "Admin":
                cmd.CommandText = "SELECT [apwd] FROM [Admin] where [ano] = @userId";
                para = new SqlParameter("@userId", System.Data.SqlDbType.VarChar, 50);
                break;
            case "Teachers":
                cmd.CommandText = "SELECT [tpwd] FROM [Teachers] where [tno] = @userId";
                para = new SqlParameter("@userId", System.Data.SqlDbType.VarChar, 50);
                break;
            case "Students":
                cmd.CommandText = "SELECT [spwd] FROM [Students] where [sno] = @userId";
                para = new SqlParameter("@userId", System.Data.SqlDbType.VarChar, 50);
                break;
            default:
                break;
        }
        para.Value = userId;
        cmd.Parameters.Add(para);
        try
        {
            conn.Open();
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                if(dr.GetString(0) == userpwd)
                {
                    Session.Add("usertype",usertype);
                    switch (usertype)
                    {
                        case "Admin":
                            Response.Redirect("Student.aspx");
                            break;
                        case "Teachers":
                            break;
                        case "Students":
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Response.Write("<Script>alert(\"密码错误\")</Script>");
                }
            }
            else
            {
                Response.Write("<Script>alert(\"用户不存在\")</Script>");
            }
            dr.Close();
        }
        catch(SqlException ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}