using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.ComponentModel;

namespace CowboyCafe.DataTests
{
    public class OrderTests 
    {
        public class MockOrderItem : IOrderItem, INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            public double Price { get; set; }

            public List<string> SpecialInstructions { get; set; }
        }
        [Fact]
        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
            
        }
        [Fact]
        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }
        [Fact]
        public void ShouldBeAbleToGetTheEnumerationOfItems()
        {
            var order = new Order();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            var item3 = new MockOrderItem();
            var item4 = new MockOrderItem();
            order.Add(item1);
            order.Add(item2);
            order.Add(item3);
            order.Add(item4);

            Assert.Collection(order.Items,
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item),
                item => Assert.Equal(item3, item),
                item => Assert.Equal(item4, item));
        }
        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 0,0,0 })]
        [InlineData(new double[] { 199,799 })]
        [InlineData(new double[] { 789 })]
        [InlineData(new double[] { } )]
        [InlineData(new double[] { -5 })]
        [InlineData(new double[] { 8, 10, -4 })]
        [InlineData(new double[] { 3.12132 })]
        [InlineData(new double[] { double.NaN })]
        public void SubtotalShouldBeTheSumOfTheItems(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem(){
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }
        [Theory]
        [InlineData("Items")]
        [InlineData("Price")]
        public void AddingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Add(item);
            });
        }
        [Theory]
        [InlineData("Items")]
        [InlineData("Price")]
        public void RemovingAnItemShouldTriggerPropertyChanged(string propertyName)
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.PropertyChanged(order, propertyName, () =>
            {
                order.Remove(item);
            });
        }

        [Fact]
        public void TestingRandomNumber()
        {
            var order = new Order();
            var oldOrder = new Order();
            var olderOrder = new Order();
            Assert.NotEqual(order.OrderNumber, oldOrder.OrderNumber);
            Assert.NotEqual(order.OrderNumber, olderOrder.OrderNumber);
            Assert.NotEqual(olderOrder.OrderNumber, oldOrder.OrderNumber);

        }

    }
}
