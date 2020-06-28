using System;
using System.Web.UI.WebControls;

public partial class Menus : System.Web.UI.Page
{
    //Session state object
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["MenusPageCount"] == null)
        {
            Session["MenusPageCount"] = 0;
        }
        Session["MenusPageCount"] = (int)Session["MenusPageCount"] + 1;
    }

}