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

public partial class frmMain : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Makes call to class to save user activity
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel");
    }
}
