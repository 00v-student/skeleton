using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false)
        {
            if (OrderNumber != -1)
            {
                DisplayOrders();
            }
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrders.Find(OrderNumber);
        txtOrderNumber.Text = OrderBook.ThisOrders.OrderNumber.ToString();
        txtOrderDescription.Text = OrderBook.ThisOrders.OrderDescription.ToString();
        txtOrderTotal.Text = OrderBook.ThisOrders.OrderTotal.ToString();
        txtOrderDate.Text = OrderBook.ThisOrders.OrderDate.ToString();
        txtCustomerID.Text = OrderBook.ThisOrders.CustomerID.ToString();
        txtStaffName.Text = OrderBook.ThisOrders.StaffName.ToString();

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of the clsOrders
        clsOrders AnOrder = new clsOrders();
        //capture the Order Number
        string OrderNumber = txtOrderNumber.Text;
        //capture the Order description
        string OrderDescription = txtOrderDescription.Text;
        //capture the Order Total
        string OrderTotal = txtOrderTotal.Text;
        //capture the Order Date
        string OrderDate = txtOrderDate.Text;
        //capture the Customer ID
        string CustomerId = txtCustomerID.Text;

        //capture the Staff Name
        string StaffName = txtStaffName.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderNumber, OrderDescription, OrderTotal, OrderDate, CustomerId);
        if (Error == "")
        {
            AnOrder.OrderDescription = OrderDescription;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);

            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrders = AnOrder;
            OrderList.Add();

            Response.Redirect("OrderList.aspx");
        }
    }

    protected void txtStaffName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //Create an instance of the Order class
        clsOrders AnOrder = new clsOrders();
        //Variable to store the primary ke
        Int32 OrderNumber;
        //Variable to store the primary key
        Boolean Found = false;
        //Get the primary key entered by the user
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        //find the record
        Found = AnOrder.Find(OrderNumber);
        //if found
        if (Found == true)
        {
            //dipslay all values of the properties in the form
            txtOrderNumber.Text = Convert.ToString(AnOrder.OrderNumber);
            txtOrderDescription.Text = AnOrder.OrderDescription;
            txtOrderTotal.Text = Convert.ToString(AnOrder.OrderTotal);
            txtStaffName.Text = Convert.ToString(AnOrder.StaffName);
            txtOrderDate.Text = AnOrder.OrderDate.ToString();
            txtCustomerID.Text = Convert.ToString(AnOrder.CustomerID);
            chkOrderComplete.Checked = AnOrder.Active;
        }
    }
   }
