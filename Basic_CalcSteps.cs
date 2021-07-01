using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Basic_Calculator1
{
    [Binding]
    public class Basic_CalcSteps
    {
        private int result;
        private Calculator calc = new Calculator();

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number1)
        {
            calc.firstNumber = number1;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number2)
        {
            calc.secondNumber = number2;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = calc.add();
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            result = calc.subtract();
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            result = calc.multiply();
        }
        
        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            result = calc.divide();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, result);
        }
    }
}
