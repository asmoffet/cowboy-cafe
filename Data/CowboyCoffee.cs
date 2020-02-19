/*

* Author: Alex Moffet

* Class name: CowboyCoffee

* Purpose: store and access prperties for Cowboy Coffee

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee: Drink
    {
        /// <summary>
        /// gets whethre there needs to be room for cream
        /// </summary>
        public bool RoomForCream {
            get
            {
                return false;
            }
            set
            {
                RoomForCream = value;
            }
        }
        /// <summary>
        /// gets whether there is Ice or not
        /// </summary>
        
        public override bool Ice
        {
            get
            {
                return false;
            }
            set
            {
                Ice = value;
            }
        }
        private bool decaf = false;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
            }
        }
        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return 0.60;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
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
                if (Ice)
                {
                    instructions.Add("Add Ice");
                }
                if (RoomForCream)
                {
                    instructions.Add("Room for Cream");
                }
                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Cowboy Coffee"</returns>
        public override string ToString()
        {
            if (Decaf == true)
            {
                return Size.ToString() + " Decaf Cowboy Coffee";
            }
            else
            {
                return Size.ToString() + " Cowboy Coffee";
            }

        }
    }
}
