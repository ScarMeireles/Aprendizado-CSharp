using static System.Net.Mime.MediaTypeNames;

namespace BasicCSharpProject.Anotações
{
    public class testeString
    {
        public static void TesteString(string texto)
        {
            Console.WriteLine("O texto inserido foi: " + texto);
            Console.WriteLine($"O Texto inserido possui {texto.Length} letras");

            if (texto.Contains("a") || texto.Contains("A"))
            {
                Console.WriteLine("O texto inserido contem a letra 'A'");
            }
            else
            {
                Console.WriteLine("O texto inserido NÃO contém a letra 'A'");
            }
        }        
    }
}
