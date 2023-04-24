using  System;
using  System.Collections.Generic;
using  System.Linq;
using  System.Web;
using  System.Web.UI;
using  System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // if first time page is displayed
        if (IsPostBack == false)
        {
            //populate the list of counties
            //DisplayCounties();
            //if this is not a new record

            //display the current data for the record
            DisplayStock();

        }
    }

    void DisplayStock()
    {
        //create an instance of the Stock list
        clsStockCollection StockList = new clsStockCollection();
        lstStockList.DataSource = StockList.StockList;
        //set name of primary key
        lstStockList.DataValueField = "watchid";
        //data field to display
        lstStockList.DataTextField = "desc";
        //bind data to list
        lstStockList.DataBind();
    }



    protected void BtnAdd_Click(object sender, System.EventArgs e)
    {
        Session["watchid"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void BtnEdit_Click(object sender, System.EventArgs e)
    {
        Int32 watchid;
        if (lstStockList.SelectedIndex != -1)
        {
            watchid = Convert.ToInt32(lstStockList.SelectedValue);
            Session["watchid"] = watchid;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError0.Text = "select a record to update";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        Int32 watchid;
        if (lstStockList.SelectedIndex != -1)
        {
            watchid = Convert.ToInt32(lstStockList.SelectedValue);
            Session["watchid"] = watchid;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError0.Text = "select a record to delete";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsStockCollection stocks = new clsStockCollection();
        stocks.ReportBytype(txttypearea.Text);
        lstStockList.DataSource = stocks.StockList;
        lstStockList.DataValueField = "watchid";
        lstStockList.DataTextField = "type";
        lstStockList.DataBind();
    }

    protected void clr_Click(object sender, EventArgs e)
    {
        clsStockCollection stocks = new clsStockCollection();
        stocks.ReportBytype("");
        txttypearea.Text = "";
        lstStockList.DataValueField = "watchid";
        lstStockList.DataTextField = "type";
        lstStockList.DataBind();
    }
}

   