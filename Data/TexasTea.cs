/*

* Author: Alex Moffet

* Class name: TexasTea

* Purpose: store and access prperties for Texas Tea

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea: Drink
    {
        /// <summary>
        /// gets whether the user wants Ice
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
        /// gets where the user wants the drink sweet or not
        /// </summary>
        public bool Sweet
        {
            get
            {
                return true;
            }
            set
            {
                Sweet = value;
            }
        }
        /// <summary>
        /// gets whether the user wants lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return false;
            }
            set
            {
                Lemon = value;
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
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
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
                    case Size.Large && Sweet:
                        return 36;
                    case Size.Medium && Sweet:
                        return 22;
                    case Size.Small && Sweet:
                        return 10;

                    case Size.Large && !Sweet:
                        return 18;
                    case Size.Medium && !Sweet:
                        return 11;
                    case Size.Small && !Sweet:
                        return 5;

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
                if (!Ice)
                {
                    instructions.Add("Hold Ice");
                }
                if (Lemon)
                {
                    instructions.Add("Add Lemon");
                }
            }
        }
    }
}
