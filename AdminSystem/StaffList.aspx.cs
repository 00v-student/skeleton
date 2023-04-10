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
                DisplayStaff();
            
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff list
        clsStaffCollection StaffList = new clsStaffCollection();
        lstStaffList.DataSource = StaffList.StaffList;
        //set name of primary key
        lstStaffList.DataValueField = "StaffId";
        //data field to display
        lstStaffList.DataTextField = "Name";
        //bind data to list
        lstStaffList.DataBind();
    }

}