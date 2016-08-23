using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KelseyAbreuWebsite.Classes
{
    public class KelseyDAL : IDisposable
    {
        private SqlConnection scDatabaseConnection = null;

        public KelseyDAL()
        {
            //scDatabaseConnection = new SqlConnection("data source=desktop-pd3dkcn;initial catalog=KelseyWebsite;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");
            scDatabaseConnection = new SqlConnection("Data Source=198.71.225.146;Integrated Security=False;User ID=SORAKH2756;password=12Kabreu34!;Connect Timeout=15;Encrypt=False;Packet Size=4096");
        }

        public DataTable GetPlayers(string PageName)
        {
            DataTable dtPlayers = new DataTable();

            SqlCommand cmd = new SqlCommand("select * from players where sGameName = '" + PageName + "'",scDatabaseConnection);
            scDatabaseConnection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dtPlayers);
            scDatabaseConnection.Close();
            da.Dispose();

            return dtPlayers;
        }

        public int AddPlayers(string sInsertQueryString)
        {
            int iValuesAffected = 0;
            SqlCommand cmd = new SqlCommand(sInsertQueryString, scDatabaseConnection);
            scDatabaseConnection.Open();
            iValuesAffected = cmd.ExecuteNonQuery();
            scDatabaseConnection.Close();

            return iValuesAffected;
        }

        public int UpdatePlayers(string sEditedQueryString)
        {
            int iValuesAffected = 0;
            SqlCommand cmd = new SqlCommand(sEditedQueryString, scDatabaseConnection);
            scDatabaseConnection.Open();
            iValuesAffected = cmd.ExecuteNonQuery();
            scDatabaseConnection.Close();

            return iValuesAffected;
        }

        public void Dispose()
        {
            scDatabaseConnection.Close();
            scDatabaseConnection.Dispose();
        }
    }
}