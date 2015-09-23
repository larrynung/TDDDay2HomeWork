using System;
using TechTalk.SpecFlow;

namespace TDDDay2HomeWorkTests.Steps
{
    [Binding]
    public class PotterShoppingCartSteps
    {
        [Given(@"第一集買了 (.*) 本")]
        public void Given第一集買了本(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"第二集買了 (.*) 本")]
        public void Given第二集買了本(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"第三集買了 (.*) 本")]
        public void Given第三集買了本(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"第四集買了 (.*) 本")]
        public void Given第四集買了本(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"第五集買了 (.*) 本")]
        public void Given第五集買了本(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"結帳")]
        public void When結帳()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"價格應為 (.*) 元")]
        public void Then價格應為元(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
