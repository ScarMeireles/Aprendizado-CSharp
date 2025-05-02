namespace BasicCSharpProject.Services;

public class Verificador
{
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
            _ => "Dia Inválido"
        };
        Console.WriteLine($"Hoje é {nomeDia}.");
    }
}
