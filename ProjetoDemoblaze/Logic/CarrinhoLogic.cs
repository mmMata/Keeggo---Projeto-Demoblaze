using Demoblaze;
using Demoblaze.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjetoDemoblaze.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ProjetoDemoblaze.Logic
{
    public class CarrinhoLogic
    {
        private IWebDriver driver;

        private CSV csvHelper;

        private CarrinhoPage carrinhoPage;

        private IJavaScriptExecutor js;

        

        public CarrinhoLogic(Home home)
        {
            driver = home.driver;
            carrinhoPage = new CarrinhoPage(driver);
            csvHelper = new CSV();
            js = (IJavaScriptExecutor)driver;

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
           public void SelecionarItem()
        {
            var btnItem = driver.FindElement(carrinhoPage.BtnItem);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            js.ExecuteScript("arguments[0].scrollIntoView(true);", btnItem );
            js.ExecuteScript("arguments[0].click();", btnItem);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho.png",
            ScreenshotImageFormat.Png);
        }

        public void AdicionarItem()
        {
            Thread.Sleep(1000);
            IWebElement alertButton = driver.FindElement(carrinhoPage.BtnAddToCart);
            alertButton.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho1.png",
            ScreenshotImageFormat.Png);
        }

        public void ValidarPopUp()
        {
            if (isAlertPresent())
            {
                var TextAlert = "Product added.";
                IAlert alerta = driver.SwitchTo().Alert();
                string textAlert = alerta.Text;
                alerta.Accept();
            }
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho2.png",
            ScreenshotImageFormat.Png);
        }

        public void ValidarTelaDescricaoProduto()
        {
            Assert.Contains("About Us", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho3.png",
            ScreenshotImageFormat.Png);
        }

        public void ClicarNoCarrinho()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var login = wait.Until(c => c.FindElement(carrinhoPage.BtnCart));
            login.Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho4.png",
            ScreenshotImageFormat.Png);
        }

        public void ClicarEmDelete()
        {
            Thread.Sleep(1000);
            driver.FindElement(carrinhoPage.BtnRemove).Click();
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho5.png",
            ScreenshotImageFormat.Png);
        }

        public void ValidarCarrinhoVazio()
        {
            Thread.Sleep(1000);
            
            Assert.DoesNotContain("Delete", driver.PageSource);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile("C:\\Users\\matheus.mata\\ProjetoDemoblaze\\ProjetoDemoblaze\\Screenshot\\carrinho6.png",
            ScreenshotImageFormat.Png);

        }

    }
}
