using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppAssignment10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!Page.IsPostBack)
            {
                PrCategory.Items.Add("Cars");
                PrCategory.Items.Add("Electronic-Gaming");
                PrCategory.Items.Add("Sports");
            }
        }

        protected void BtnRegPr_Click(object sender, EventArgs e)
        {
            LblInfo.Text = "Product Registered Successfully, Details are as follows: ";
            LblInfo.Text += "<br>Product Name: " + PrName.Text;
            LblInfo.Text += "<br>Product Category: " + PrCategory.Text;
            LblInfo.Text += "<br>Product Price: " + PrPrice.Text;
            LblInfo.Text += "<br>Product Description: " + PrDescription.Text;
            LblInfo.Text += "<br>Product Release Date: " + PrRD.SelectedDate;
        }
    }
}