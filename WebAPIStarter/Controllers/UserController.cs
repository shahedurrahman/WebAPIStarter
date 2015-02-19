using System.Web.Http;

namespace WebAPIStarter.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/{controller}/{action}")]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        [HttpGet]
        [Route("api/{controller}/{action}")]
        public IHttpActionResult GetAll()
        {
            return Ok();
        }
    }
}
