using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {
        if(e != null)
        {
            if(e.GetType() == typeof(System.Data.SqlClient.SqlException))
            {
                Button1.Text = "shibai";
            }
        }
        else
        {
            Button1.Text = "YYYYY";
        }
    }
}