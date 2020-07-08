using System;
using dnc4.Models;
using MySql.Data.MySqlClient;

namespace dnc4
{
  public class db
  {
    public static tablo1 Get()
    {
      var ret = new tablo1();
      string ConnectionString = "server=sql3.freesqldatabase.com;port=3306;database=sql3353547;user=sql3353547;password=LgQDWrzlk2;";
      using (MySqlConnection conn = new MySqlConnection(ConnectionString))
      {
        conn.Open();
        MySqlCommand cmd = new MySqlCommand("select * from tablo1", conn);
        using (var reader = cmd.ExecuteReader())
        {
          while (reader.Read())
          {
            ret.Name = reader["Name"].ToString();
            ret.Body = reader["Body"].ToString();
          }
        }
        conn.Close();
      }
      return ret;
    }
  }
}
