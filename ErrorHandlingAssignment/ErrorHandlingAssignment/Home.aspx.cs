using System;
using System.Web.UI;

namespace WebAppErrorHandling
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblErrorMessage.Visible = false;
            }
        }
        protected void BtnAddition_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int num1 = int.Parse(TxtNumOne.Text);
                int num2 = int.Parse(TxtNumTwo.Text);
                int result = num1 + num2;
                LblErrorMessage.Text = "Result after addition: " + result.ToString();
                //we can also throw a custom exception
                if (result < 0)
                {
                    throw new Exception("Result must be positive!");
                }
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

        protected void BtnSubtraction_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int num1 = int.Parse(TxtNumOne.Text);
                int num2 = int.Parse(TxtNumTwo.Text);
                int result = num1 - num2;
                LblErrorMessage.Text = "Result after subtraction: " + result.ToString();
                //we can also throw a custom exception
                if (result < 0)
                {
                    throw new Exception("Result must be positive!");
                }
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

        protected void BtnMultiplication_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int num1 = int.Parse(TxtNumOne.Text);
                int num2 = int.Parse(TxtNumTwo.Text);
                int result = num1 * num2; //this might cause a divide by zero exception
                LblErrorMessage.Text = "Result after multiplication: " + result.ToString();
                //we can also throw a custom exception
                if (result < 0)
                {
                    throw new Exception("Result must be positive!");
                }
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

        protected void BtnDivision_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int dividend = int.Parse(TxtNumOne.Text);
                int divisor = int.Parse(TxtNumTwo.Text);
                int result = dividend / divisor; //this might cause a divide by zero exception
                LblErrorMessage.Text = "Result after division: " + result.ToString();
                //we can also throw a custom exception
                if (result > 100)
                {
                    throw new Exception("Result is greater than 5!");
                }
            }
            catch (DivideByZeroException ex)
            {
                //LblErrorMessage.Text = "Divide by zero error occured! " + ex.Message;
                Session["error"] = "Divide by zero error occured! " + ex.Message;
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

        protected void BtnExponential_Click(object sender, EventArgs e)
        {
            LblErrorMessage.Visible = true;
            try
            {
                int num1 = int.Parse(TxtNumOne.Text);
                int num2 = int.Parse(TxtNumTwo.Text);
                double result = Math.Pow(num1, num2); //this might cause a divide by zero exception
                LblErrorMessage.Text = "Result after division: " + result.ToString();
                //we can also throw a custom exception
                if (result < 1)
                {
                    throw new Exception("Result must be greater than 1!");
                }
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
