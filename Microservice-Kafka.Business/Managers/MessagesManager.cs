using Microservice_Kafka.Business.IServices;
using System;
using Microservice_Kafka.Common.Utilities.Results;
using System.Net;
using System.IO;

namespace Microservice_Kafka.Business.Managers
{
    public class MessagesManager : IMessageService
    {
        public IObjResult<dynamic> Get()
        {
            string html;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("microservicekafkaapimessage:dev/events/get-list/3"); //https://www.google.com
            webRequest.ContentType = "application/json";
            webRequest.Proxy = null;
            webRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            using (Stream stream = httpResponse.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            return new ObjResult<dynamic>(true, html);
        }
    }
}
