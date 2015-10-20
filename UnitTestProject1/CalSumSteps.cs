using BelleTestGit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class CalSumSteps
    {
        [Given(@"I have entered First (.*) into the calculator")]
        public void GivenIHaveEnteredFirstIntoTheCalculator(int FirstNum)
        {
            ScenarioContext.Current.Add("first",FirstNum);
        }
        
        [Given(@"I have entered Second (.*) into the calculator")]
        public void GivenIHaveEnteredSecondIntoTheCalculator(int SecondNum)
        {
            ScenarioContext.Current.Add ("second",SecondNum);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            int firstNum = ScenarioContext.Current.Get<int>("first");
            int secondNum = ScenarioContext.Current.Get<int>("second");
            MyCal cal = new MyCal();
            int result = cal.Add(firstNum, secondNum);
            ScenarioContext.Current.Add("result",result);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expected)
        {
            int actual = ScenarioContext.Current.Get<int>("result");
            Assert.AreEqual(expected, actual);
        }
    }
}
