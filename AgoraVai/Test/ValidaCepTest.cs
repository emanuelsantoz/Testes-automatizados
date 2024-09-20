using TestesAutomatizados.Page;

namespace TestesAutomatizados.Test
{
    public class ValidaCepTest : ValidaCepPage
    {
        [Test]
        public void ValidaCep()
        {
            PreencherText();
            CliqueBtn();
            ValidaResultado();
        }
    }
}
