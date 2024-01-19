namespace TestApi.Helpers
{
   public class GlobalData
   {
      private static GlobalData instance = null;
      private static readonly object padlock = new object();
      private List<Model.Empleados> _empleados = new List<Model.Empleados>();
      private List<Model.Estados> _estados = new List<Model.Estados>();
      private List<Model.Puestos> _puestos = new List<Model.Puestos>();

      GlobalData()
      {
      }
      public static GlobalData Instance
      {
         get
         {
            if (instance == null)
            {
               lock (padlock)
               {
                  if (instance == null)
                  {
                     instance = new GlobalData();
                  }
               }
            }
            return instance;
         }
         set
         {
            if (instance == null)
            {
               lock (padlock)
               {
                  if (instance == null)
                  {
                     instance = new GlobalData();
                  }
               }
            }

         }
      }
      public List<Model.Empleados> empleados
      {
         get
         {
            if (instance == null)
            {
               _empleados = new List<Model.Empleados>();
            }
            return _empleados;
         }
         set
         {
            if (instance == null)
            {
               _empleados = new List<Model.Empleados>();
            }
            _empleados = value;
         }
      }
   }
}
