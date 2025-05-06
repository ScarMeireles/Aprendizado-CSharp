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
                Console.WriteLine("Nome inv�lido. Tente novamente!");
                continue;
            }

            if (!nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                Console.WriteLine("O nome deve conter apenas letras.");
                continue;
            }

            Console.WriteLine($"Ol�, {nome}. Seja bem-vindo!");
            break;
        }
    }

    public static void VerificarIdade(int idade)
    {
        if (idade >= 18)
            Console.WriteLine("Voc� � maior de idade.");
        else if (idade < 18 && idade > 0)
            Console.WriteLine("Voc� � menor de idade.");
        else
            Console.WriteLine("Idade Inv�lida.");
    }

    public static void VerificarDiaSemana(int dia)
    {
        string nomeDia = dia switch
        {
            1 => "Domingo",
            2 => "Segunda-feira",
            3 => "Ter�a-feira",
            4 => "Quarta-feira",
            5 => "Quinta-feira",
            6 => "Sexta-feira",
            7 => "S�bado",
            _ => "um dia inv�lido"
        };
        Console.WriteLine($"Hoje � {nomeDia}.");
    }
}
