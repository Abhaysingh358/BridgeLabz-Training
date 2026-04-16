using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    internal class ValidateEmail
    {
        static void Main()
        {
            string schemaText = @"{
              'type':'object',
              'properties':{
                'email':{ 'type':'string', 'format':'email' }
              },
              'required':['email']
            }";

            string jsonText = @"{ 'email':'test@example.com' }";

            JSchema schema = JSchema.Parse(schemaText);
            JObject json = JObject.Parse(jsonText);

            Console.WriteLine(json.IsValid(schema) ? "Valid Email" : "Invalid Email");
        }
    }
}
