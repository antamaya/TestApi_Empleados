using System.Data;
using TestApi.Helpers;
using TestApi.Model;

namespace TestApi.DataAccess
{
   public class EmpleadosRepository
   {
      public static string Insert(Empleados model)
      {
         try
         {
           // using (var sqlconn = DBConnection.GetConnectionSQL)
            //{
               //var data = sqlconn.Query<Empleados>("SELECT * FROM [udt_Connection]", commandType: CommandType.Text).ToList();
               var empleados = GlobalData.Instance.empleados;
               empleados.Add(model);
               //sqlconn.Close();
               GlobalData.Instance.empleados = empleados;
               return "OK";
          //  }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public static List<Empleados> getAll()
      {
         try
         {
            //using (var sqlconn = DBConnection.GetConnectionSQL)
            //{

               //var data = sqlconn.Query<Empleados>("SELECT * FROM [udt_Connection]", commandType: CommandType.Text).ToList();
               var empleados = GlobalData.Instance.empleados;
               //sqlconn.Close();
               return empleados;
            //}
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public static Empleados getById(int ID)
      {
         try
         {
            using (var sqlconn = DBConnection.GetConnectionSQL)
            {
               //var data = sqlconn.Query<Empleados>("SELECT * FROM [udt_Connection]", commandType: CommandType.Text).ToList();
               var empleados = GlobalData.Instance.empleados.Where(x => x.Id == ID).FirstOrDefault();
               //sqlconn.Close();
               return empleados;
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public static string update(Empleados model)
      {
         try
         {
            using (var sqlconn = DBConnection.GetConnectionSQL)
            {
               //var data = sqlconn.Query<Empleados>("SELECT * FROM [udt_Connection]", commandType: CommandType.Text).ToList();
               var empleados = GlobalData.Instance.empleados;
               //sqlconn.Close();
               return "";
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }

      public static string deleteById(int ID)
      {
         try
         {
            using (var sqlconn = DBConnection.GetConnectionSQL)
            {
               //var data = sqlconn.Query<Empleados>("SELECT * FROM [udt_Connection]", commandType: CommandType.Text).ToList();
               var empleados = GlobalData.Instance.empleados;
               var select = GlobalData.Instance.empleados.Where(x => x.Id == ID).FirstOrDefault();
               empleados.Remove(select);
               GlobalData.Instance.empleados=empleados;
               //sqlconn.Close();
               return "OK";
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
   }
}
