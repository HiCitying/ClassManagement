using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI;

public partial class Student : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["usertype"].Equals("Teachers") == true)
            {
                Response.Redirect("Teacher.aspx");
            }
            else if ((Session["usertype"].Equals("Admin") == false) & (Session["usertype"].Equals("Students") == false))
            {
                Response.Redirect("Login.aspx");
            }
        }
        catch(System.NullReferenceException)
        {
            Response.Redirect("Login.aspx");
        }

        string usertype = Session["usertype"].ToString();
        string userID = Session["userID"].ToString();
        mySqlData ms = new mySqlData();
        Label_Welcome.Text = "欢迎：" + ms.MyRead(usertype,userID,"SELECT [sname] FROM [Students] WHERE [sno] = @userID") + "同学";
        string[] array = new string[100];

        SqlDataSource_StudentL.SelectCommand = "SELECT ccl.cdate, ccl.ctime, Course.cname, Teachers.tname FROM ccl INNER JOIN Students ON ccl.clno = Students.clno " +
            "INNER JOIN Course ON ccl.cno = Course.cno INNER JOIN tc ON Course.cno = tc.cno INNER JOIN Teachers ON tc.tno = Teachers.tno " +
            "AND Students.sno = '"+ userID +"'";

        DataView rows = (DataView)SqlDataSource_StudentL.Select(DataSourceSelectArguments.Empty);
        foreach (DataRowView row in rows)
        {
            for (int i = 0; i < rows.Table.Columns.Count;)
            {
                string cdate = row.Row[i++].ToString();
                string ctime = row.Row[i++].ToString();
                string cname = row.Row[i++].ToString();
                string tname = row.Row[i++].ToString();
                switch (cdate)
                {
                    case "1":
                        switch (ctime)
                        {
                            case "1":
                                Label11.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label12.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label13.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label14.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                    break;
                    case "2":
                        switch (ctime)
                        {
                            case "1":
                                Label21.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label22.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label23.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label24.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        switch (ctime)
                        {
                            case "1":
                                Label31.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label32.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label33.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label34.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        switch (ctime)
                        {
                            case "1":
                                Label41.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label42.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label43.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label44.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "5":
                        switch (ctime)
                        {
                            case "1":
                                Label51.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label52.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label53.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label54.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "6":
                        switch (ctime)
                        {
                            case "1":
                                Label61.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label62.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label63.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label64.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "7":
                        switch (ctime)
                        {
                            case "1":
                                Label71.Text = cname + "·" + tname;
                                break;
                            case "2":
                                Label72.Text = cname + "·" + tname;
                                break;
                            case "3":
                                Label73.Text = cname + "·" + tname;
                                break;
                            case "4":
                                Label74.Text = cname + "·" + tname;
                                break;
                            default:
                                break;
                        }
                        break;
                }
            }
        }
    }


    protected void Button_Logout_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
    
}