/*

* Author: Alex Moffet

* Class name: DakotaDoubleBurger

* Purpose: store and access prperties for Dakota Double Burger

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    
    public class DakotaDoubleBurger: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool bun = true;
        /// <summary>
        /// if the Dakota Double Burger will have a bun
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
        /// if the Dakota Double Burger will have ketchup
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
        /// if the Dakota Double Burger will have mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mastard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                mustard = value;
            }
        }
        private bool pickle = true;
        /// <summary>
        /// if the Dakota Double Burger will have a pickle
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
        /// if the Dakota Double Burger will have cheese
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
        private bool tomato = true;
        /// <summary>
        /// if the Dakota Double Burger will have a toamto slice
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                tomato = value;
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// if the Dakota Double Burger will have lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                lettuce = value;
            }
        }
        private bool mayo = true;
        /// <summary>
        /// if the Dakota Double Burger will have mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }
            set
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                mayo = value;
            }
        }
        /// <summary>
        /// how many calories the Dakota Double Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }
        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger
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
                if (!tomato)
                    instructions.Add("hold tomato");
                if (!lettuce)
                    instructions.Add("hold lettuce");
                if (!mayo)
                    instructions.Add("hold mayo");

                return instructions;
            }
        }
        /// <summary>
        /// converts object to a string
        /// </summary>
        /// <returns>The String "Dakota Double Burger"</returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
