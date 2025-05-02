namespace BasicCSharpProject.Services;

public class Verificador
{
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
            _ => "Dia Inv�lido"
        };
        Console.WriteLine($"Hoje � {nomeDia}.");
    }
}
