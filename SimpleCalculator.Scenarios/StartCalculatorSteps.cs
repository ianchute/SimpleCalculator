using NUnit.Framework;
using SimpleCalculator.Scenarios.Models;
using TechTalk.SpecFlow;

namespace SimpleCalculator.Scenarios
{
    [Binding]
    public class StartCalculatorSteps
    {
        private readonly ICalculatorModel calculator;
        private readonly INavigator navigator;

        public StartCalculatorSteps(
            INavigator navigator, 
            ICalculatorModel calculator)
        {
            this.navigator = navigator;
            this.calculator = calculator;
        }

        [Given(@"I have started the browser")]
        public void GivenIHaveStartedTheBrowser()
        {
            // Assumed.
        }
        
        [When(@"I have gone to the proper url address of the SimpleCalculator application")]
        public void WhenIHaveGoneToTheProperUrlAddressOfTheSimpleCalculatorApplication()
        {
            navigator.GoToHomePage();
        }

        [Then(@"the panels of the SimpleCalculator should be displayed")]
        public void ThenThePanelsOfTheSimpleCalculatorShouldBeDisplayed()
        {
            Assert.That(calculator.OverallPanel.Displayed, "Overall panel not found!");
            Assert.That(calculator.DisplayPanel.Displayed, "Display panel not found!");
        }

        [Then(@"the display panel should contain the number zero")]
        public void ThenTheDisplayPanelShouldContainTheNumberZero()
        {
            Assert.That(calculator.DisplayPanel.Text, Is.EqualTo("0"), "Display Panel should contain the number zero!");
        }


        [Then(@"the buttons of the SimpleCalculator should be displayed")]
        public void ThenTheButtonsOfTheSimpleCalculatorShouldBeDisplayed()
        {
            Assert.That(calculator.Buttons.Add.Displayed, "Add button not found!");
            Assert.That(calculator.Buttons.ClosedParenthesis.Displayed, "Closed parenthesis button not found!");
            Assert.That(calculator.Buttons.DecimalPoint.Displayed, "Decimal point button not found!");
            Assert.That(calculator.Buttons.Divide.Displayed, "Divide button not found!");
            Assert.That(calculator.Buttons.Equal.Displayed, "Equal button not found!");
            Assert.That(calculator.Buttons.Exponent.Displayed, "Exponent button not found!");
            Assert.That(calculator.Buttons.Multiply.Displayed, "Multiply button not found!");
            Assert.That(calculator.Buttons.OpenParenthesis.Displayed, "Open parenthesis button not found!");
            Assert.That(calculator.Buttons.Subtract.Displayed, "Subtract button not found!");

            for (int n = 0; n < 10; ++n)
                Assert.That(calculator.Buttons.GetDigit(n).Displayed);
        }
    }
}