using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock astock = new clsStock();
        astock.desc= txtDesc.Text;
        astock.price = float.Parse(txtPrice.Text);
        astock.dateadd = DateTime.Parse(txtDateAdded.Text);
        astock.stock = int.Parse(txtStock.Text);
        astock.type = txtType.Text;
        astock.available = available.Checked;
        Session["astock"] = astock;
        Response.Redirect("StockViewer.aspx");
    }
}