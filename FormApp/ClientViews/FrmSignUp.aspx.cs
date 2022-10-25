using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace FormApp.ClientViews
{
    public partial class FrmSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                ChargeDdlCountry();
                ChargeDdlSex();
            }
            
        }
        private void ChargeDdlCountry()
        {
            DdlCountry.Items.Add("Argentina");
            DdlCountry.Items.Add("Uruaguay");
            DdlCountry.Items.Add("Brasil");
            DdlCountry.Items.Add("Chile");
            DdlCountry.Items.Add("Peru");
            DdlCountry.Items.Add("Bolivia");
            DdlCountry.Items.Add("Paraguay");
            DdlCountry.Items.Add("Ecuador");
            DdlCountry.Items.Add("El Salvador");
            DdlCountry.Items.Add("Panama");
            DdlCountry.Items.Add("Venezuela");
        }
    
        public void ChargeDdlSex()
        {
            SexData sexData = new SexData();
            try
            {
                DdlSex.DataSource = sexData.Listing();
                DdlSex.DataValueField = "Id";
                DdlSex.DataTextField = "Description";
                DdlSex.DataBind();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            UserData userData = new UserData();
            User user = new User();
            try
            {
               
                    user.UserName = TxtUserName.Text;
                    user.UserSubName = TxtUserSubName.Text;
                    user.UserMail = TxtUserMail.Text;
                    user.UserPass = TxtUserPass.Text;
                    user.SexType.Id = int.Parse(DdlSex.SelectedItem.Value.ToString());
                    user.Country = DdlCountry.SelectedItem.Value.ToString();
                    user.BornDate = Convert.ToDateTime(TxtBornDate.Text);
                    userData.InsertSP(user);
                    Response.Redirect("FrmLogin.aspx", false);
                
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        
       
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmLogin.aspx", false);
        }
    }
}