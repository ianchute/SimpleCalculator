using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SimpleCalculator.Scenarios.Models;
using TechTalk.SpecFlow;

namespace SimpleCalculator.Scenarios.Helpers
{
    [Binding]
    public class WebDriverSupport
    {
        private readonly IObjectContainer container;

        public WebDriverSupport(IObjectContainer container)
        {
            this.container = container;
        }

        [BeforeScenario]
        public void Initialize()
        {
            WebServer.Start();

            IWebDriver driver = new ChromeDriver();
            container.RegisterInstanceAs(driver);
            container.RegisterTypeAs<Navigator, INavigator>();
            container.RegisterTypeAs<CalculatorModel, ICalculatorModel>();
            container.RegisterTypeAs<ButtonsModel, IButtonsModel>();
        }

        [AfterScenario]
        public void Cleanup()
        {
            WebServer.Stop();
        }
    }
}