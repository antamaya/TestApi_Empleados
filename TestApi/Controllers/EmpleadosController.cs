using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Model;

namespace TestApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class EmpleadosController : ControllerBase
   {
      [HttpPost(Name = "CreateEmpleados")]
      public string CreateEmpleado(Empleados model)
      {
         return DataAccess.EmpleadosRepository.Insert(model);
      }

      [HttpGet(Name = "GetAllEmpleados")]
      public IEnumerable<Empleados> Get()
      {
         return DataAccess.EmpleadosRepository.getAll();
      }

      [HttpPut(Name = "UpdateEmpleado")]
      public string UpdateEmpleado(Empleados model)
      {
         return DataAccess.EmpleadosRepository.Insert(model);
      }

      [HttpDelete(Name = "DeleteEmpleado")]
      public string DeleteEmpleado(int id)
      {
         return DataAccess.EmpleadosRepository.deleteById(id);
      }
   }
}
