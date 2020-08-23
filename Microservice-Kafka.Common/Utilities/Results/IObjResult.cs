namespace Microservice_Kafka.Common.Utilities.Results
{
    public interface IObjResult<out T> : IResult
    {
        T Object { get; } 
    }
}
