using Microservice_Kafka.Business.IServices;
using Microservice_Kafka.Common.Utilities.Results;
using Microsoft.AspNetCore.Mvc;

namespace MicroService_Kafka.ApiUI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        [Route("get-messages")]
        public IObjResult<dynamic> GetMessages()
        {
            return _messageService.Get();
        }
    }
}
