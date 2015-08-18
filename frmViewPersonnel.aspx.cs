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

public partial class frmViewPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Retrieve search query
        string strSearchQuery = Request["txtSearchName"];

        if (!Page.IsPostBack)
        {
            //Declare the DataSet
            dsPersonnel myDataSet = new dsPersonnel();

            // Default no search string upon load
            if (strSearchQuery == null)
            {
                strSearchQuery = "";
            }

            // Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"), strSearchQuery.Trim());

            // Set the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables["tblPersonnel"];

            // Bind the DataGrid
            grdViewPersonnel.DataBind();
        }
    }
}
