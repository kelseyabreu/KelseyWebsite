using KelseyAbreuWebsite.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KelseyAbreuWebsite
{
    public partial class BoardGames : GameCounterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dgPlayerList.DataSource = PlayerFileHandler.GetPlayers(Request.QueryString["g"].ToLower());
            dgPlayerList.DataBind();

            hGameName.InnerHtml = Request.QueryString["g"];
        }

        protected void btnSavePlayers_Click(object sender, EventArgs e)
        {
            base.SavePlayers(hfPlayerStats.Value.Split(';'));
            Response.Redirect(Request.RawUrl);
        }
    }
}