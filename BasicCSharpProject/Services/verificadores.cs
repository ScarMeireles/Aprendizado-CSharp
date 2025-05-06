namespace BasicCSharpProject.Services;

public class Verificador
{

    public static void VerificarNome()
    {
        while (true)
        {
            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido. Tente novamente!");
                continue;
            }

            if (!nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("O nome deve conter apenas letras.");
                continue;
            }

            Console.WriteLine($"Olá, {nome}. Seja bem-vindo!");
            break;
        }
    }

    public static void VerificarIdade(int idade)
    {
        if (idade >= 18)
            Console.WriteLine("Você é maior de idade.");
        else if (idade < 18 && idade > 0)
            Console.WriteLine("Você é menor de idade.");
        else
            Console.WriteLine("Idade Inválida.");
    }

    public static void VerificarDiaSemana(int dia)
    {
        string nomeDia = dia switch
        {
            1 => "Domingo",
            2 => "Segunda-feira",
            3 => "Terça-feira",
            4 => "Quarta-feira",
            5 => "Quinta-feira",
            6 => "Sexta-feira",
            7 => "Sábado",
            _ => "um dia inválido"
        };
        Console.WriteLine($"Hoje é {nomeDia}.");
    }
}
