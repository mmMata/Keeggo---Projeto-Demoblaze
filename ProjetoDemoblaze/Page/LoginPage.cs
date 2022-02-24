using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDemoblaze.Page
{
    public class LoginPage
    {
        private IWebDriver driver;
        public By BtnLogInHomePage { get; private set; }
        public By TxtUsername { get; private set; }
        public By TxtPassword { get; private set; }
        public By BtnLogIn { get; private set; }


        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            BtnLogInHomePage = By.XPath("//a[@id='login2']");
            TxtUsername = By.XPath("//input[@id='loginusername']");
            TxtPassword = By.XPath("//input[@id='loginpassword']");
            BtnLogIn = By.XPath("//button[contains(text(),'Log in')]"); 
        }
    }
}
