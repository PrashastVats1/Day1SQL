using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSecureSM
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblMsg.Visible = false;
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = true;
            if (string.IsNullOrEmpty(TxtUserName.Text) || string.IsNullOrEmpty(TxtUserPwd.Text))
            {
                LblMsg.Text = "Please provide User Name and Password!";
            }
            else
            {
                if((TxtUserName.Text == "sam") && (TxtUserPwd.Text == "sam@1234"))
                {
                    FormsAuthentication.RedirectFromLoginPage(TxtUserName.Text, true);
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    LblMsg.Text = "Either User Name or Password is incorrect!";
                }
            }
        }
    }
}