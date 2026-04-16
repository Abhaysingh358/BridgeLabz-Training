using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    internal class FilterJson
    {
        static void Main()
        {
            string json = @"[
              { 'name':'A','age':20 },
              { 'name':'B','age':30 },
              { 'name':'C','age':40 }
            ]";

            JArray array = JArray.Parse(json);
            var result = array.Where(x => (int)x["age"] > 25);

            Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
