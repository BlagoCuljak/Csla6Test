using Microsoft.AspNetCore.Mvc;

namespace BlazorExample.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DataPortalTextController : Csla.Server.Hosts.HttpPortalController
  {
    public DataPortalTextController(Csla.ApplicationContext applicationContext)
      : base(applicationContext)
    {
      UseTextSerialization = true;
    }

    [HttpGet]
    public string Get() => "DataPortal is running";
  }
}