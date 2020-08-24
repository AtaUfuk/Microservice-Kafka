using System;
using System.Collections.Generic;

namespace MicroService_Kafka.ApiMessage.Models
{
    public class EventModel
    {
        public string App { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsSuccessed { get; set; }
        public List<string> Meta { get; set; }
        public User User { get; set; }
        public Attributes Attributes { get; set; }
    }
}
