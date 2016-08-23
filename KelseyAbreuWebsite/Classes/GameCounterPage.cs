using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KelseyAbreuWebsite.Classes
{
    public class GameCounterPage : System.Web.UI.Page
    {
        public List<Player> SavePlayers(string[] DelimitedPlayers)
        {
            List<Player> lpPlayerList = new List<Player>();
            for (int i = 0; i < DelimitedPlayers.Length; i++)
            {
                string[] PlayerFields = DelimitedPlayers[i].Split('|');
                if (!String.IsNullOrWhiteSpace(PlayerFields[0]))
                    lpPlayerList.Add(new Player() { Name = PlayerFields[0], TotalGames = Convert.ToInt32(PlayerFields[1]), TotalWins = Convert.ToInt32(PlayerFields[2]), PlayerID = PlayerFields[3] });
            }
            PlayerFileHandler.WritePlayers(Request.QueryString["g"].ToLower(), lpPlayerList);

            return lpPlayerList;
        }
    }
}