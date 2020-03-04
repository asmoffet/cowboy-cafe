using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public interface IOrderItem 
    {
 
        /// <summary>
        /// gets the list of special instructions
        /// </summary>
        public List<string> SpecialInstructions { get; }
        /// <summary>
        /// gets the price
        /// </summary>
        public double Price { get; }
    }
}
