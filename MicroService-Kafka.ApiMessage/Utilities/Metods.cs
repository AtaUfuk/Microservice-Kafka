using System;
using System.Collections.Generic;
using System.Text;

namespace MicroService_Kafka.ApiMessage.Utilities
{
    public static class Metods
    {
        public static int GenerateId()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999);
        }
        public static int GenerateNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        public static string GenerateStr(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToLower().Replace("ı", "i");
            }
            return builder.ToString();
        }

        public static string[,,] GetHotels()
        {
            string[,,] arrays = new string[3, 3, 2]
            {
                { {"Antalya","Rixos" },
                    {"Antalya","Robinson Club Nobilis" },
                    {"Antalya","Ela Quality Resort Belek" }
                },
                {
                    {"İstanbul","Kemer Country Hotel İstanbul" },
                    {"İstanbul","Nokta Suites Hotel" },
                    {"İstanbul","Mass Apart Otel" }
                },
                {
                    {"Alanya","Orange County Resort Hotel Alanya" },
                    {"Alanya","Kirman Leodikya Resort & Spa" },
                    {"Alanya","Kleopatra Royal Palm Hotel" }
                }
            };
            return arrays;
        }
    }
}
