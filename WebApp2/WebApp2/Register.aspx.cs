using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp2
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LblInfo.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblInfo.Visible=true;
            LblInfo.Text = "Registration Success!!";
            LblInfo.Text += "<br />Name: " + TxtName.Text;
            LblInfo.Text += "<br />Password: " + TxtPwd.Text;
            LblInfo.Text += "<br />Email: " + TxtEmail.Text;
            LblInfo.Text += "<br />Pin Code: " + TxtPinCode.Text;
            LblInfo.Text += "<br />Age: " + TxtAge.Text;
            LblInfo.Text += "<br />Date of Joining: " + CalDOJ.SelectedDate;
        }
    }
}