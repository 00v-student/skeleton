using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrders
        clsOrders AnOrder = new clsOrders();

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.OrderDescription);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.OrderDate);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.OrderNumber);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.OrderTotal);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.StaffName);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.CustomerID);

        //get the data from the session object
        AnOrder = (clsOrders)Session["AnOrder"];
        //Dipslay the OrderDescription for this entry
        Response.Write(AnOrder.Active);
    }
}