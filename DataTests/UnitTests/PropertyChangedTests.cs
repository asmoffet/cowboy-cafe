using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.UnitTests
{
    public class AngryChickenPropertyChangedTests
    {
        /// <summary>
        /// Tests For The Angry CHicken
        /// </summary>
        //Angry CHicken should impliment INotifyPropertyChanged Interface
        [Fact]
        public void AngryChickenShouldImplimentInotifyPropertyCHanged()
        {
            var chicken = new AngryChicken();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chicken);
        }
        //changing "Bread" should invoke PropertyChanged for "Bread"
        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Bread", () =>
            {
                chicken.Bread = false;
            });
        }
        // Changing bread should invoke PropertyChanged for SpecialInstructions
        [Fact]
        public void ChangingBreadShouldINvokePropertyChangedForSpecialINstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Bread = false;
            });
        }
        //changing the "Pickle" property should invoke PropertyChanged for Pickle
        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "Pickle", () =>
            {
                chicken.Pickle = false;
            });
        }
        //changing pickle should invoke PropertyChanged for SpecialInstructions
        public void ChangingPickleShouldIvokePropertyChangedForSpecialInstructions()
        {
            var chicken = new AngryChicken();
            Assert.PropertyChanged(chicken, "SpecialInstructions", () =>
            {
                chicken.Pickle = false;
            });
        }


        /// <summary>
        /// Test Cases For CowboyCoffee
        /// </summary>
        /// 
        //CowboyCoffee should impliment INotifyPropertyChanged Interface
        [Fact]
        public void CowboyCoffeeShouldImplimentInotifyPropertyCHanged()
        {
            var coffee = new CowboyCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(coffee);
        }
        //Changing Room For Cream Should Invoke Property Changed For Special Instructions
        public void ChangingRoomForCreamShouldIvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        //Changing RoomForCream Should Invoke Property Changed For RoomForCream
        public void ChangingRoomForCreamShouldIvokePropertyChangedForRoomForCream()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "RoomForCream", () =>
            {
                coffee.RoomForCream = true;
            });
        }
        //Changing Ice Should Invoke Property Changed For Ice
        public void ChangingIceShouldIvokePropertyChangedForIce()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Ice", () =>
            {
                coffee.Ice = true;
            });
        }
        //Changing Ice Should Invoke Property Changed For SpecialInstructions
        public void ChangingIceShouldIvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Ice = true;
            });
        }
        //Changing Decaf Should Invoke Property Changed For SpecialInstructions
        public void ChangingDecafShouldIvokePropertyChangedForSpecialInstructions()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "SpecialInstructions", () =>
            {
                coffee.Decaf = true;
            });
        }
        //Changing Decaf Should Invoke Property Changed For Decaf
        public void ChangingDecafShouldIvokePropertyChangedForDecaf()
        {
            var coffee = new CowboyCoffee();
            Assert.PropertyChanged(coffee, "Decaf", () =>
            {
                coffee.Decaf = true;
            });
        }


        /// <summary>
        /// Test Cases For CowpokeChili
        /// </summary>
        //CowpokeChili should impliment INotifyPropertyChanged Interface
        [Fact]
        public void CowpokeChiliShouldImplimentInotifyPropertyCHanged()
        {
            var chili = new CowpokeChili();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(chili);
        }
        //Changing Cheese Should Invoke Property Changed For Cheese
        public void ChangingCheeseShouldIvokePropertyChangedForCheese()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "Cheese", () =>
            {
                chili.Cheese = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For SpecialInstructions
        public void ChangingCheeseShouldIvokePropertyChangedForSpecialInstructionse()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.Cheese = false;
            });
        }
        //Changing SourCream Should Invoke Property Changed For SourCream
        public void ChangingSourCreamShouldIvokePropertyChangedForSourCream()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SourCream", () =>
            {
                chili.SourCream = false;
            });
        }
        //Changing SourCream Should Invoke Property Changed For SpecialInstructions
        public void ChangingSourCreamShouldIvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.SourCream = false;
            });
        }
        //Changing GreenOnions Should Invoke Property Changed For GreenOnions
        public void ChangingGreenOnionsShouldIvokePropertyChangedForGreenOnions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "GreenOnions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        //Changing GreenOnions Should Invoke Property Changed For SpecialInstructions
        public void ChangingGreenOnionsShouldIvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.GreenOnions = false;
            });
        }
        //Changing TortillaStrips Should Invoke Property Changed For TortillaStrips
        public void ChangingTortillaStripsShouldIvokePropertyChangedForTortillaStrips()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "TortillaStrips", () =>
            {
                chili.TortillaStrips = false;
            });
        }
        //Changing TortillaStrips Should Invoke Property Changed For SpecialInstructions
        public void ChangingTortillaStripsShouldIvokePropertyChangedForSpecialInstructions()
        {
            var chili = new CowpokeChili();
            Assert.PropertyChanged(chili, "SpecialInstructions", () =>
            {
                chili.TortillaStrips = false;
            });
        }


        /// <summary>
        /// Test Cases For DakotaDoubleBurger
        /// </summary>
        // DakotaDoubleBurger should impliment INotifyPropertyChanged Interface
        [Fact]
        public void DakotaDoubleBurgerShouldImplimentInotifyPropertyCHanged()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dBurger);
        }
        //Changing Bun Should Invoke Property Changed For Bun
        public void ChangingBunShouldIvokePropertyChangedForBun()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Bun", () =>
            {
                dBurger.Bun = false;
            });
        }
        //Changing Bun Should Invoke Property Changed For SpecialInstructions
        public void ChangingBunShouldIvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Bun = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For Ketchup
        public void ChangingKetchupShouldIvokePropertyChangedForKetchup()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Ketchup", () =>
            {
                dBurger.Ketchup = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For Ketchup
        public void ChangingKetchupShouldIvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Ketchup = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For Mustard
        public void ChangingMustardShouldIvokePropertyChangedForMustard()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Mustard", () =>
            {
                dBurger.Mustard = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For SpecialInstructions
        public void ChangingMustardShouldIvokePropertyChangedForSpecialInstructions()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstructions", () =>
            {
                dBurger.Mustard = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For Pickle
        public void ChangingDPickleShouldIvokePropertyChangedForDPickle()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Pickle", () =>
            {
                dBurger.Pickle = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For SpecialInstruction
        public void ChangingDPickleShouldIvokePropertyChangedForSpecialInstruction()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstruction", () =>
            {
                dBurger.Pickle = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For Cheese
        public void ChangingDCheeseShouldIvokePropertyChangedForDCheese()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Cheese", () =>
            {
                dBurger.Cheese = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For Cheese
        public void ChangingDCheeseShouldIvokePropertyChangedForSpecialInstruction()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstruction", () =>
            {
                dBurger.Cheese = false;
            });
        }
        //Changing Tomato Should Invoke Property Changed For Tomato
        public void ChangingTomatoShouldIvokePropertyChangedForTomato()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Tomato", () =>
            {
                dBurger.Tomato = false;
            });
        }
        //Changing Tomato Should Invoke Property Changed For Tomato
        public void ChangingTomatoShouldIvokePropertyChangedForSpecialInstruction()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstruction", () =>
            {
                dBurger.Tomato = false;
            });
        }
        //Changing Lettuce Should Invoke Property Changed For Lettuce
        public void ChangingLettuceShouldIvokePropertyChangedForLettuce()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Lettuce", () =>
            {
                dBurger.Lettuce = false;
            });
        }
        //Changing Lettuce Should Invoke Property Changed For SpecialInstruction
        public void ChangingLettuceShouldIvokePropertyChangedForSpecialInstruction()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstruction", () =>
            {
                dBurger.Lettuce = false;
            });
        }
        //Changing Mayo Should Invoke Property Changed For Mayo
        public void ChangingMayoShouldIvokePropertyChangedForMayo()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "Mayo", () =>
            {
                dBurger.Mayo = false;
            });
        }
        //Changing Mayo Should Invoke Property Changed For SpecialInstruction
        public void ChangingMayoShouldIvokePropertyChangedForSpecialInstruction()
        {
            var dBurger = new DakotaDoubleBurger();
            Assert.PropertyChanged(dBurger, "SpecialInstruction", () =>
            {
                dBurger.Mayo = false;
            });
        }


        /// <summary>
        /// Test Cases For JerkedSoda
        /// </summary>
        // JerkedSoda should impliment INotifyPropertyChanged Interface
        [Fact]
        public void JerkedSodaShouldImplimentInotifyPropertyCHanged()
        {
            var soda = new JerkedSoda();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(soda);
        }
        //Changing Ice Should Invoke Property Changed For Ice
        public void ChangingJIceShouldIvokePropertyChangedForJIce()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "Ice", () =>
            {
                soda.Ice = true;
            });
        }
        //Changing Ice Should Invoke Property Changed For SpecialInstructions
        public void ChangingJIceShouldIvokePropertyChangedForSpecialInstructions()
        {
            var soda = new JerkedSoda();
            Assert.PropertyChanged(soda, "SpecialInstructions", () =>
            {
                soda.Ice = true;
            });
        }


        /// <summary>
        /// Test Cases For PecosPulledPork
        /// </summary>
        // PecosPulledPork should impliment INotifyPropertyChanged Interface
        [Fact]
        public void PecosPulledPorkShouldImplimentInotifyPropertyCHanged()
        {
            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);
        }
        //Changing Bread Should Invoke Property Changed For Bread
        public void ChangingPBreadShouldIvokePropertyChangedForPBread()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = true;
            });
        }
        //Changing Bread Should Invoke Property Changed For SpecialInstructions
        public void ChangingPBreadShouldIvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = true;
            });
        }
        //Changing Pickle Should Invoke Property Changed For Pickle
        public void ChangingPPickleShouldIvokePropertyChangedForPPickle()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = true;
            });
        }
        //Changing Pickle Should Invoke Property Changed For SpecialInstructions
        public void ChangingPPickleShouldIvokePropertyChangedForSpecialInstructions()
        {
            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = true;
            });
        }


        /// <summary>
        /// Test Cases For TexasTea
        /// </summary>
        // TexasTea should impliment INotifyPropertyChanged Interface
        [Fact]
        public void TexasTeaShouldImplimentInotifyPropertyChanged()
        {
            var tea = new TexasTea();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tea);
        }
        //Changing Ice Should Invoke Property Changed For Ice
        public void ChangingTIceShouldIvokePropertyChangedForTIce()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Ice", () =>
            {
                tea.Ice = false;
            });
        }
        //Changing Ice Should Invoke Property Changed For SpecialInstructions
        public void ChangingTIceShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Ice = false;
            });
        }
        //Changing Sweet Should Invoke Property Changed For Sweet
        public void ChangingSweetShouldIvokePropertyChangedForSweet()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Sweet", () =>
            {
                tea.Sweet = true;
            });
        }
        //Changing Sweet Should Invoke Property Changed For SpecialInstructions
        public void ChangingSweetShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Sweet = true;
            });
        }
        //Changing Lemon Should Invoke Property Changed For Lemon
        public void ChangingLemonShouldIvokePropertyChangedForLemon()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "Lemon", () =>
            {
                tea.Lemon = true;
            });
        }
        //Changing Lemon Should Invoke Property Changed For SpecialInstructions
        public void ChangingLemonShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tea = new TexasTea();
            Assert.PropertyChanged(tea, "SpecialInstructions", () =>
            {
                tea.Lemon = true;
            });
        }


        /// <summary>
        /// Test Cases For TexasTripleBurger
        /// </summary>
        // TexasTripleBurger should impliment INotifyPropertyChanged Interface
        [Fact]
        public void TexasTripleBurgerShouldImplimentInotifyPropertyChanged()
        {
            var tBurger = new TexasTripleBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(tBurger);
        }
        //Changing Bun Should Invoke Property Changed For Bun
        public void ChangingTBunShouldIvokePropertyChangedForTBun()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Bun", () =>
            {
                tBurger.Bun = false;
            });
        }
        //Changing Bun Should Invoke Property Changed For SpecialInstructions
        public void ChangingTBunShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Bun = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For Ketchup
        public void ChangingTKetchupShouldIvokePropertyChangedForTKetchup()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Ketchup", () =>
            {
                tBurger.Ketchup = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For SpecialInstructions
        public void ChangingTKetchupShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Ketchup = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For Mustard
        public void ChangingTMustardShouldIvokePropertyChangedForTMustard()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Mustard", () =>
            {
                tBurger.Mustard = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For SpecialInstructions
        public void ChangingTMustardShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Mustard = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For Pickle
        public void ChangingTPickleShouldIvokePropertyChangedForTPickle()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Pickle", () =>
            {
                tBurger.Pickle = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For SpecialInstructions
        public void ChangingTPickleShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Pickle = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For Cheese
        public void ChangingTCheeseShouldIvokePropertyChangedForTCheese()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Cheese", () =>
            {
                tBurger.Cheese = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For SpecialInstructions
        public void ChangingTCheeseShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Cheese = false;
            });
        }
        //Changing Tomato Should Invoke Property Changed For Tomato
        public void ChangingTTomatoShouldIvokePropertyChangedForTTomato()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Tomato", () =>
            {
                tBurger.Tomato = false;
            });
        }
        //Changing SpecialInstructions Should Invoke Property Changed For SpecialInstructions
        public void ChangingTTomatoShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Tomato = false;
            });
        }
        //Changing Lettuce Should Invoke Property Changed For Lettuce
        public void ChangingTLettuceShouldIvokePropertyChangedForTLettuce()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Lettuce", () =>
            {
                tBurger.Lettuce = false;
            });
        }
        //Changing Lettuce Should Invoke Property Changed For SpecialInstructions
        public void ChangingTLettuceShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Tomato = false;
            });
        }
        //Changing Mayo Should Invoke Property Changed For Mayo
        public void ChangingTMayoShouldIvokePropertyChangedForTMayoe()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Mayo", () =>
            {
                tBurger.Mayo = false;
            });
        }
        //Changing Mayo Should Invoke Property Changed For SpecialInstructions
        public void ChangingTMayoShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Mayo = false;
            });
        }
        //Changing Bacon Should Invoke Property Changed For Bacon
        public void ChangingTBaconShouldIvokePropertyChangedForTBacon()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Bacon", () =>
            {
                tBurger.Bacon = false;
            });
        }
        //Changing Bacon Should Invoke Property Changed For Bacon
        public void ChangingTBaconShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Bacon = false;
            });
        }
        //Changing Egg Should Invoke Property Changed For Egg
        public void ChangingTEggShouldIvokePropertyChangedForTEgg()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "Egg", () =>
            {
                tBurger.Egg = false;
            });
        }
        //Changing Egg Should Invoke Property Changed For SpecialInstructions
        public void ChangingTEggShouldIvokePropertyChangedForSpecialInstructions()
        {
            var tBurger = new TexasTripleBurger();
            Assert.PropertyChanged(tBurger, "SpecialInstructions", () =>
            {
                tBurger.Egg = false;
            });
        }


        /// <summary>
        /// Test Cases For TrailBurger
        /// </summary>
        // TrailBurger should impliment INotifyPropertyChanged Interface
        [Fact]
        public void TrailBurgerShouldImplimentInotifyPropertyChanged()
        {
            var trBurger = new TrailBurger();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(trBurger);
        }
        //Changing Bun Should Invoke Property Changed For Bun
        public void ChangingTRBunShouldIvokePropertyChangedForTRBun()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "Bun", () =>
            {
                trBurger.Bun = false;
            });
        }
        //Changing Bun Should Invoke Property Changed For SpecialInstructions
        public void ChangingTRBunShouldIvokePropertyChangedForSpecialInstructions()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "SpecialInstructions", () =>
            {
                trBurger.Bun = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For Ketchup
        public void ChangingTRKetchupShouldIvokePropertyChangedForTRKetchup()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "Ketchup", () =>
            {
                trBurger.Ketchup = false;
            });
        }
        //Changing Ketchup Should Invoke Property Changed For SpecialInstructions
        public void ChangingTRKetchupShouldIvokePropertyChangedForSpecialInstructions()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "SpecialInstructions", () =>
            {
                trBurger.Ketchup = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For Mustard
        public void ChangingTRMustardShouldIvokePropertyChangedForTRMustard()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "Mustard", () =>
            {
                trBurger.Mustard = false;
            });
        }
        //Changing Mustard Should Invoke Property Changed For SpecialInstructions
        public void ChangingTRMustardShouldIvokePropertyChangedForSpecialInstructions()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "SpecialInstructions", () =>
            {
                trBurger.Mustard = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For Pickle
        public void ChangingTRPickleShouldIvokePropertyChangedForTRPickle()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "Pickle", () =>
            {
                trBurger.Pickle = false;
            });
        }
        //Changing Pickle Should Invoke Property Changed For SpecialInstructions
        public void ChangingTRPickleShouldIvokePropertyChangedForSpecialInstructions()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "SpecialInstructions", () =>
            {
                trBurger.Pickle = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For Cheese
        public void ChangingTRCheeseShouldIvokePropertyChangedForTRCheese()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "Cheese", () =>
            {
                trBurger.Cheese = false;
            });
        }
        //Changing Cheese Should Invoke Property Changed For SpecialInstructions
        public void ChangingTRCheeseShouldIvokePropertyChangedForSpecialInstructions()
        {
            var trBurger = new TrailBurger();
            Assert.PropertyChanged(trBurger, "SpecialInstructions", () =>
            {
                trBurger.Cheese = false;
            });
        }

        /// <summary>
        /// Test Cases For Water
        /// </summary>
        // Water should impliment INotifyPropertyChanged Interface
        [Fact]
        public void WaterShouldImplimentInotifyPropertyChanged()
        {
            var water = new Water();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(water);
        }
        //Changing Ice Should Invoke Property Changed For Ice
        public void ChangingWIceShouldIvokePropertyChangedForWIce()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Ice", () =>
            {
                water.Ice = false;
            });
        }
        //Changing Ice Should Invoke Property Changed For SpecialInstructions
        public void ChangingWIceShouldIvokePropertyChangedForSpecialInstructions()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Ice = false;
            });
        }
        //Changing Lemon Should Invoke Property Changed For Lemon
        public void ChangingWLemonShouldIvokePropertyChangedForWLemon()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "Lemon", () =>
            {
                water.Lemon = false;
            });
        }
        //Changing Lemon Should Invoke Property Changed For SpecialInstructions
        public void ChangingWLemonShouldIvokePropertyChangedForSpecialInstructionsn()
        {
            var water = new Water();
            Assert.PropertyChanged(water, "SpecialInstructions", () =>
            {
                water.Lemon = false;
            });
        }
    }
}
