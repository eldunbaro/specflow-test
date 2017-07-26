using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace Specflow.Test
{
    [Binding]
    public class AnswersSteps
    {

        private int _result;

        private Calculator.Calculator _calc = new Calculator.Calculator();

        [Given]
        public void GivenIHaveEntered_NUMBER_IntoTheCalculator(int number)
        {
            _calc.FirstNumber = number;
        }
        
        [Given]
        public void GivenIHaveAlsoEntered_NUMBER_IntoTheCalculator(int number)
        {
            _calc.SecondNumber = number;
        }
        
        [When]
        public void WhenIPressAdd()
        {
            _result = _calc.Add();
        }
        
        [Then]
        public void ThenTheResultShouldBe_RESULT_OnTheScreen(int result)
        {
            Assert.AreEqual(result, _result);
        }

    }
}
