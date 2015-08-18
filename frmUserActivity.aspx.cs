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

public partial class frmUserActivity : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            // Declares the DataSet
            dsUserActivity myDataSet = new dsUserActivity();

            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.mdb"));

            // Sets the DataGrid to the DataSource based on the table
            grdUserActivity.DataSource = myDataSet.Tables["tblUserActivity"];

            // Binds the DataGrid
            grdUserActivity.DataBind();
        }
    }
    protected void grdUserActivity_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
