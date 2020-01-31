using System;
using System.Collections.Generic;
using System.Text;

namespace enum_yee.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
