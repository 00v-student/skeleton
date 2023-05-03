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
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "please select a record to edit from";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to Delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderDescription(txtEnterDesc.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataTextField = "OrderNumber";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderDescription("");
        txtEnterDesc.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataTextField = "OrderNumber";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }
}