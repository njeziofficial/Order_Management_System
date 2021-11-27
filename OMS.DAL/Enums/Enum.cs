using System;
using System.Collections.Generic;
using System.Text;

namespace OMS.DAL.Enums
{
    enum Enum
    {
    }

    public enum OrderStatus
    {
        Processed = 1,
        Declined,
        Pending,
        Cancelled
    }
}
