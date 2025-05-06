namespace BasicCSharpProject.Services;

public class Repeticao
{
    public static void UsingFor()
    {
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
            }
            else
            {
                Console.WriteLine(i + ".");
            }
        }

        Console.WriteLine("");
    }


    public static void UsingWhile()
    {
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
    }
}
