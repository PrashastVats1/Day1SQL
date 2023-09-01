using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppSecureSM.Secure
{
    public partial class CachingEx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Cache.Insert("CachedTime", DateTime.Now.ToLongTimeString(), null, DateTime.Now.AddMinutes(2), TimeSpan.Zero);
            }
        }
        public string GetCTime()
        {
            var cTime = Cache["CachedTime"];
            if (cTime == null)
            {
                return "Cached Time Not FOund!";
            }
            else
            {
                return cTime.ToString();
            }
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            LblCache.Text = GetCTime();
        }
    }
}