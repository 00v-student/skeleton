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
        //if (StaffId == -1)
       // {
            //add the new record
            Add();
       // }
       // else
       // {
            //update the record
            //Update();
        //}
        //clsStaff AStaff = new clsStaff();
        //AStaff.Name = txtName.Text;
        //AStaff.Department = ddlDepartment.SelectedValue;
        //AStaff.ContactNumber = txtContactNumber.Text;
        //AStaff.StaffId = txtStaffID.Short;   
        //AStaff.WeekendAvailability = chkWeekendAvailability.Checked;
        //AStaff.HireDate = txtHireDate.System.Date.Time;

        //Session["AStaff"] = AStaff; //store the newly instantiated AStaff object in the session object
        //Response.Redirect("StaffViewer.aspx"); //when OK clicked, response: redirect to this page
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the address book
        clsStaffCollection StaffList = new clsStaffCollection();
        //validate the data on the web form
        String Error = StaffList.ThisStaff.Valid(txtName.Text, txtDepartment.Text, txtHireDate.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffList.ThisStaff.HouseNo = txtHouseNo.Text;
            StaffList.ThisStaff.Street = txtStreet.Text;
            StaffList.ThisStaff.Town = txtTown.Text;
            AddressBook.ThisStaff.PostCode = txtPostCode.Text;
            StaffList.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            AddressBook.ThisStaff.Active = chkWeekendAvailability.Checked;
            AddressBook.ThisStaff.CountyNo = Convert.ToInt32(ddlCounty.SelectedValue);
            //add the record
            AddressBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }
}