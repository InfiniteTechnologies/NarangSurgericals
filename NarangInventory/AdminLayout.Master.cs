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
using AdminAplication.Data;

namespace AdminAplication
{
    public partial class AdminLayout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //CreateMenu();
        }

        //protected void CreateMenu()
        //{

        //    lblLastLogin.Text = SessionState.LastLogin == null ? "" : SessionState.LastLogin.Value.ToString("dd/MM/yyyy hh:mm:ss");
        //    lblCurrentUser.Text = SessionState.UserName;

        //    if (SessionState.Functionalities.Count > 0)
        //    {
        //        HtmlGenericControl ul = new HtmlGenericControl("ul");
        //        ul.Attributes.Add("class", "menu");
        //        foreach (var item in SessionState.Functionalities.Where(w => w.FunctionalityParentID == 0).ToList())
        //        {
        //            HyperLink link = new HyperLink();
        //            link.ID = item.FunctionalityID.ToString();
        //            link.Text = item.PageName;
        //            link.NavigateUrl = item.PageURL;

        //            HtmlGenericControl li = new HtmlGenericControl("li");
        //            li.Controls.Add(link);

        //            HtmlGenericControl subul = new HtmlGenericControl("ul");
        //            bool Issub = false;
        //            foreach (var subItem in SessionState.Functionalities.Where(w => w.FunctionalityParentID == item.FunctionalityID).ToList())
        //            {
        //                HyperLink sublink = new HyperLink();
        //                sublink.ID = subItem.FunctionalityID.ToString();
        //                sublink.Text = subItem.PageName;
        //                sublink.NavigateUrl = subItem.PageURL;

        //                HtmlGenericControl subli = new HtmlGenericControl("li");
        //                subli.Controls.Add(sublink);
        //                subul.Controls.Add(subli);
        //                Issub = true;
        //            }

        //            if (Issub)
        //                li.Controls.Add(subul);

        //            ul.Controls.Add(li);
        //        }
        //        HtmlGenericControl navDiv = new HtmlGenericControl("div");
        //        navDiv.Attributes.Add("id", "nav");

        //        navDiv.Controls.Add(ul);
        //        dvMenu.Controls.Add(navDiv);
                
        //    }
        //    else
        //    {
        //        Response.Redirect("Default.aspx");
        //    }
        //}
    }
}
