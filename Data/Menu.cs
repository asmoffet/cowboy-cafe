using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// adds all the entrees to a list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;
        }
        /// <summary>
        /// adds all the sides to a list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            return sides;
        }
        /// <summary>
        /// adds all the drinks to a list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());
            return drinks;
        }
        /// <summary>
        /// makes a complete menu list
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();
            IEnumerable<IOrderItem> entrees = Entrees();
            IEnumerable<IOrderItem> sides = Sides();
            IEnumerable<IOrderItem> drinks = Drinks();
            foreach(IOrderItem entree in entrees)
            {
                menu.Add(entree);
            }
            foreach(IOrderItem side in sides)
            {
                menu.Add(side);
            }
            foreach(IOrderItem drink in drinks)
            {
                menu.Add(drink);
            }
            return menu;
        }
        /// <summary>
        /// takes in a search term and returns a list of items with the terms in it.
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            List<IOrderItem> all = new List<IOrderItem>(CompleteMenu());
            if (terms == null) return CompleteMenu();

            foreach(IOrderItem item in all)
            {
                if(item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        /// <summary>
        /// filters the list by the type of item
        /// </summary>
        /// <param name="types">a array of different item types</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> filterByType(IEnumerable<string> types, IEnumerable<IOrderItem> items)
        {
            if (types == null || types.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            if (types.Contains("entree"))
            {
                IEnumerable<IOrderItem> entrees = Entrees();
                foreach (IOrderItem item in items)
                {
                    foreach(IOrderItem entree in entrees)
                    {
                        if (item.GetType() == entree.GetType())
                        {
                            results.Add(entree);
                        }
                    } 
                }
            }

            if (types.Contains("side"))
            {
                IEnumerable<IOrderItem> sides = Sides();
                foreach (IOrderItem item in items)
                {
                    foreach (IOrderItem side in sides)
                    {
                        if (item.GetType() == side.GetType())
                        {
                            results.Add(side);
                        }

                    }
                }
                
            }
            if (types.Contains("drink"))
            {
                IEnumerable<IOrderItem> drinks = Drinks();
                foreach (IOrderItem item in items)
                {
                    foreach (IOrderItem drink in drinks)
                    {
                        if (item.GetType() == drink.GetType())
                        {
                            results.Add(drink);
                        }

                    }
                }
            }
            return results;
        }
        /// <summary>
        /// filters the items by their price
        /// </summary>
        /// <param name="items">the list of items</param>
        /// <param name="min">minimum price</param>
        /// <param name="max">maximum price</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterItemsByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {

            if (min == null && max == null)
            {
                return items;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// filters the items by their price
        /// </summary>
        /// <param name="items">the list of items</param>
        /// <param name="min">minimum Calories</param>
        /// <param name="max">maximum Calories</param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterItemsByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {

            if (min == null && max == null)
            {
                return items;
            }

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
