using MicroService_Kafka.ApiMessage.DependecyInversion;
using Microsoft.AspNetCore.Mvc;

namespace MicroService_Kafka.ApiMessage.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IServices _service;

        public EventsController(IServices service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("get-list/{count}")]
        public IActionResult GetEvents(int count)
        {
            return Ok(_service.GetList(count));
        }
        [HttpGet]
        [Route("get-one")]
        public IActionResult Get()
        {
            return Ok(_service.Get());
        }
    }
}
