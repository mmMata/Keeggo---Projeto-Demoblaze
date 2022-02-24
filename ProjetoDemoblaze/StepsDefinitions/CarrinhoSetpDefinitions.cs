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

    public class CarrinhoStepsDefinitions
    {
        private IWebDriver driver;
        private LoginLogic loginLogic;
        private CarrinhoLogic carrinhoLogic;
        
        public CarrinhoStepsDefinitions(Home home, LoginLogic loginLogic, CarrinhoLogic carrinhoLogic)
        {
            driver = home.driver;
            this.carrinhoLogic = carrinhoLogic;
            this.loginLogic = loginLogic;
        }
        [Given(@"que eu esteja no site do demoblaze")]
        public void GivenQueEuEstejaNoSiteDoDemoblaze()
        {
           loginLogic.ValidacaoDoSiteDemoblaze();
        }

        [When(@"clico em login")]
        public void WhenClicoEmLogin()
        {
            loginLogic.ClicarNoBtnLogInDaHomePage();
        }

        [When(@"preencho o meu usuario")]
        public void WhenPreenchoOMeuUsuario()
        {
            loginLogic.PreencherUserName();
        }

        [When(@"preencho a minha senha")]
        public void WhenPreenchoAMinhaSenha()
        {
            loginLogic.PreencherPassword();
        }

        [When(@"realizo o login")]
        public void WhenRealizoOLogin()
        {
            loginLogic.ClicarNoBtnLogIn();
        }

        [When(@"seleciono um item")]
        public void WhenSelecionoUmItem()
        {
            carrinhoLogic.SelecionarItem();
        }

        [When(@"adicono um item carrinho")]
        public void WhenAdiconoUmItemCarrinho()
        {
         carrinhoLogic.AdicionarItem();
        }

        [When(@"valido o pop up de alerta")]
        public void WhenValidoOPopUpDeAlerta()
        {
           carrinhoLogic.ValidarPopUp();
        }

        [Then(@"permanesso na tela da descricao do produto")]
        public void ThenPermanessoNaTelaDaDescricaoDoProduto()
        {
            carrinhoLogic.ValidarTelaDescricaoProduto();
        }

        [When(@"clico no carrinho")]
        public void WhenClicoNoCarrinho()
        {
           carrinhoLogic.ClicarNoCarrinho();
        }

        [When(@"clico em delete")]
        public void WhenClicoEmDelete()
        {
            carrinhoLogic.ClicarEmDelete();
        }

        [Then(@"valido que o item foi removido")]
        public void ThenValidoQueOItemFoiRemovido()
        {
          carrinhoLogic.ValidarCarrinhoVazio();
        }

    }
}
