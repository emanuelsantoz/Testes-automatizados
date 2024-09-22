using TestesAutomatizados.Page;

namespace TestesAutomatizados.Test
{
    public class ValidaCepTest : ValidaCepPage
    {
        // [Test]
        public void ValidaCep()
        {
            PreencherText();
            CliqueBtn();
            ValidaResultado();
        }

        // [Test]
        public void Validatable()
        {
            PreencherText();
            CliqueBtn();
            ValidaResultadoTotal();
        }

        [Test]
        public void ValidatableRegiao()
        {
            PreencherText();
            CliqueBtn();
            ValidaMultiplosResultados();
        }
    }
}
