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

}