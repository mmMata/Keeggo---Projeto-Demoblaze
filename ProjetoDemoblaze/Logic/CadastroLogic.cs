using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demoblaze;
using Demoblaze.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using ProjetoDemoblaze.Page;
using Xunit;

namespace ProjetoDemoblaze.Logic
{

    public class CadastroLogic
    {
        private CadastroPage cadastroPage;

        private IWebDriver driver;

        private CSV csvHelper;


        public CadastroLogic(Home home)
        {
            driver = home.driver;
            cadastroPage = new CadastroPage(driver);
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
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro.png",
            ScreenshotImageFormat.Png);


        }
        public void ClicarNoBtnSignUpDaHomePage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var cadastro = wait.Until(c => c.FindElement(cadastroPage.BtnRegister));
            cadastro.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro1.png",
            ScreenshotImageFormat.Png);
        }
        public void InserirLoginParaCadastro()
        {

            var login = cadastroPage.TxtUserName;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(drv => drv.FindElement(login).Displayed);
            driver.FindElement(login).SendKeys("werewrwewerreewww");
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro2.png",
            ScreenshotImageFormat.Png);

        }
        public void InserirPasswordParaCadastro()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var password = wait.Until(s => s.FindElement(cadastroPage.TxtPassword));
            var senha = csvHelper.GetValueByRowAndColumn("massas.csv", 1, "Password");
            password.SendKeys(senha);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro3.png",
            ScreenshotImageFormat.Png);
        }
        public void ClicarNoBtnSignUpDaTelaDeCadastro()
        {
            IWebElement alertButton = driver.FindElement(cadastroPage.BtnSingUp);
            alertButton.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro4.png",
            ScreenshotImageFormat.Png);

        }
        public void ClicarEmOkNoPopUpDeAlertaSucesso()
        {
            if (isAlertPresent())
            {

                var TextAlert = "Sign up successful.";
                IAlert alerta = driver.SwitchTo().Alert();
                string textAlert = alerta.Text;
                alerta.Accept();

            }
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro5.png",
            ScreenshotImageFormat.Png);
        }

        public void ValidaTelaInicial()
        {
            Assert.Contains("PRODUCT STORE", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro6.png",
            ScreenshotImageFormat.Png);
        }


        public void ClicarEmOkNoPopUpDeAlertaFalha()
        {
            if (isAlertPresent())
            {

                var TextAlert = "This user already exist.";
                IAlert alerta = driver.SwitchTo().Alert();
                string textAlert = alerta.Text;
                alerta.Accept();

            }
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro7.png",
            ScreenshotImageFormat.Png);
        }
        public void ValidarTelaDeCadastro()
        {
            Assert.Contains("Username:", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\cadastro8.png",
            ScreenshotImageFormat.Png);
        }





    }
}
