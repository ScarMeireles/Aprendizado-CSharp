// See https://aka.ms/new-console-template for more information
using BasicCSharpProject.Services;

/*  TODO: Criar um processo de verificação da execução das funções, para caso seja digitado um campo inválido, ele repita o código novamente invés de fechar o console */
class basico
{
    static void Main()
    {

        //  1. Estrutura de um Programa em C#

        Console.WriteLine("Aprendizado básico em C#");
        //using System; → importa funcionalidades básicas(como entrada / saída).
        //Main() → ponto de entrada do programa.
        //Console.WriteLine() → imprime no terminal.



        //  2.Variáveis e Tipos de Dados

        
        double altura = 1.75;
        char letra = 'A';
        string nome1 = "João";
        bool ativo = true;

        //int: números inteiros
        //double: números com casas decimais
        //char: um único caractere
        //string: texto
        //bool: verdadeiro / falso



        //  3. Operadores
        //Como fazer contas e comparações:
        //Aritméticos: +, -, *, /, %
        //Comparação: ==, !=, >, <, >=, <=
        //Lógicos: && (e), || (ou), !(não)

        int a = 10;
        int b = 20;
        bool resultado = a < b && b != 0;



        //  4.Entrada e Saída de Dados
        //Ler dados do usuário com Console.ReadLine():

        Console.Write("Digite seu nome: ");
        string nome2 = Console.ReadLine();

        //Usando Interpolação. 
        Console.WriteLine($"Olá, {nome2}. Seja bem vindo!");
        Console.WriteLine("");
        // A interpolação É quando você insere diretamente o valor de uma variável dentro da própria string,
        //usando colchetes { } e um símbolo $ no início da string para indicar que ela é "interpolada".
        // O símbolo $ informa ao compilador que dentro da string haverá expressões a serem avaliadas, e não apenas texto puro. 
        //Sem ele, os colchetes {} não funcionam como esperado.



        //  5.Estruturas de Controle
        //Controlar o fluxo do programa:
        //Condicional: if, else if, else

        Console.WriteLine("Digite sua Idade");
        int idade = int.Parse(Console.ReadLine());
        Verificador.VerificarIdade(idade);
        Console.WriteLine("");



        //Switch:
        Console.WriteLine("Digite um número de 1 a 7 para o dia da semana:");
        int dia = int.Parse(Console.ReadLine());
        Verificador.VerificarDiaSemana(dia);
        Console.WriteLine("");


        //Laços(repetição):
        Console.WriteLine("Estrutura de repetição usando For:");
        for (int i = 0; i < 11; i++)
        {
            if (i < 9)
            {
                Console.Write(i + ", ");
            }
            else if (i == 9)
            {
                Console.Write(i + " e ");
            } else
            {
                Console.WriteLine(i + ".");
            } 
        }

        Console.WriteLine("");

        Console.WriteLine("Estrutura de repetição usando While:");
        int x = 0;
        while (x < 11)
        {
            if (x < 9)
            {
                Console.Write(x + ", ");
            }
            else if (x == 9)
            {
                Console.Write(x + " e ");
            }
            else
            {
                Console.WriteLine(x + ".");
            }
            x++;
        }


        //      Códigos de Escape úteis
        //      Alguns caracteres especiais são representados com códigos de escape:
        //      \n – nova linha
        //      \t – tabulação
        //      \\ – barra invertida
        //      \" – aspas duplas
        Console.WriteLine("\n Pressione Enter para sair...");
        Console.ReadLine();
    }
}

