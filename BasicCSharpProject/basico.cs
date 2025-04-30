// See https://aka.ms/new-console-template for more information
using System;

class basico
{
    static void Main()
    {

        //  1. Estrutura de um Programa em C#

        Console.WriteLine("Ola, mundo!");
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
        Console.WriteLine("Olá, " + nome2);



        //  5.Estruturas de Controle
        //Controlar o fluxo do programa:
        //Condicional: if, else if, else

        Console.WriteLine("Digite sua Idade");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
        }
        else if (idade < 18 && idade> 0)
        {
            Console.WriteLine("Menor de idade");
        } else {
            Console.WriteLine("Idade Inválida");
        }



            //Switch:
            Console.WriteLine("Digite um número de 1 a 7 para o dia da semana:");
        int dia = int.Parse(Console.ReadLine());
        switch (dia)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda");
                break;
            case 3:
                Console.WriteLine("Terça");
                break;
            case 4:
                Console.WriteLine("Quarta");
                break;
            case 5:
                Console.WriteLine("Quinta");
                break;
            case 6:
                Console.WriteLine("Sexta");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;

            default:
        Console.WriteLine("Dia Inválido");
        break;
        }



        //Laços(repetição):
        Console.WriteLine("Usando For:");
        for (int i = 0; i < 10; i++)
        {
            if (i < 8)
            {
                Console.Write(i + ", ");
            }
            else if (i == 8)
            {
                Console.Write(i + " e ");
            } else
            {
                Console.Write(i + ".");
            } 
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Usando While:");
        int x = 0;
        while (x < 10)
        {
            if (x < 8)
            {
                Console.Write(x + ", ");
            }
            else if (x == 8)
            {
                Console.Write(x + " e ");
            }
            else
            {
                Console.Write(x + ".");
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

