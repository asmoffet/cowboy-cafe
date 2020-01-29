using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTripleBurger
    {
        private bool bun = true;
        /// <summary>
        /// if the Texas Trail Burger will have a bun
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
        /// if the Texas Trail Burger will have ketchup
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
        /// if the Texas Trail Burger will have mustard
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
        /// if the Texas Trail Burger will have a pickle
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
        /// if the Texas Trail Burger will have cheese
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
        /// if the Texas Trail Burger will have tomato slices
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
        /// if the Texas Trail Burger will have lettuce
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
        /// if the Texas Trail Burger will have mayo
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
        private bool bacon = true;
        /// <summary>
        /// if the Texas Trail Burger will have bacon
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }
            set
            {
                bacon = value;
            }
        }
        private bool egg = true;
        /// <summary>
        /// if the Texas Trail Burger will have egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }
            set
            {
                egg = value;
            }
        }
        /// <summary>
        /// the calories of a Texas Triple Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }
        /// <summary>
        /// the price of a Texas Triple Burger
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }
        /// <summary>
        /// Special instructions for the preparation of the Texas Triple Burger
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
                if (!bacon)
                    instructions.Add("hold bacon");
                if (!egg)
                    instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
