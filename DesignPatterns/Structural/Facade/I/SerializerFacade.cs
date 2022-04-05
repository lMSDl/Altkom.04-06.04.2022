using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.I
{
    public static class SerializerFacade
    {

        private static JsonSerializerSettings Settings = new JsonSerializerSettings()
        {
            DateFormatString = "MM-dd.yyyy",
            DefaultValueHandling = DefaultValueHandling.Ignore
        };
        public static string Serialize<T>(T item)
        {
            return JsonConvert.SerializeObject(item, Settings);
        }
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, Settings);
        }
    }
}
