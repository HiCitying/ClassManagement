using System;
using System.Collections.Generic;
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
            else if ((Session["usertype"].Equals("Admin") == false) & (Session["usertype"].Equals("Teachers") == false))
            {
                Response.Redirect("Login.aspx");
            }
        }
        catch (System.NullReferenceException)
        {
            Response.Redirect("Login.aspx");
        }
    }
}