using System;
using  System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialization_on_._NET.models
{
    public class Converter
    {
        public static void Run()
        {
            Serialize();
            //DeSerialize();
            //Anonymouse();
        }

        public static void Serialize()
        {
            int id = new Random().Next(0, 100);

            var myQuery = new QueryObject
            {
                Id = id,
                Text = "Some bits here",
                TimesTamp = DateTime.Now.TimeOfDay,
                Url = "api/queries" + id.ToString()
            };

            string serialize = JsonConvert.SerializeObject(myQuery)
        }
    }
}