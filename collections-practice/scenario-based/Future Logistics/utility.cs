using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Future_Logistics
{
    using System;
    using System.Text.RegularExpressions;

    public class Utility
    {
        public static bool validateTransportId(string transportId)
        {
            bool isValid = Regex.IsMatch(transportId, "^RTS[0-9]{3}[A-Z]$");

            if (!isValid)
            {
                Console.WriteLine($"Transport id {transportId} is invalid");
                Console.WriteLine("Please provide a valid record");
            }

            return isValid;
        }

        public static GoodsTransport parseDetails(string input)
        {
            string[] data = input.Split(':');

            string transportId = data[0];
            string date = data[1];
            int rating = int.Parse(data[2]);
            string type = data[3];

            if (!validateTransportId(transportId))
                return null;

            if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    transportId, date, rating,
                    float.Parse(data[4]),
                    int.Parse(data[5]),
                    float.Parse(data[6])
                );
            }
            else
            {
                return new TimberTransport(
                    transportId, date, rating,
                    float.Parse(data[4]),
                    float.Parse(data[5]),
                    data[6],
                    float.Parse(data[7])
                );
            }
        }

        public static string findObjectType(GoodsTransport goodsTransport)
        {
            if (goodsTransport is TimberTransport)
                return "TimberTransport";
            else
                return "BrickTransport";
        }
    }

}
