using System;
using System.Text.RegularExpressions;

namespace FutureLogistics
{
    public class Utility
    {
        public GoodsTransport parseDetails(string input)
        {
            string[] data = input.Split(':');

            string id = data[0];
            string date = data[1];
            int rating = int.Parse(data[2]);
            string type = data[3];

            if (!validateTransportId(id))
            {
                Console.WriteLine($"Transport id {id} is invalid");
                Console.WriteLine("Please provide a valid record");
                return null;
            }

            if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    id, date, rating,
                    float.Parse(data[4]),
                    int.Parse(data[5]),
                    float.Parse(data[6])
                );
            }

            if (type.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new TimberTransport(
                    id, date, rating,
                    float.Parse(data[4]),
                    float.Parse(data[5]),
                    data[6],
                    float.Parse(data[7])
                );
            }

            return null;
        }

        public bool validateTransportId(string transportId)
        {
            return Regex.IsMatch(transportId, @"^RTS[0-9]{3}[A-Z]$");
        }

        public string findObjectType(GoodsTransport goods)
        {
            if (goods is TimberTransport)
                return "TimberTransport";

            if (goods is BrickTransport)
                return "BrickTransport";

            return "Unknown";
        }
    }
}
