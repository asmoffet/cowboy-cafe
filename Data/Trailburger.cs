/*

* Author: Alex Moffet

* Class name: TrailBurger

* Purpose: store and access prperties for Trail Burger

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class TrailBurger: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool bun = true;
        /// <summary>
        /// if the Trailburger will have a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                bun = value;
            }
        }
        private bool ketchup = true;
        /// <summary>
        /// if the Trailburger will have ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                ketchup = value;
            }
        }
        private bool mustard = true;
        /// <summary>
        /// if the Trailburger will have mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                mustard = value;
            }
        }
        private bool pickle = true;
        /// <summary>
        /// if the Trailburger will have a pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                pickle = value;
            }
        }
        private bool cheese = true;
        /// <summary>
        /// if the Trailburger will have cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                cheese = value;
            }
        }
        /// <summary>
        /// the calories of a Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }
        /// <summary>
        /// the price of a Trailbuger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Trailer Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!pickle)
                    instructions.Add("hold pickle");
                if (!bun)
                    instructions.Add("hold bun");
                if (!ketchup)
                    instructions.Add("hold ketchup");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!cheese)
                    instructions.Add("hold cheese");

                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Trail Burger"</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
