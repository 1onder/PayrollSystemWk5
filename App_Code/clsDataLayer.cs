using System;
using System.Data;
using System.Configuration;
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

/// <summary>
/// Summary description for clsDataLayer
/// </summary>
public class clsDataLayer
{
    // This function saves the personnel data
    public static bool SavePersonnel(string Database, string FirstName, string LastName, string PayRate, string StartDate, string EndDate)
    {
        bool recordSaved;

        // Create new transaction
        OleDbTransaction myTransaction = null;

        try
        {
            // Instantiate connection to database and declare command and string variables
            OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Database);
            conn.Open();
            OleDbCommand command = conn.CreateCommand();
            string strSQL;

            // Transaction boundary
            myTransaction = conn.BeginTransaction();
            command.Transaction = myTransaction;

            // Insert statement for table personnel: with passed information 
            strSQL = "Insert into tblPersonnel " + "(FirstName, LastName) values ('" + FirstName + "', '" + LastName + "')";

            // Allow command variable to accept the text command
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Execute the insert statement
            command.ExecuteNonQuery();

            // Update/Add to tblPersonnel table
            strSQL = "Update tblPersonnel " + "Set PayRate=" + PayRate + ", " + "StartDate='" + StartDate + "', " +
                "EndDate='" + EndDate + "' " + "Where ID=(Select Max(ID) From tblPersonnel)";

            // Allow command variable to accept the text command
            command.CommandType = CommandType.Text;
            command.CommandText = strSQL;

            // Execute the insert statement
            command.ExecuteNonQuery();

            // Closes transaction boundary (implements rollback if failed)
            myTransaction.Commit();

            // Close Connection to database
            conn.Close();
            recordSaved = true;
        }
        catch (Exception ex)
        {
            // rollback upon exception
            myTransaction.Rollback();

            recordSaved = false;
        }

        return recordSaved;
    }

    // This function gets the user activity from the tblUserActivity table
    public static dsUserActivity GetUserActivity(string Database)
    {
        // Simplified Classes Being Used
        dsUserActivity DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Defines sqlConn Class (OleDbConnection) with provided arguments
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // Defines sqlDA Class (OleDbDataAdapter) with provided arguments, selecting all from table user activity
        sqlDA = new OleDbDataAdapter("select * from tblUserActivity", sqlConn);

        // Defines DS Class (dsUserActivity)
        DS = new dsUserActivity();

        // Outputs the results from the information gathered
        sqlDA.Fill(DS.tblUserActivity);

        // Returns the variable DS (dsUserActivity)
        return DS;
    }

    // This function saves the user activity
    public static void SaveUserActivity(string Database, string FormAccessed)
    {
        // Defines the connection to the database
        OleDbConnection conn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);
        conn.Open();
        OleDbCommand command = conn.CreateCommand();
        string strSQL;

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" +
            GetIP4Address() + "', '" + FormAccessed + "')";

        command.CommandType = CommandType.Text;
        command.CommandText = strSQL;
        command.ExecuteNonQuery();
        conn.Close();
    }

    // This function gets the personnel information from the tblPersonnel table
    public static dsPersonnel GetPersonnel(string Database, string Search)
    {
        // Simplified Classes Being Used
        dsPersonnel DS;
        OleDbConnection sqlConn;
        OleDbDataAdapter sqlDA;

        // Defines sqlConn Class (OleDbConnection) with provided arguments
        sqlConn = new OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=" + Database);

        // Added search function
        string strSearchQuery = Search;

        // If there is a search
        if (strSearchQuery == "")
        {
            // Defines sqlDA Class (OleDbDataAdapter) with provided arguments, selecting all from table personnel
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel", sqlConn);
        }
        else
        {
            // Creates new data adapter for search query
            sqlDA = new OleDbDataAdapter("select * from tblPersonnel where LastName = '" + strSearchQuery + "'", sqlConn);
        }

        // Defines DS Class (dsPersonnel)
        DS = new dsPersonnel();

        // Outputs the results from the information gathered
        sqlDA.Fill(DS.tblPersonnel);

        // Returns the variable DS (dsPersonnel)
        return DS;
    }

    // This function gets the IP Address
    public static string GetIP4Address()
    {
        string IP4Address = string.Empty;

        foreach (IPAddress IPA in
                    Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        if (IP4Address != string.Empty)
        {
            return IP4Address;
        }

        foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
        {
            if (IPA.AddressFamily.ToString() == "InterNetwork")
            {
                IP4Address = IPA.ToString();
                break;
            }
        }

        return IP4Address;
    }

	public clsDataLayer()
	{
		//
		// TODO: Add constructor logic here
		//
	}
}
