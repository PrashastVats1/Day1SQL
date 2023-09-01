using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppErrorHandling
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblErrorMessage.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int dividend = int.Parse(TxtNumOne.Text);
                int divisor = int.Parse(TxtNumTwo.Text);
                int result = dividend / divisor; //this might cause a divide by zero exception
                LblErrorMessage.Text = "Result after division: " + result.ToString();
                //we can also throw a custom exception
                if (result > 5)
                {
                    throw new Exception("Result is greater than 5!");
                }
            }
            catch (DivideByZeroException ex)
            {
                //LblErrorMessage.Text = "Divide by zero error occured! " + ex.Message;
                Session["error"]= "Divide by zero error occured! " + ex.Message;
                Response.Redirect("Error.aspx");
            }
            catch (Exception ex)
            {
                //Handle other exceptions
                //Log the exception or display user-friendly message
                //You can also redirect to an error page
                //LblErrorMessage.Text = "An error occured! " + ex.Message;
                Session["error"] = "An error occured! " + ex.Message;
                Response.Redirect("Error.aspx");
            }
        }

        protected void BtnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("DataBinding.aspx");
        }
    }
}