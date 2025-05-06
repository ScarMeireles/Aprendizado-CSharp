// See https://aka.ms/new-console-template for more information
using BasicCSharpProject.Services;
using BasicCSharpProject.Anotações;
/*  TODO: Criar um processo de verificação da execução das funções, para caso seja digitado um campo inválido, ele repita o código novamente invés de fechar o console */
class Basico
{
    static void Main()
    {

        //  Estrutura de um Programa em C#

        Console.WriteLine("Aprendizado básico em C#");
        //using System; → importa funcionalidades básicas(como entrada / saída).
        //Main() → ponto de entrada do programa.
        //Console.WriteLine() → imprime no terminal.


        //  Operadores
        //Como fazer contas e comparações:
        //Aritméticos: +, -, *, /, %
        //Comparação: ==, !=, >, <, >=, <=
        //Lógicos: && (e), || (ou), !(não)

        int a = 10;
        int b = 20;
        bool resultado = a < b && b != 0;
        Console.WriteLine(resultado);


        //  Entrada e Saída de Dados
        //Ler dados do usuário com Console.ReadLine():

        Verificador.VerificarNome();



        // A interpolação É quando você insere diretamente o valor de uma variável dentro da própria string,
        //usando colchetes { } e um símbolo $ no início da string para indicar que ela é "interpolada".
        // O símbolo $ informa ao compilador que dentro da string haverá expressões a serem avaliadas, e não apenas texto puro. 
        //Sem ele, os colchetes {} não funcionam como esperado.



        //  Estruturas de Controle
        //Controlar o fluxo do programa:
        //Condicional: if, else if, else

        int idade;
        while (true)
        {
            Console.Write("Digite sua idade: ");
            string? entrada = Console.ReadLine();

            if (int.TryParse(entrada, out idade) && idade > 0) // Verifica se a idade é um número e se é maior que 0.
            {
                break; 
            }
            Console.WriteLine("Idade inválida. Tente novamente.\n");
        }

        Verificador.VerificarIdade(idade);
        Console.WriteLine("");



        //Switch:
        Console.WriteLine("Digite um número de 1 a 7 para o dia da semana:");
        int dia = int.Parse(Console.ReadLine()!);
        Verificador.VerificarDiaSemana(dia);
        Console.WriteLine("");


        //Laços(repetição):
        Repeticao.UsingFor();
        Repeticao.UsingWhile();
        

        Console.WriteLine("");
        Console.WriteLine("Digite uma frase que será passada no TesteString:");
        string frase;
        frase = Console.ReadLine();
        testeString.TesteString(frase);



        //      Códigos de Escape úteis
        //      Alguns caracteres especiais são representados com códigos de escape:
        //      \n – nova linha
        //      \t – tabulação
        //      \\ – barra invertida
        //      \" – aspas duplas
        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
    }
}

