namespace TestApi.Model
{
   public class EmpleadosView
   {
      public int Id { get; set; }
      public string FotoGrafia { get; set; }
      public string Nombre { get; set; }
      public string Apellido { get; set; }
      public Puestos Puesto { get; set; }
      public DateOnly FechaNacimiento { get; set; }
      public DateOnly FechaContratacion { get; set; }
      public string Direccion { get; set; }
      public string Telefono { get; set; }
      public string CorreoElectronico { get; set; }
      public Estados Estado { get; set; }
   }
}
