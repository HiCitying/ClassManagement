using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["usertype"].Equals("Teachers") == true)
            {
                Response.Redirect("Teacher.aspx");
            }
            else if(Session["usertype"].Equals("Students") == true)
            {
                Response.Redirect("Studnet.aspx");
            }
            else if (Session["usertype"].Equals("Admin") == false)
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