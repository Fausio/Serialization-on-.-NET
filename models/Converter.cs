using System;
using System.Data;

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

            var  myQuery = new QueryObject
            {

            }
        }
    }
}