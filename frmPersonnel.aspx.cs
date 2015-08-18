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

public partial class frmPersonnel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Test Controls
        bool nameTestFirst = false;
        bool nameTestLast = false;
        bool payTest = false;
        bool dateTestStart = false;
        bool dateTestEnd = false;
        bool dateTest = false;

        // Clear Error Information
        lblErrorInformation.Text = "";
        lblError.Text = "";

        // General Error (lblError)
        if (txtFirstName.Text == "" | txtLastName.Text == "" | txtPayRate.Text == "" | txtStartDate.Text == "" | txtEndDate.Text == "")
        {
            lblError.Text = "There was an error: Please correct the highlighted textfield(s).";
        }

        // Detailed Errors(lblErrorInformation)
        // Detailed Error - First name
        if (string.IsNullOrEmpty((txtFirstName.Text ?? string.Empty).Trim()))
        {
            lblErrorInformation.Text += "<br />" + "Please Enter a First Name!";
            nameTestFirst = false;
            txtFirstName.BackColor = System.Drawing.Color.Yellow;
        }
        else
        {
            txtFirstName.BackColor = System.Drawing.Color.White;
            nameTestFirst = true;
        }

        // Detailed Error - Last name
        if (string.IsNullOrEmpty((txtLastName.Text ?? string.Empty).Trim()))
        {
            lblErrorInformation.Text += "<br />" + "Please Enter a Last Name!";
            nameTestLast = false;
            txtLastName.BackColor = System.Drawing.Color.Yellow;
        }
        else
        {
            txtLastName.BackColor = System.Drawing.Color.White;
            nameTestLast = true;
        }

        // Detailed Error - Pay Rate
        if (string.IsNullOrEmpty((txtPayRate.Text ?? string.Empty).Trim()))
        {
            lblErrorInformation.Text += "<br />" + "Please Enter a Pay Rate!";
            payTest = false;
            txtPayRate.BackColor = System.Drawing.Color.Yellow;
        }
        else 
        {
            txtPayRate.BackColor = System.Drawing.Color.White;

            // Test if integer, else show error
            double test;
            payTest = double.TryParse(txtPayRate.Text, out test);

            if (payTest == false)
            {
                txtPayRate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "There was an error: Please correct the highlighted textfield(s).";
                lblErrorInformation.Text += "<br />" + "Please Enter a Correct Pay Rate!";
            }
            
        }

        // Detailed Error - Start Date
        if (string.IsNullOrEmpty((txtStartDate.Text ?? string.Empty).Trim()))
        {
            lblErrorInformation.Text += "<br />" + "Please Enter a Start Date!";
            dateTestStart = false;
            txtStartDate.BackColor = System.Drawing.Color.Yellow;
        }
        else
        {
            DateTime test;
            if (DateTime.TryParse(txtStartDate.Text, out test))
            {
                dateTestStart = true;
                txtStartDate.BackColor = System.Drawing.Color.White;
            }
            else
            {
                dateTestStart = false;
                txtStartDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "There was an error: Please correct the highlighted textfield(s).";
                lblErrorInformation.Text += "<br />" + "Please Enter a Correct Date Format (Start Date)!";
            }


        }

        // Detailed Error - End Date
        if (string.IsNullOrEmpty((txtEndDate.Text ?? string.Empty).Trim()))
        {
            lblErrorInformation.Text += "<br />" + "Please Enter an End Date!";
            dateTestEnd = false;
            txtEndDate.BackColor = System.Drawing.Color.Yellow;
        }
        else
        {
            DateTime test;
            if (DateTime.TryParse(txtEndDate.Text, out test))
            {
                dateTestEnd = true;
                txtEndDate.BackColor = System.Drawing.Color.White;
            }
            else
            {
                dateTestEnd = false;
                txtEndDate.BackColor = System.Drawing.Color.Yellow;
                lblError.Text = "There was an error: Please correct the highlighted textfield(s).";
                lblErrorInformation.Text += "<br />" + "Please Enter a Correct Date Format (End Date)!";
            }
        }

        if (dateTestStart == true & dateTestEnd == true)
        {
            try
            {
                // Test for correct DateTime Entry
                DateTime test;
                if (DateTime.TryParse(txtStartDate.Text, out test) & DateTime.TryParse(txtEndDate.Text, out test))
                {
                    // Convert.ToInt32(_payRate);
                    DateTime dateObjOne = DateTime.Parse(txtStartDate.Text);
                    DateTime dateObjTwo = DateTime.Parse(txtEndDate.Text);

                    // Test to see if start date is not greater than the end date
                    if (DateTime.Compare(dateObjOne, dateObjTwo) > 0)
                    {
                        txtStartDate.BackColor = System.Drawing.Color.Yellow;
                        txtEndDate.BackColor = System.Drawing.Color.Yellow;
                        lblError.Text = "There was an error: Please correct the highlighted textfield(s).";
                        lblErrorInformation.Text += "<br />" + "Start Date Cannot be Greater than the End Date!";
                        dateTest = false;
                    }
                    else
                    {
                        // Test Success
                        dateTest = true;
                    }
                }
                else
                {
                    dateTest = false;
                }
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("Cannot read ProblemProperty, problem is null. \n" + nre.Message);
                dateTest = false;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("{0} is not a DateTime variable. \n" + fe.Message);
                dateTest = false;
            }
        }

        if (nameTestFirst == true & nameTestLast == true & payTest == true & dateTest == true)
        {
            // Get values from data entry fields and set session states for them
            Session["txtFirstName"] = txtFirstName.Text;
            Session["txtLastName"] = txtLastName.Text;
            Session["txtPayRate"] = txtPayRate.Text;
            Session["txtStartDate"] = txtStartDate.Text;
            Session["txtEndDate"] = txtEndDate.Text;

            // Server Transfer with information entered
            Server.Transfer("frmPersonnelVerified.aspx");
        }
    }
}
