using MicroService_Kafka.ApiMessage.Models;
using System.Collections.Generic;

namespace MicroService_Kafka.ApiMessage.DependecyInversion
{
    public interface IServices
    {
        IEnumerable<EventModel> GetList(int counter);
        EventModel Get();
    }
}
