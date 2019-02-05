using System;
namespace Sale.Entities.Enum
{
    //Created the Order status

    public enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
