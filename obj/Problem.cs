using System;


public class Problem
{
    public static void Main(string[] args){
     int N1,N2,soma;
    Console.Write("Insira um numero:");
    N1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Insira um outro numero:");
    N2 = Convert.ToInt32(Console.ReadLine());
    soma = N1 + N2;
    Console.WriteLine("A soma do numero {0} com o numero {1} e:{2}",N1,N2,soma);
    }
}

/*public class Problem
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
}*/




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




