using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    
    public class DakotaDoubleBurger
    {
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
                mayo = value;
            }
        }
        /// <summary>
        /// how many calories the Dakota Double Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
            }
        }
        /// <summary>
        /// The price of the Dakota Double Burger
        /// </summary>
        public double Price
        {
            get
            {
                return 5.20;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Dakota Double Burger
        /// </summary>
        public List<string> SpecialInstructions
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
    }
}
