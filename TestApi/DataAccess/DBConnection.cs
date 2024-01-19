using System.Data;
using System.Data.SqlClient;
using TestApi.Helpers;

namespace TestApi.DataAccess
{
   public class DBConnection
   {
      private static readonly string ConnectionStringSQL = "";//WebConfigurationManager.OpenWebConfiguration("~/Web.config").ConnectionStrings.ConnectionStrings["AppConn"].ToString();
      private static readonly string ConnectionStringMySQL = "";//WebConfigurationManager.OpenWebConfiguration("~/Web.config").ConnectionStrings.ConnectionStrings["AppConn"].ToString();

      public static GlobalData GetConnectionGlobal
      {
         get
         {   
            return GlobalData.Instance;
         }
      }
      public static IDbConnection GetConnectionSQL
      {
         get
         {
            var conn = new SqlConnection(ConnectionStringSQL);
            conn.Open();
            return conn;
         }
      }
   }
}
