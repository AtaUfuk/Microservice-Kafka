using MicroService_Kafka.ApiMessage.Models;
using MicroService_Kafka.ApiMessage.Utilities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroService_Kafka.ApiMessage.DependecyInversion
{
    public class Manager : IServices
    {
        public static IConfiguration Configuration { get; private set; }
        public Manager(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public EventModel Get()
        {
            int number = Metods.GenerateNumber(0, 2);
            int number2 = Metods.GenerateNumber(0, 2);

            Attributes attributes = new Attributes
            {
                HotelId = Metods.GenerateId(),
                HotelName = Metods.GetHotels()[number, number2, 1],
                HotelRegion = Metods.GetHotels()[number, number2, 0]
            };
            User user = new User
            {
                IsAuthenticated = true,
                Email = Metods.GenerateStr(5, true) + "@setur.com",
                Id = Metods.GenerateId(),
                Provider = "b2c-internal"
            };
            EventModel model = new EventModel
            {
                App = Configuration.GetSection("AppId").Value,
                Type = Enum.GetName(typeof(Enums.GetTypes), Metods.GenerateNumber(1, 4)),
                IsSuccessed = true,
                Meta = new List<string>(),
                CreatedDate = DateTime.Now.AddHours(-1),
                Attributes = attributes,
                User = user
            };
            return model;
        }

        public IEnumerable<EventModel> GetList(int counter)
        {
            List<EventModel> models = new List<EventModel>();
            for (int i = 0; i < counter; i++)
            {
                int number = Metods.GenerateNumber(0, 2);
                int number2 = Metods.GenerateNumber(0, 2);

                Attributes attributes = new Attributes
                {
                    HotelId = Metods.GenerateId(),
                    HotelName = Metods.GetHotels()[number, number2, 1],
                    HotelRegion = Metods.GetHotels()[number, number2, 0]
                };
                User user = new User
                {
                    IsAuthenticated = true,
                    Email = Metods.GenerateStr(5, true) + "@setur.com",
                    Id = Metods.GenerateId(),
                    Provider = "b2c-internal"
                };
                EventModel model = new EventModel
                {
                    App = Configuration.GetSection("AppId").Value,
                    Type = Enum.GetName(typeof(Enums.GetTypes), Metods.GenerateNumber(1, 4)),
                    IsSuccessed = true,
                    Meta = new List<string>(),
                    CreatedDate = DateTime.Now.AddHours(-Metods.GenerateNumber(1, 24)),
                    Attributes = attributes,
                    User = user
                };
                models.Add(model);
            }
            return models;
        }
    }
}
