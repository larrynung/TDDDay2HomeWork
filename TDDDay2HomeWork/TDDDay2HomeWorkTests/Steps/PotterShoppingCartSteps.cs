using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDDay2HomeWork;
using TechTalk.SpecFlow;

namespace TDDDay2HomeWorkTests.Features
{
    [Binding]
    public class PotterShoppingCartSteps
    {
        [BeforeScenario]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Target"] = new PotterShoppingCart();
        }

        [Given(@"第一集買了 (.*) 本")]
        public void Given第一集買了本(int count)
        {
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;
            var goods = target.Goods;
            var book = new Book("Harry Potter and the Philosopher's Stone", "Harry Potter", 1, "J.K. Rowling", 100);

            goods[book] = count;
        }
        
        [Given(@"第二集買了 (.*) 本")]
        public void Given第二集買了本(int count)
        {
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;
            var goods = target.Goods;
            var book = new Book("Harry Potter and the Chamber of Secrets", "Harry Potter", 2, "J.K. Rowling", 100);

            goods[book] = count;
        }
        
        [Given(@"第三集買了 (.*) 本")]
        public void Given第三集買了本(int count)
        {
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;
            var goods = target.Goods;
            var book = new Book("Harry Potter and the Prisoner of Azkaban", "Harry Potter", 3, "J.K. Rowling", 100);

            goods[book] = count;
        }
        
        [Given(@"第四集買了 (.*) 本")]
        public void Given第四集買了本(int count)
        {
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;
            var goods = target.Goods;
            var book = new Book("Harry Potter and the Goblet of Fire", "Harry Potter", 4, "J.K. Rowling", 100);

            goods[book] = count;
        }
        
        [Given(@"第五集買了 (.*) 本")]
        public void Given第五集買了本(int count)
        {
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;
            var goods = target.Goods;
            var book = new Book("Harry Potter and the Order of the Phoenix", "Harry Potter", 5, "J.K. Rowling", 100);

            goods[book] = count;
        }

        [When(@"結帳")]
        public void When結帳()
        {
            var scenarioContext = ScenarioContext.Current;
            var target = ScenarioContext.Current["Target"] as PotterShoppingCart;

            var actual = target.CalculateTotalPrice();

            scenarioContext["actual"] = actual;
        }

        [Then(@"價格應為 (.*) 元")]
        public void Then價格應為元(decimal dollar)
        {
            var actual = (decimal) ScenarioContext.Current["actual"];
            var expected = dollar;

            Assert.AreEqual(expected, actual);
        }
    }
}
