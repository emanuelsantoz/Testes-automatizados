using TestesAutomatizados.Core;

namespace TestesAutomatizados.Page
{
    public class ValidaCepPage : Begin
    {
        public void PreencherText()
        {
            EscrevaTexto("//*[@name='search_query']", "Bom dia, o sol já nasceu na fazendinha!");
        }

        public void CliqueBtn()
        {
            CliqueElement("//*[@id='search-icon-legacy']");
        }

        public void ValidaResultado()
        {
            VerifiqueHaTexto("//yt-formatted-string[@aria-label=\'Mundo Bita - Fazendinha [clipe infantil] Mundo Bita 1.515.262.606 visualizações há 11 anos 2 minutos e 15 segundos']", "Mundo Bita - Fazendinha [clipe infantil]");
        }
    }
}
