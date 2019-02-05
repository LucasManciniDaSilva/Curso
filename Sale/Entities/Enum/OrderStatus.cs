﻿using System;
namespace Sale.Entities.Enum
{
    public enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
