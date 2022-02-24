using Demoblaze;
using OpenQA.Selenium;
using ProjetoDemoblaze.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace ProjetoDemoblaze.StepsDefinitions
{
    [Binding]
    [Collection("Chrome Driver")]
    public class LoginStepDefinitions
    {
        private IWebDriver driver;
        private LoginLogic loginLogic;

        public LoginStepDefinitions(Home home, LoginLogic loginLogic)
        {
            driver = home.driver;
            this.loginLogic = loginLogic;

        }

        [Given(@"que eu esteja no site")]
        public void GivenQueEuEstejaNoSiteDemoblaze()
        {
            loginLogic.ValidacaoDoSiteDemoblaze();
        }

        [When(@"clico em Conecte-se")]
        public void WhenClicoEmConecte_Se()
        {
            loginLogic.ClicarNoBtnLogInDaHomePage();
        }

        [When(@"preencho o usuario")]
        public void WhenPreenchoONomeDoUsuario()
        {
            loginLogic.PreencherUserName();
        }

        [When(@"preencho senha")]
        public void WhenPreenchoASenha()
        {
            loginLogic.PreencherPassword();
        }

        [When(@"clico em Conecte se")]
        public void WhenClicoEmConecteSe()
        {
            loginLogic.ClicarNoBtnLogIn();
        }


        [Then(@"realizo o login")]
        public void ThenRealizoOLogin()
        {
            loginLogic.ValidarLogin(); 
        }

        [Then(@"permanesso na tela de login")]
        public void ThenPermanessoNaTelaDeLogin()
        {
            loginLogic.ValidarTelaDeLogin();
        }
    }
}