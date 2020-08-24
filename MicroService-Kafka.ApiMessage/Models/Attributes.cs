using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService_Kafka.ApiMessage.Models
{
    public class Attributes
    {
        public int HotelId { get; set; }
        public string HotelRegion { get; set; }
        public string HotelName { get; set; }
    }
}
