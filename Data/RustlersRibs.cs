using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// returns the price of th Rustler's Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }
        /// <summary>
        /// returns the calories for the Rustler' Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Rustler's Ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
