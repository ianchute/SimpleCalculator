using OpenQA.Selenium;
using SimpleCalculator.Scenarios.Helpers;

namespace SimpleCalculator.Scenarios.Models
{
    public interface ICalculatorModel
    {
        IWebElement OverallPanel { get; }
        IWebElement DisplayPanel { get; }
        IButtonsModel Buttons { get; }
    }

    public class CalculatorModel : BaseWebModel, ICalculatorModel
    {
        private readonly IButtonsModel buttons;

        public CalculatorModel(IWebDriver driver, IButtonsModel buttons) : base(driver)
        {
            this.buttons = buttons;
        }

        public IButtonsModel Buttons
        {
            get
            {
                return buttons;
            }
        }

        public IWebElement DisplayPanel
        {
            get
            {
                return driver.Find("panel_display");
            }
        }

        public IWebElement OverallPanel
        {
            get
            {
                return driver.Find("panel_overall");
            }
        }
    }
}