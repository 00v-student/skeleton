using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 watchid;
    protected void Page_Load(object sender, EventArgs e)
    {
        watchid = Convert.ToInt32(Session["watchid"]);
    }

    protected void yes_Click(object sender, EventArgs e)
    {
        clsStockCollection stockc = new clsStockCollection();
        stockc.ThisStock.Find(watchid);
        stockc.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void no_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    
}
}