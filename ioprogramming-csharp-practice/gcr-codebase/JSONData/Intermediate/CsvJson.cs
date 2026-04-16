using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONData.Intermediate
{
    internal class CsvJson
    {
        static void Main()
        {
            var lines = File.ReadAllLines("data.csv");
            var headers = lines[0].Split(',');

            var data = lines.Skip(1).Select(line =>
            {
                var values = line.Split(',');
                return headers.Zip(values, (h, v) => new { h, v })
                              .ToDictionary(x => x.h, x => x.v);
            });

            Console.WriteLine(JsonConvert.SerializeObject(data, Formatting.Indented));
        }
    }
}
