using Demoblaze;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDemoblaze.Page
{
    public class CadastroPage
    {
        private IWebDriver driver;
        public By BtnRegister { get; private set; }
        public By TxtUserName { get; private set; }
        public By TxtPassword { get; private set; }
        public By BtnSingUp { get; private set; }
        

        public CadastroPage(IWebDriver driver)
        {
            this.driver = driver;
            BtnRegister = By.XPath("//a[@id='signin2']");
            TxtUserName = By.XPath("//input[@id='sign-username']");
            TxtPassword = By.XPath("//input[@id='sign-password']");
            BtnSingUp = By.XPath("//button[contains(text(),'Sign up')]");
        }



    }
}
