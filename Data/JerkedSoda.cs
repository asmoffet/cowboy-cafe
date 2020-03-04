/*

* Author: Alex Moffet

* Class name: JerkedSoda

* Purpose: store and access prperties for Jerked Soda

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class JerkedSoda: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// gets whether the user wants Ice or not
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ice = value;
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
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Jerked Soda"</returns>
        public override string ToString()
        {
            switch (this.Flavor)
            {
                case SodaFlavor.BirchBeer:
                    return Size.ToString() +" Birch Beer Jerked Soda";
                case SodaFlavor.CreamSoda:
                    return Size.ToString() + " Cream Soda Jerked Soda";
                case SodaFlavor.OrangeSoda:
                    return Size.ToString() + " Orange Soda Jerked Soda";
                case SodaFlavor.RootBeer:
                    return Size.ToString() + " Root Beer Jerked Soda";
                case SodaFlavor.Sarsparilla:
                    return Size.ToString() + " Sarsparilla Jerked Soda";
                default:
                    return Size.ToString() + " Cream Soda Jerked Soda";
            }
                

        }
    }
}
