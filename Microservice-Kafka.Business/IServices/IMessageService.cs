using Microservice_Kafka.Common.Utilities.Results;

namespace Microservice_Kafka.Business.IServices
{
    public interface IMessageService
    {
        IObjResult<dynamic> Get();
    }
}
