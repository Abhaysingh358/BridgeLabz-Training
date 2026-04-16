using System;
using FutureLogistics;

public class UserInterface
{
    public static void Main()
    {
        Utility utility = new Utility();

        Console.WriteLine("Enter the Goods Transport details like -> RTS113A:12/8/21:4:TimberTransport:20:4:Premium:500");
        string input = Console.ReadLine();

        GoodsTransport goods = utility.parseDetails(input);

        if (goods == null)
            return;

        string type = utility.findObjectType(goods);

        Console.WriteLine("Transporter id : " + goods.TransportId);
        Console.WriteLine("Date of transport : " + goods.TransportDate);
        Console.WriteLine("Rating of the transport : " + goods.TransportRating);

        if (type == "BrickTransport")
        {
            BrickTransport bt = (BrickTransport)goods;
            Console.WriteLine("Quantity of bricks : " + bt.BrickQuantity);
            Console.WriteLine("Brick price : " + bt.BrickPrice);
        }
        else
        {
            TimberTransport tt = (TimberTransport)goods;
            Console.WriteLine("Type of the timber : " + tt.TimberType);
            Console.WriteLine("Timber price per kilo : " + tt.TimberPrice);
        }

        Console.WriteLine("Vehicle for transport : " + goods.vehicleSelection());
        Console.WriteLine("Total charge : " + goods.calculateTotalCharge());
    }
}
