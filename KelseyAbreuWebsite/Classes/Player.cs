using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KelseyAbreuWebsite.Classes
{
    [Serializable]
    public class Player
    {
        public string Name { get; set; }
        public string PlayerID { get;  set; }
        public int TotalGames { get; set; }
        public int TotalWins { get; set; }

        //public void calculate_elo(pageInstance)
        //{
        //    var numbPlayersTeam1 = 1;
        //    var numbPlayersTeam2 = 1;

        //    var pt1 = document.getElementById("npt1" + pageInstance);
        //    numbPlayersTeam1 = pt1.selectedIndex + 1;
        //    var pt2 = document.getElementById("npt2" + pageInstance);
        //    numbPlayersTeam2 = pt2.selectedIndex + 1;

        //    var rA = 0;
        //    for (i = 0; i < numbPlayersTeam1; i++)
        //        rA += getRating(i, 1, pageInstance);

        //    rA = Math.abs(rA / numbPlayersTeam1);
        //    var rB = 0;
        //    for (i = 0; i < numbPlayersTeam2; i++)
        //        rB += getRating(i, 2, pageInstance);

        //    rB = Math.Abs(rB / numbPlayersTeam2);
        //    var kF = 16;
        //    var fW1 = Math.Max(Math.Min((rB - rA) / 400, 1), -1);
        //    var fW2 = Math.Max(Math.Min((rA - rB) / 400, 1), -1);
        //    var fW1P = Math.Round(Math.Max(kF * (1 + fW1), 1));
        //    var fW2P = Math.Round(Math.Max(kF * (1 + fW2), 1));
        //    var maxPlrs = numbPlayersTeam1 > numbPlayersTeam2 ? numbPlayersTeam1 : numbPlayersTeam2;
        //    for (i = 0; i < maxPlrs; i++)
        //    {
        //        if (i < numbPlayersTeam1)
        //        {
        //            var curRate = parseInt(getRating(i, 1, pageInstance));
        //            var deltaW1 = Math.round(Math.max(fW1P / numbPlayersTeam1, 1)) * 1;
        //            var deltaW2 = Math.round(Math.max(fW2P / numbPlayersTeam1, 1)) * -1;

        //            setRating(i + 1, 1, 1, curRate, deltaW1, pageInstance);
        //            setRating(i + 1, 1, 2, curRate, deltaW2, pageInstance);
        //        }
        //        if (i < numbPlayersTeam2)
        //        {
        //            var curRate = parseInt(getRating(i, 2, pageInstance));
        //            var deltaW1 = Math.round(Math.max(fW1P / numbPlayersTeam2, 1)) * -1;
        //            var deltaW2 = Math.round(Math.max(fW2P / numbPlayersTeam2, 1)) * 1;

        //            setRating(i + 1, 2, 1, curRate, deltaW1, pageInstance);
        //            setRating(i + 1, 2, 2, curRate, deltaW2, pageInstance);
        //        }
        //    }
        //}

        ////gets the ratings associated with each player
        //public int getRating(plrNo, teamNo, pageInstance)
        //{
        //    var rating = document.getElementById("rt" + teamNo + "" + plrNo + "-" + pageInstance).value;

        //    var org = rating;

        //    rating++;
        //    rating--;

        //    if (rating > 9000)
        //    {
        //        rating = 9000;
        //    }

        //    if (rating < 0 || isNaN(rating))
        //    {
        //        rating = 0;
        //    }

        //    if (rating + "" != org || org == "")
        //        document.getElementById("rt" + teamNo + "" + plrNo + "-" + pageInstance).value = rating;

        //    return Math.abs(rating);
        //}

        ////All this does is set the ratings to the players
        //public void setRating(plrNo, teamNo, resultInst, rate, delta, pageInstance)
        //{

        //    var value = rate + delta;

        //    if (delta > 0)
        //        value += " (+" + delta + ")";
        //    else
        //        value += " (" + delta + ")";

        //    document.getElementById("r" + teamNo + "" + resultInst + (plrNo - 1) + "-" + pageInstance).innerHTML = value;
        //}

    }
}