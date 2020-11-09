using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClient
{
    class db
    {
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=accounts.db;Version=3;New=False;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {

            }
            return sqlite_conn;
        }
       public static List<string> ReadData()
        {
            SQLiteConnection conn=CreateConnection();
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT playerId,nmDeviceKey,deviceKey FROM data";
            var res=new List<string>();
            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())
            {
                string myreader = sqlite_datareader.GetString(0)+","+sqlite_datareader.GetString(1)+","+sqlite_datareader.GetString(2);
                res.Add(myreader);
            }
            conn.Close();
            return res;
        }
    }
}
