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
        clsStaff AStaff = new clsStaff();
        AStaff = (clsStaff) Session["AStaff"]; //get the data from the session object and assign it to
                                               //the newly instantiated AStaff object
        Response.Write(AStaff.Name); //display the name on the page
        Response.Write(AStaff.Department);
        Response.Write(AStaff.ContactNumber);


    }
}