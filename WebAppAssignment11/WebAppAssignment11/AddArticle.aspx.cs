using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebAppAssignment11
{
    public partial class AddArticle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddArticle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ContentDbConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into Articles values (@id,@title,@content,@publishdate)";
                cmd.Parameters.AddWithValue("@id", int.Parse(ArticleId.Text));
                cmd.Parameters.AddWithValue("@title", ArticleTitle.Text);
                cmd.Parameters.AddWithValue("@content", ArticleContent.Text);
                cmd.Parameters.AddWithValue("@publishdate", DateTime.Parse(PublishDate.Text));
                con.Open();
                cmd.ExecuteNonQuery();
                LblMsg.Text = "Article Added!!";
            }
            catch (Exception ex)
            {
                LblMsg.Text = "Error!! " + ex.Message;
            }
        }
    }
}