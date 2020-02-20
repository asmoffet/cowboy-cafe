/*

* Author: Alex Moffet

* Class name: Water

* Purpose: store and access prperties for Water

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water: Drink
    {
        /// <summary>
        /// gets whether the user wants Ice
        /// </summary>
        private bool ice = false;
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
            }
        }
        /// <summary>
        /// gets whether the user wants lemon
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
            }
        }

        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }
        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }

        }
        /// <summary>
        /// gets any special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }
                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Water"</returns>
        public override string ToString()
        {
            return Size.ToString() + " Water";
        }
    }
}
