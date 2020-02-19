/*

* Author: Alex Moffet

* Class name: ChiliCheeseFries

* Purpose: store and access prperties for Chili Cheese Fries

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries: Side
    {
        /// <summary>
        /// returns the calories for small medium and large chili cheese fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// returns the price for small medium and large chili cheese fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Chili Cheese Frise"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Chili Cheese Fries";

        }
    }
}
