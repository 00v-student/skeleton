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
        String watchid =(txtWatchID.Text);
        String desc= txtDesc.Text;
        String price =(txtPrice.Text);
        String dateadd =(txtDateAdded.Text);
        String stock = (txtStock.Text);
        String type = txtType.Text;
        String avail = available.Text;
        Session["astock"] = astock;
        Response.Redirect("StockViewer.aspx");
        String err = "";
        err = astock.Valid(desc, price, dateadd, stock, type);
        if (err == "")
        {

            astock.watchid = int.Parse(txtWatchID.Text);
            astock.desc = txtDesc.Text;
            astock.price = decimal.Parse(txtPrice.Text);
            astock.dateadd = DateTime.Parse(txtDateAdded.Text);
            astock.stock = int.Parse(txtStock.Text);
            astock.type = txtType.Text;
            astock.available = available.Checked;
            Session["astock"] = astock;
            Response.Redirect("StockViewer.aspx");
        }
        else lblError.Text = err;
    }

    



    protected void Buttonfind_Click(object sender, EventArgs e)
    {
        clsStock AStock = new clsStock();

        // variable to store the primary key

        Int32 watchid;

        //variable to store the result of the find operation

        Boolean Found = false;

        // get the primary key entered by the user

        watchid = Convert.ToInt32(txtWatchID.Text);

        //find the record

        Found = AStock.Find(watchid);

        //  if found

        if (Found == true)
        {

            //display the values of the properties in the form

            txtDesc.Text = AStock.desc;

            txtPrice.Text = Convert.ToString(AStock.price);

            txtStock.Text = Convert.ToString(AStock.stock);

            txtType.Text = AStock.type;

            txtDateAdded.Text = AStock.dateadd.ToString();

            available.Checked = AStock.available;
        }
    }
}