using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDemoblaze.Page
{
    public class CarrinhoPage
    {
        private IWebDriver driver;
        public By BtnItem { get; private set; }
        public By BtnAddToCart { get; private set; }
        public By BtnCart { get; private set; }
        public By BtnRemove { get; private set; } 
        public By ListCart { get; private set; }
        public CarrinhoPage(IWebDriver driver)
        {
            this.driver = driver;

            BtnItem = By.XPath("//a[@href='prod.html?idp_=5']");   
            BtnAddToCart = By.XPath("//a[text()='Add to cart']");
            BtnCart = By.XPath("//a[@id='cartur']");
            BtnRemove = By.XPath("//a[contains(text(),'Delete')]");
            ListCart = By.XPath("//tbody[@id='tbodyid']"); //following::tr[@class='success']

        }
    }
}
