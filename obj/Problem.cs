using System;

public class Problem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("E agora pai esta bom ");
        Console.WriteLine("sim/não ");
        string resposta = Console.ReadLine();
              if (resposta != null && resposta.ToLower() == "sim")
        {
            Console.WriteLine("Fico feliz em saber até a proxima!");
        }
        else if (resposta != null && resposta.ToLower() == "não")
        {
            Console.WriteLine("Putz ai não.");
        }
        else
        {
            Console.WriteLine("Rapaz não era essa a resposta que eu queria.");
        }
    }
}




/*public class Problem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Como se chama?");
        string nome = Console.ReadLine();
        Console.WriteLine($"Bem-vindo(a) {nome}");
    }
}*/
/*class Problem
{
    static void Main()
    {
        Console.WriteLine("Olá!");
        Console.WriteLine("Você está bem? (sim/não)");

        string resposta = Console.ReadLine();

        if (resposta != null && resposta.ToLower() == "sim")
        {
            Console.WriteLine("Fico feliz em saber que está bem!");
        }
        else if (resposta != null && resposta.ToLower() == "não")
        {
            Console.WriteLine("Espero que fique melhor em breve.");
        }
        else
        {
            Console.WriteLine("Resposta não reconhecida.");
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}*/




