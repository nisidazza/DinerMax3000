﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DinerMax3000MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Application state object
        if (Application["TotalPageCount"] == null)
        {
            Application["TotalPageCount"] = 0;
        }
        Application["TotalPageCount"] = (int)Application["TotalPageCount"] + 1;
    }
}
