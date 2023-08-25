using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebAppMasterPage
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["CustDbConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Customer values (@id,@name,@city,@odlimit)";
                cmd.Parameters.AddWithValue("@id",int.Parse(TxtCustId.Text));
                cmd.Parameters.AddWithValue("@name", TxtCustName.Text);
                cmd.Parameters.AddWithValue("@city", TxtCustCity.Text);
                cmd.Parameters.AddWithValue("@odlimit", double.Parse(TxtCustODLimit.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Registration Success!!";
            }
            catch (Exception ex)
            {
                LblMsg.Text = "Error!! " + ex.Message;
            }
        }
    }
}