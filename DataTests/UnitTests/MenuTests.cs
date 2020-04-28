using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xunit;
using CowboyCafe.Data;


namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {
        /// <summary>
        /// this section tests the lists of entrees, sides, drinks, and the complete menu
        /// </summary>

        //entrees should have seven items
        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            var entrees = Menu.Entrees();
            Assert.Equal(7, entrees.Count());
        }

        //entrees should contain entree items
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        public void EntreesShouldContainItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //sides should only have four items (code from Testing Types in Collections video from announcemnts) 
        [Fact]
        public void SidesShouldHaveOnlyFourItems()
        {
            var sides = Menu.Sides();
            Assert.Equal(4, sides.Count());
        }

        //Sides should contain side items (code from Testing Types in Collections video from announcemnts)
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void SidesShouldContainItems(Type type)
        {
            var types = new List<Type>();
            foreach(IOrderItem item in Menu.Sides())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //drinks should only have four items
        [Fact]
        public void DrinksShouldHaveOnlyFourItems()
        {
            var sides = Menu.Drinks();
            Assert.Equal(4, sides.Count());
        }

        //drinks should contain side items
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void DrinksShouldContainItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //the menu should have 15 items in it
        [Fact]
        public void CompleteMenuShouldHaveFifteenItems()
        {
            var menu = Menu.CompleteMenu();
            Assert.Equal(15, menu.Count());
        }

        //ComlpeteMenu should have evrything
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void CompleteMenuShouldContainItems(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        /// <summary>
        /// This section tests the search bar feature
        /// </summary>


        //searching with null should return the complete menu
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void SearchingNULLShouldReturnEverything(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Search(null))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //searching should return items sharing the text with the search term
        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(CowboyCoffee))]
        public void SearchingShouldReturnItemsSharingTheTextWithTheSearchTerms(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Search("Cow"))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        /// <summary>
        /// This section covers the filter check boxes for entrees, sides and drinks
        /// </summary>


        //with complete menue entree filter should return only entrees
        [Theory]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        public void WithSompleteMenuEntreeFilterShouldReturnOnlyEntrees(Type type)
        {
            var menu = Menu.CompleteMenu();
            var strings = new List<string>();
           strings.Add("entree");

            var types = new List<Type>();
            foreach (IOrderItem item in Menu.filterByType(strings, menu))
            {
                types.Add(item.GetType());
            }

            Assert.Contains(type, types);
        }

        //with complete menue Sides filter should return only Sides
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void WithSompleteMenuSidesFilterShouldReturnOnlyEntrees(Type type)
        {
            var menu = Menu.CompleteMenu();
            var strings = new List<string>();
            strings.Add("side");

            var types = new List<Type>();
            foreach (IOrderItem item in Menu.filterByType(strings, menu))
            {
                types.Add(item.GetType());
            }

            Assert.Contains(type, types);
        }

        //with complete menue Drinks filter should return only Drinks
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void WithSompleteMenuDrinksFilterShouldReturnOnlyEntrees(Type type)
        {
            var menu = Menu.CompleteMenu();
            var strings = new List<string>();
            strings.Add("drink");

            var types = new List<Type>();
            foreach (IOrderItem item in Menu.filterByType(strings, menu))
            {
                types.Add(item.GetType());
            }

            Assert.Contains(type, types);
        }

        //filter should retain search information
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        public void FilterShouldRetainSearchInformation(Type type)
        {
            var menu = Menu.Search("Cow");
            var strings = new List<string>();
            strings.Add("drink");

            var types = new List<Type>();
            foreach (IOrderItem item in Menu.filterByType(strings, menu))
            {
                types.Add(item.GetType());
            }

            Assert.Contains(type, types);
        }


        /// <summary>
        /// This section covers filtering by Calories and Price
        /// </summary>


        //filtering with null should return the same list (price)
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void FilteringNullShouldReturnTheSameListForPrice(Type type)
        {
            var types = new List<Type>();
            var drinks = Menu.Drinks();
            foreach (IOrderItem item in Menu.FilterItemsByPrice(drinks, null, null))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        //filtering with null max should return all less (price)
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        public void FilteringWithNullMaxShouldReturnAllLessForPrice(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByPrice(drinks, 1.60, null))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering with null min hould return all more (price)
        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void FilteringWithNullMinShouldReturnAllLessForPrice(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByPrice(drinks, null, 1.60))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering by price should return items within that price range
        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(CornDodgers))]
        public void FilteringByPriceShouldReturnAllInRange(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByPrice(drinks, 1.49, 1.70))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering with price should retain the search query
        [Theory]
        [InlineData(typeof(CornDodgers))]
        public void FilteringByPriceShouldRetainTheSearchQuery(Type type)
        {
            var types = new List<Type>();
            var drinks = Menu.Search("Co");
            var cat = new List<string>();
            cat.Add("side");
            drinks = Menu.filterByType(cat, drinks);

            foreach (IOrderItem item in Menu.FilterItemsByPrice(drinks, 1.49, 1.70))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }


        //filtering with null should return the same list (calories)
        [Theory]
        [InlineData(typeof(CowboyCoffee))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(Water))]
        public void FilteringNullShouldReturnTheSameListForCalories(Type type)
        {
            var types = new List<Type>();
            var drinks = Menu.Drinks();
            foreach (IOrderItem item in Menu.FilterItemsByCalories(drinks, null, null))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering with null min should return all less (calories)
        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(PanDeCampo))]
        public void FilteringWithNullMinShouldReturnAllLessForCalories(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByCalories(drinks, null, 400))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering with null max hould return all more (calories)
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(CornDodgers))]
        public void FilteringWithNullMaxShouldReturnAllLessForCalories(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByCalories(drinks, 400, null))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }

        //filtering with calories should return items within that range
        [Theory]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(ChiliCheeseFries))]
        public void FilteringByPriceShouldReturnAllInRangeForCalories(Type type)
        {
            var types = new List<Type>();
            var drinks = new List<IOrderItem>();
            drinks.Add(new ChiliCheeseFries());
            drinks.Add(new BakedBeans());
            drinks.Add(new PanDeCampo());
            drinks.Add(new CornDodgers());
            foreach (IOrderItem item in Menu.FilterItemsByCalories(drinks, 300, 500))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
        //filtering with calories should retain the search query
        [Theory]
        [InlineData(typeof(CornDodgers))]
        public void FilteringByPriceShouldRetainTheSearchQueryForCalories(Type type)
        {
            var types = new List<Type>();
            var drinks = Menu.Search("Co");
            var cat = new List<string>();
            cat.Add("side");
            drinks = Menu.filterByType(cat, drinks);

            foreach (IOrderItem item in Menu.FilterItemsByCalories(drinks, 450, 530))
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);
        }
    }
}
