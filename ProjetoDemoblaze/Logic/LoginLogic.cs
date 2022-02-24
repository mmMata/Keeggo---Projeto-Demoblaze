using Demoblaze;
using Demoblaze.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjetoDemoblaze.Helpers;
using ProjetoDemoblaze.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ProjetoDemoblaze.Logic
{
    public class LoginLogic
    {
        private LoginPage loginPage;

        private IWebDriver driver;

        private CSV csvHelper;

        

        public LoginLogic(Home home)
        {
            driver = home.driver;
            loginPage = new LoginPage(driver);
            csvHelper = new CSV();
            
                  
        }

        public bool isAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void ValidacaoDoSiteDemoblaze()
        {
            driver.Navigate().GoToUrl("https://www.demoblaze.com/index.html");
            Assert.Contains("STORE", driver.Title);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login.png",
            ScreenshotImageFormat.Png);
            

        }

        public void ClicarNoBtnLogInDaHomePage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var login = wait.Until(c => c.FindElement(loginPage.BtnLogInHomePage));
            login.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login1.png",
            ScreenshotImageFormat.Png); 
            
        }

        public void PreencherUserName()
        {
             var login = loginPage.TxtUsername;
             var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             wait.Until(drv => drv.FindElement(login).Displayed);
             driver.FindElement(login).SendKeys("Mawqeqw");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login2.png",
            ScreenshotImageFormat.Png);
        }

        public void PreencherPassword()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var password = wait.Until(s => s.FindElement(loginPage.TxtPassword));
            var senha = csvHelper.GetValueByRowAndColumn("massas.csv", 1, "Password");
            password.SendKeys(senha);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login3.png",
            ScreenshotImageFormat.Png);

        }

        public void ClicarNoBtnLogIn()
        {
         
            IWebElement alertButton = driver.FindElement(loginPage.BtnLogIn);
            alertButton.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login4.png",
            ScreenshotImageFormat.Png);
        }

        public void ValidarLogin()
        {
            Thread.Sleep(1000);
            Assert.Contains("CATEGORIES", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login5.png",
            ScreenshotImageFormat.Png);
        }

        public void ClicarEmOkNoPopUpDeAlertaFalha()
        {

            if (isAlertPresent())
            {
                var TextAlert = "Wrong password.";
                IAlert alerta = driver.SwitchTo().Alert();
                string textAlert = alerta.Text;
                alerta.Accept();
               
            }
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login6.png",
            ScreenshotImageFormat.Png);

        }

        public void ValidarTelaDeLogin()
        {
            
            Assert.Contains("Log in", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\login7.png",
            ScreenshotImageFormat.Png);
        }
    }
}
