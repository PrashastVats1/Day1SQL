using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppOne
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblMsg.Text = "Welcome to ASP.Net";
            LblMsg.Text += "<br>User Name: " + TxtName.Text;
            LblMsg.Text += "<br>User password: " + TxtPwd.Text;
            LblMsg.Text += "<br>About Me<br>" + TxtAbout.Text;
        }
    }
}