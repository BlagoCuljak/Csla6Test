using Microsoft.AspNetCore.Mvc;

namespace BlazorExample.Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DataPortalController : Csla.Server.Hosts.HttpPortalController
  {
    public DataPortalController(Csla.ApplicationContext applicationContext)
      : base(applicationContext) { }

    [HttpGet]
    public string Get() => "DataPortal is running";
  }
}