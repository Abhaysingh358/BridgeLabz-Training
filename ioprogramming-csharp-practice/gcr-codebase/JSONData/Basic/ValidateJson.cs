using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;

namespace JSONData.Basic
{
    internal class ValidateJson
    {
        static void Main()
        {
            string schemaText = @"{
              'type': 'object',
              'properties': {
                'id': { 'type': 'integer' },
                'name': { 'type': 'string' }
              },
              'required': ['id', 'name']
            }";

            string jsonText = @"{ 'id': 101, 'name': 'Alice' }";

            JSchema schema = JSchema.Parse(schemaText);
            JObject json = JObject.Parse(jsonText);

            Console.WriteLine(json.IsValid(schema) ? "Valid JSON" : "Invalid JSON");
        }
    }
}
