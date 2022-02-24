using TechTalk.SpecFlow;

namespace ProjetoDemoblaze.Helpers
{
    [Binding]
    public sealed class Hooks
    {
        private PDFUtils pDFUtils;
        public Hooks()
        {
            pDFUtils = new PDFUtils();
        }

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Iniciando a automação");
        }

        [AfterScenario]
        public void AfterScenario()
        {
         //   pDFUtils.CriarPDF();
        }
    }
}