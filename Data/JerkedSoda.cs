/*

* Author: Alex Moffet

* Class name: JerkedSoda

* Purpose: store and access prperties for Jerked Soda

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// gets whether the user wants Ice or not
        /// </summary>
        public override bool Ice
        {
            get
            {
                return Ice;
            }
            set
            {
                Ice = value;
            }
        }
        /// <summary>
        /// gets the price of the drink
        /// </summary>
        public override double Price{
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }
        }
        /// <summary>
        /// gets the calories of the drink
        /// </summary>
        public override uint Calories {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size.");
                }
            }

        }
        /// <summary>
        /// gets and sets the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor { get; set; }
        /// <summary>
        /// gets any special instructions for the drink
        /// </summary>
        public override List<string> SpecialInstructions {
            get
            {
                var instructions = new List<string>();
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                return instructions;
            }
        }
    }
}
