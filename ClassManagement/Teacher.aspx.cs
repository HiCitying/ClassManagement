using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Teacher : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["usertype"].Equals("Students") == true)
            {
                Response.Redirect("Student.aspx");
            }
            else if (Session["usertype"].Equals("Teachers") == false)
            {
                Response.Redirect("Login.aspx");
            }
        }
        catch (System.NullReferenceException)
        {
            Response.Redirect("Login.aspx");
        }

        string usertype = Session["usertype"].ToString();
        string userID = Session["userID"].ToString();
        
        mySqlData ms = new mySqlData();
        Label_Welcome.Text = "欢迎：" + ms.MyRead(usertype, userID, "SELECT [tname] FROM [Teachers] WHERE [tno] = @userID") + " " +
            ms.MyRead(usertype, userID, "SELECT [ttitle] FROM [Teachers] WHERE [tno] = @userID");


        SqlDataSource_TeacherL.SelectCommand = "SELECt ccl.cdate, ccl.ctime, Course.cname FROM" +
            "  tc INNER JOIN Teachers ON tc.tno = Teachers.tno" +
            " INNER JOIN ccl ON tc.cno = ccl.cno" +
            " INNER JOIN Course ON tc.cno = Course.cno" +
            " AND ccl.cno = Course.cno AND Teachers.tno = '" + userID + "'";

        DataView rows = (DataView)SqlDataSource_TeacherL.Select(DataSourceSelectArguments.Empty);
        foreach (DataRowView row in rows)
        {
            for (int i = 0; i < rows.Table.Columns.Count;)
            {
                string cdate = row.Row[i++].ToString();
                string ctime = row.Row[i++].ToString();
                string cname = row.Row[i++].ToString();
                switch (cdate)
                {
                    case "1":
                        switch (ctime)
                        {
                            case "1":
                                Label11.Text = cname;
                                break;
                            case "2":
                                Label12.Text = cname;
                                break;
                            case "3":
                                Label13.Text = cname;
                                break;
                            case "4":
                                Label14.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "2":
                        switch (ctime)
                        {
                            case "1":
                                Label21.Text = cname;
                                break;
                            case "2":
                                Label22.Text = cname;
                                break;
                            case "3":
                                Label23.Text = cname;
                                break;
                            case "4":
                                Label24.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        switch (ctime)
                        {
                            case "1":
                                Label31.Text = cname;
                                break;
                            case "2":
                                Label32.Text = cname;
                                break;
                            case "3":
                                Label33.Text = cname;
                                break;
                            case "4":
                                Label34.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "4":
                        switch (ctime)
                        {
                            case "1":
                                Label41.Text = cname;
                                break;
                            case "2":
                                Label42.Text = cname;
                                break;
                            case "3":
                                Label43.Text = cname;
                                break;
                            case "4":
                                Label44.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "5":
                        switch (ctime)
                        {
                            case "1":
                                Label51.Text = cname;
                                break;
                            case "2":
                                Label52.Text = cname;
                                break;
                            case "3":
                                Label53.Text = cname;
                                break;
                            case "4":
                                Label54.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "6":
                        switch (ctime)
                        {
                            case "1":
                                Label61.Text = cname;
                                break;
                            case "2":
                                Label62.Text = cname;
                                break;
                            case "3":
                                Label63.Text = cname;
                                break;
                            case "4":
                                Label64.Text = cname;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "7":
                        switch (ctime)
                        {
                            case "1":
                                Label71.Text = cname;
                                break;
                            case "2":
                                Label72.Text = cname;
                                break;
                            case "3":
                                Label73.Text = cname;
                                break;
                            case "4":
                                Label74.Text = cname;
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