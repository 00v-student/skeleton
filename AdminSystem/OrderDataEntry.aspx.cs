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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsOrders
        clsOrders AnOrder = new clsOrders();

        //capture the Order Number
        AnOrder.OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    

        //capture the Order description
        AnOrder.OrderDescription = txtOrderDescription.Text;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the Order Date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the Order Total
        AnOrder.OrderTotal = Convert.ToInt32(txtOrderTotal.Text);
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the Order Complete
        AnOrder.Active = chkOrderComplete.Checked;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the Customer ID
        AnOrder.CustomerID = Convert.ToInt32(txtOrderTotal.Text);
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

        //capture the Staff Name
        AnOrder.StaffName = txtOrderDescription.Text;
        //store the address in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }

    protected void txtStaffName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
}