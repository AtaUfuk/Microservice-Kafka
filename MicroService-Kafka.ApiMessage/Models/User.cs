namespace MicroService_Kafka.ApiMessage.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Provider { get; set; }
        public bool IsAuthenticated { get; set; }
    }
}