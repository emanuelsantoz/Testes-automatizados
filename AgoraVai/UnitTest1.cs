namespace AgoraVai
{
    public class Tests
    {
        public int a, b, soma, mult, resultadoSoma, resultadoMult;

        [SetUp]
        public void Soma()
        {
            a = 5; b = 6;
            soma = a + b;
            resultadoSoma = 11;

            Assert.That(soma, Is.EqualTo(resultadoSoma));
            Console.WriteLine("O resultado da Soma � "+ resultadoSoma);
        }

        [Test]
        public void Mult()
        {
            a = 5; b = 6;
            mult = a * b;
            resultadoMult = 30;

            Assert.That(soma, Is.EqualTo(resultadoSoma));
            Console.WriteLine("O resultado da multiplica��o � "+ resultadoSoma);
        }

        [TestCase(6, 5, 11)]
        public void SomaEntreDoisNumeros(int x, int y, int resultado)
        {
            // A��o
            soma = x + y;

            // Valida��o
            Assert.That(soma, Is.EqualTo(resultado));
            Console.WriteLine("O resultado da Ultima conta � " + resultado);
        }

        [TearDown]
        public void MultDown()
        {
            if (soma != resultadoSoma)
            {
                Console.WriteLine("O valor da Soma deve ser: " + soma);
                Console.WriteLine("O valor digitado foi: " + resultadoSoma); Assert.Fail();
            }
            else if (mult != resultadoMult)
            {
                Console.WriteLine("O valor da Mult deve ser: " + mult);
                Console.WriteLine("O valor digitado foi: " + resultadoMult); Assert.Fail();
            }
            else
            {
                Console.WriteLine("Muito bem ambos os resultado est�o corretos!");
            }

        }
    }
}