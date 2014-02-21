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
//using AdminAplication.Model;
using System.Collections.Generic;
using AdminAplication.Data;

namespace AdminAplication
{
    public partial class _Default : System.Web.UI.Page
    {
        //public Data.EmployeeMaster CurrentEmployee
        //{
        //    get
        //    {
        //        Data.EmployeeMaster userDetail = new Data.EmployeeMaster();

        //        userDetail.EmployeeName = loginUsername.Text.Trim().Replace("'", "").Replace("=", "").Replace(";", "");
        //        userDetail.password = loginPass.Text.Trim().Replace("'", "").Replace("=", "").Replace(";", "");
        //        return userDetail;
        //    }
        //}

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginSubmit_Click(object sender, EventArgs e)
        {
            //DataStorageModel obj = new DataStorageModel();

            //var user = obj.VadlidateUser(CurrentEmployee);
            //if (user == null)
            //{
            //    lblMsg.Text = "Invalid User / Password.";
            //    return;
            //}
            //int? userrole = user.Roleid;

            //if (userrole == null)
            //{
            //    lblMsg.Text = "User don't have role to access.";
            //    return;
            //}


            //List<FunctionalitiesManage> functionalities = obj.GetRoleFunctionality(userrole.Value, true);
            //SessionState.Functionalities = functionalities;
            //SessionState.UserName = CurrentEmployee.EmployeeName;
            //SessionState.LastLogin = user.lastlogin;
            //Response.Redirect("Layout.aspx");
        }
    }
}
