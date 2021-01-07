using System;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Serialization_on_._NET.models
{
    public static class Converter
    {
        public static void Run()
        {
            //Serialize();
            DeSerialize();
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

            string serialize = JsonConvert.SerializeObject(myQuery);
            System.Console.WriteLine(serialize);
        }

        public static void DeSerialize()
        {
            string JsonObject = @"
                                    {
                                    ""Text"" : ""Some DeSerialized model"",
                                    ""TimesTamp"" : ""16:26:22.49"",
                                    ""Url"" : ""/api/queries/22"" 
                                    }
                                    ";

            QueryObject Query = JsonConvert.DeserializeObject<QueryObject>(JsonObject);
            

          /*   QueryObject OtherQuery  = JsonConvert.DeserializeObject(@"{""key"" : ""value""}") as QueryObject;
            string txt = OtherQuery == null ? "Yes": "No";
            System.Console.WriteLine($"is other query null?: {txt}"); */

             System.Console.WriteLine(Query.Text);
        }
    }
}