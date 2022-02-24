using Demoblaze;
using OpenQA.Selenium;
using ProjetoDemoblaze.Logic;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace ProjetoDemoblaze
{

    [Binding]
    [Collection("Chrome Driver")]
    public class CadastroStepDefinitions 
    {
        private IWebDriver driver;
        private CadastroLogic cadastroLogic;
        
       public CadastroStepDefinitions(Home home, CadastroLogic cadastroLogic)
        {
            driver = home.driver;
            this.cadastroLogic = cadastroLogic;
        }

        [Given(@"que eu esteja no site demoblaze")]
       public void GivenQueEuEstejaNoSiteDemoblaze()
       {
            cadastroLogic.ValidacaoDoSiteDemoblaze();
       }

        [When(@"clico em inscrever-se")]
        public void WhenClicoEmInscrever_Se()
        {
            cadastroLogic.ClicarNoBtnSignUpDaHomePage();
        }

        [When(@"preencho o nome do usuario")]
        public void WhenPreenchoONomeDoUsuario()
        {
            cadastroLogic.InserirLoginParaCadastro();
        }

        [When(@"preencho a senha")]
        public void WhenPreenchoASenha()
        {
            cadastroLogic.InserirPasswordParaCadastro();
        }

        [When(@"clico em se inscrever")]
        public void WhenClicoEmIncreverSe()
        {
            cadastroLogic.ClicarNoBtnSignUpDaTelaDeCadastro();
        }

        [When(@"clico em ok no pop up de alerta")]
        public void WhenClicoEmOkNoPopUpDeAlerta()
        {
            cadastroLogic.ClicarEmOkNoPopUpDeAlertaSucesso();
        }

        [Then(@"volto para tela inicial")]
        public void ThenVoltoParaTelaInicial()
        {
            cadastroLogic.ValidaTelaInicial();
        }

        [When(@"clico em ok no pop up de alerta de erro")]
        public void WhenClicoEmOkNoPopUpDeAlertaDeErro()
        {
            cadastroLogic.ClicarEmOkNoPopUpDeAlertaFalha();
        }

        [Then(@"permanesso na tela de cadastro")]
        public void ThenPermanessoNaTelaDeCadastro()
        {
            cadastroLogic.ValidarTelaDeCadastro();
        }

    }
}
