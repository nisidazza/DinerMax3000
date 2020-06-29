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

    protected void gvMenu_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //event called for headers and footers - data row binding
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // casting - find the GridView we want
            GridView innerGridView = (GridView)e.Row.FindControl("gvMenuItems");
            //casting - Menu object
            innerGridView.DataSource = ((DinerMax3000.Business.Menu)e.Row.DataItem).Items;
            // when changing the DataSource, always call the data bind method
            innerGridView.DataBind();
        }
    }

}