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
        clsStaff AStaff = new clsStaff();
        AStaff.Name = txtName.Text;
        AStaff.Department = ddlDepartment.SelectedValue;
        AStaff.ContactNumber = txtContactNumber.Text;
        // AStaff.StaffID = txtStaffID.??;   Doesnt work, what should alt be?
        AStaff.WeekendAvailability = chkWeekendAvailability.Checked;
        // AStaff.HireDate = txtHireDate.??;

        Session["AStaff"] = AStaff; //store the newly instantiated AStaff object in the session object
        Response.Redirect("StaffViewer.aspx"); //when OK clicked, response: redirect to this page
    }
}