namespace Future_Logistics
{
    public class UserInterface
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Goods Transport details");
            string input = Console.ReadLine();

            GoodsTransport gt = Utility.parseDetails(input);

            if (gt == null)
                return;

            Console.WriteLine($"Transporter id : {gt.TransportId}");
            Console.WriteLine($"Date of transport : {gt.TransportDate}");
            Console.WriteLine($"Rating of the transport : {gt.TransportRating}");
            Console.WriteLine($"Vehicle for transport : {gt.vehicleSelection()}");
            Console.WriteLine($"Total charge : {gt.calculateTotalCharge()}");
        }
    }
}
