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
// Added non-default call statemetns
using System.Data.OleDb;
using System.Net;
using System.Data;

public partial class frmSearchPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            // Retrieve search string (Employee Last Name)
            string strSearchQuery = txtSearchName.Text;

            // Throw error/exception if txtSearchName is empty
            if (strSearchQuery == String.Empty)
            {
                throw new Exception("Please enter a last name!");
            }
            else
            {
                // Server Transfer with search query
                Session["txtSearchName"] = strSearchQuery;
                Server.Transfer("frmViewPersonnel.aspx");
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
            Console.WriteLine(ex.Message);
        }
    }
}
