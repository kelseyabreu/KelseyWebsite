using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;

namespace KelseyAbreuWebsite.Classes
{
    public static class PlayerFileHandler
    {
        public static List<Player> GetPlayers(string PageName)
        {
            //return GetPlayersByFile(PageName);
            return GetPlayersByDB(PageName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PageName">pagename string to appropriately find file</param>
        /// <returns></returns>
        public static List<Player> GetPlayersByFile(string PageName)
        {
            List<Player> lpPlayers = new List<Player>();
            try {
                using (Stream stream = File.Open(System.Web.HttpContext.Current.Server.MapPath("~/GameRecords/" + PageName + "_PlayerScores.serial"), FileMode.Open))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    lpPlayers = (List<Player>)binaryFormatter.Deserialize(stream);
                }
            }
            catch (FileNotFoundException ex)
            {

            }

            return lpPlayers;
        }

        public static List<Player> GetPlayersByDB(string PageName)
        {
            List<Player> lpPlayers = new List<Player>();
            KelseyDAL kelseyDAL = new KelseyDAL();
            DataTable dtPlayers = kelseyDAL.GetPlayers(PageName);

            foreach(DataRow drPlayer in dtPlayers.Rows)
            {
                lpPlayers.Add(LoadPlayer(drPlayer));
            }
            return lpPlayers;
        }

        public static Player LoadPlayer(DataRow drPlayer)
        {
            Player currentPlayer = new Player();

            currentPlayer.Name = drPlayer["sPlayerName"].ToString();
            currentPlayer.PlayerID = drPlayer["uPlayerID"].ToString();
            currentPlayer.TotalGames = Convert.ToInt32(drPlayer["iTotalGames"].ToString());
            currentPlayer.TotalWins = Convert.ToInt32(drPlayer["iTotalWins"].ToString());

            return currentPlayer;
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PageName">pagename string to appropriately name file</param>
        /// <param name="Players">List of Players to save</param>
        public static string WritePlayers(string PageName,List<Player> Players)
        {
            //return WritePlayersToFile(PageName, Players);

            return WritePlayersToDB(PageName, Players);
        }

        private static string WritePlayersToFile(string PageName, List<Player> Players)
        {
            string sSuccess = "success";
            try
            {
                using (Stream stream = File.Open(System.Web.HttpContext.Current.Server.MapPath("~/GameRecords/" + PageName + "_PlayerScores.serial"), FileMode.Create))
                {
                    var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    binaryFormatter.Serialize(stream, Players);
                }
            }
            catch (Exception ex)
            {
                sSuccess = ex.Message;
            }

            return sSuccess;
        }

        private static string WritePlayersToDB(string PageName, List<Player> Players)
        {
            string sSuccess = "success";
            string sInsertQueryString = "INSERT INTO PLAYERS (sPlayerName,iTotalWins,iTotalGames,sGameName) VALUES ";
            string sEditedQueryString = "";
            KelseyDAL kelseyDAL = new KelseyDAL();

            IEnumerable<Player> NewPlayers    = Players.Where(x => x.PlayerID == "");
            IEnumerable<Player> EditedPlayers = Players.Where(x => x.PlayerID != "");

            foreach (Player currentPlayer in NewPlayers)
            {
                sInsertQueryString += "('" + currentPlayer.Name + "'," + currentPlayer.TotalWins + "," + currentPlayer.TotalGames + ",'" + PageName + "'),";
            }
            sInsertQueryString = sInsertQueryString.Substring(0, sInsertQueryString.Length - 1)+";";

            if(NewPlayers.Count() > 0)
                kelseyDAL.AddPlayers(sInsertQueryString);

            foreach(Player currentPlayer in EditedPlayers)
            {
                sEditedQueryString += "UPDATE PLAYERS SET sPlayerName='"+currentPlayer.Name+"',iTotalWins ="+currentPlayer.TotalWins+" , iTotalGames = "+currentPlayer.TotalGames+" WHERE uPlayerID = '"+currentPlayer.PlayerID+"' AND sGameName ='"+PageName+"'; \n";
            }

            if(EditedPlayers.Count() > 0)
                kelseyDAL.UpdatePlayers(sEditedQueryString);

            return sSuccess;
        }
    }
}