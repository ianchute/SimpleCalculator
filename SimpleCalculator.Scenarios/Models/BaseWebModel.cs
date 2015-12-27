using OpenQA.Selenium;

namespace SimpleCalculator.Scenarios.Models
{
    public abstract class BaseWebModel
    {
        protected readonly IWebDriver driver;

        public BaseWebModel(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}