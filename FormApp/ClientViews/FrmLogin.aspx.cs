using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using DomainModel;

namespace FormApp.ClientViews
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            UserData userD = new UserData();
            User user = userD.ListingSP().Find(x => x.UserMail == TxtUserMail.Text && x.UserPass == TxtUserPass.Text);
            if (user != null)
            {
                Session.Add("IdUser", user.Id);
                Response.Redirect("FrmHome.aspx", false);
            }
            else
            {
                TxtUserMail.Text = "";
                TxtUserPass.Text = "";
                LblWarning.Text = "Vuelve a Intentarlo";
            }
                
        }

        protected void BtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmSignUp.aspx");
        }
    }
}