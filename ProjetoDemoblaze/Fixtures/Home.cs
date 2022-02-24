using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoblaze
{
    public class Home : IDisposable
    {
        public IWebDriver driver;

        //Setup
        public Home()
        {
            driver = new ChromeDriver(Helper.Executavel);
            driver.Manage().Window.Minimize();
        }

        //TearDown
        public void Dispose()
        {
            driver.Quit();
        }

    }
}
