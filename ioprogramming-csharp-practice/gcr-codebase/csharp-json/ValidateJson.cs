using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;

class ValidateJson
{
    static void Main()
    {
        string json = @"{ 'name':'Ravi', 'age':30 }";
        string schemaJson = @"{
          'type':'object',
          'properties':{
            'name':{'type':'string'},
            'age':{'type':'integer'}
          }
        }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);

        Console.WriteLine(obj.IsValid(schema));
    }
}
