using TestesAutomatizados.Core;

namespace TestesAutomatizados.Page
{
    public class ValidaCepPage : Begin
    {
        public void PreencherText()
        {
            EscrevaTexto("//*[@name='search']", "Censo_demográfico_do_Brasil_de_2022");
        }

        public void CliqueBtn()
        {
            CliqueElement("//*[@id='searchform']/div/button");
        }

        public void ValidaResultado()
        {
            VerifiqueHaTexto("//yt-formatted-string[@aria-label=\'Mundo Bita - Fazendinha [clipe infantil] Mundo Bita 1.515.262.606 visualizações há 11 anos 2 minutos e 15 segundos']", "Mundo Bita - Fazendinha [clipe infantil]");
        }

        public void ValidaResultadoTotal()
        {
            string[] dados =
            {
                "1º",
                "Região Sudeste",
                "80 364 410",
                "84840113",
                "4475703",
                "5,57"
            };

            for (int i = 0; i < dados.Length; i++)
            {
                VerifiqueHaTexto($"//*[@id=\"mw-content-text\"]/div[1]/table[3]/tbody/tr[1]/td[{i+1}]", dados[i]);
            }
                
        }

        public void ValidaMultiplosResultados()
        {
            string[] position = File.ReadAllLines(@"D:\\Dev\\CSharp\\testes\\TestAutomatizado\\Testes-automatizados\\BD\\position.txt");

            string[] localition = File.ReadAllLines(@"D:\\Dev\\CSharp\\testes\\TestAutomatizado\\Testes-automatizados\\BD\\regiao.txt");

            for (int i = 0; i < position.Length; i++)
            {
                VerifiqueHaTexto($"//*[@id=\"mw-content-text\"]/div[1]/table[3]/tbody/tr[{i+1}]/td[{1}]", position[i]);
                VerifiqueHaTexto($"//*[@id=\"mw-content-text\"]/div[1]/table[3]/tbody/tr[{i+1}]/td[{2}]", localition[i]);
            }

        }
    }
}
