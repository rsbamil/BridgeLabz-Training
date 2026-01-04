using System;

class Order
{
    public int OrderId;
    public string OrderDate;

    public Order(int orderId, string orderDate)
    {
        OrderId = orderId;
        OrderDate = orderDate;
    }

    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

class ShippedOrder : Order
{
    public string TrackingNumber;

    public ShippedOrder(int orderId, string orderDate, string trackingNumber)
        : base(orderId, orderDate)
    {
        TrackingNumber = trackingNumber;
    }

    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public string DeliveryDate;

    public DeliveredOrder(int orderId, string orderDate, string trackingNumber, string deliveryDate)
        : base(orderId, orderDate, trackingNumber)
    {
        DeliveryDate = deliveryDate;
    }

    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}

class OnlineRetail
{
    static void Main()
    {
        Order o1 = new Order(101, "01-Jan-2026");
        ShippedOrder o2 = new ShippedOrder(102, "02-Jan-2026", "TRK8899");
        DeliveredOrder o3 = new DeliveredOrder(103, "03-Jan-2026", "TRK7777", "06-Jan-2026");

        Console.WriteLine(o1.GetOrderStatus());
        Console.WriteLine(o2.GetOrderStatus());
        Console.WriteLine(o3.GetOrderStatus());
    }
}
