using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrders();

        }
    }

    void DisplayOrders()
    {
        //create an instance of the OrderCollection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of Orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderDescription";
        lstOrderList.DataValueField = "OrderTotal";
        lstOrderList.DataBind();

        }



    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNumber"] = -1;
        Response.Redirect("OrderDataEntry");
    }
}