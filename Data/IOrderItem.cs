using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        List<string> specialInstructions { get; }
        double Price { get; }
    }
}
