using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class frmPersonnelVerified : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieves information from frmPersonnel
        txtVerifiedInfo.Text = Request["txtFirstName"] +
            "\n" + Request["txtLastName"] +
            "\n" + Request["txtPayRate"] +
            "\n" + Request["txtStartDate"] +
            "\n" + Request["txtEndDate"];

        
        // Display results of information save/failure
        if (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"), Session["txtFirstName"].ToString(), Session["txtLastName"].ToString(), 
            Session["txtPayRate"].ToString(), Session["txtStartDate"].ToString(), Session["txtEndDate"].ToString()))
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was successfully saved!";
        }
        else
        {
            txtVerifiedInfo.Text = txtVerifiedInfo.Text + "\nThe information was NOT saved.";
        }
    }
}
