/*

* Author: Alex Moffet

* Class name: TexasTea

* Purpose: store and access prperties for Texas Tea

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TexasTea: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ice = value;
            }
        }
        /// <summary>
        /// gets where the user wants the drink sweet or not
        /// </summary>
        private bool sweet = false;
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                sweet = value;
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
                    case Size.Large:
                        if (Sweet == true)
                            return 36;
                        else
                            return 18;
                    case Size.Medium:
                        if (Sweet == true)
                            return 22;
                        else
                            return 11;
                    case Size.Small:
                        if (Sweet == true)
                            return 10;
                        else
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
                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Texas Tea"</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return Size.ToString() + " Texas Sweet Tea";
            }
            else
            {
                return Size.ToString() + " Texas Plain Tea";
            }
            
        }
    }
}
