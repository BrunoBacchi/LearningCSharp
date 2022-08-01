using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio Multiplo de 3!");

            for (int multi = 1; multi < 100; multi++)
            {
                if (multi % 3 == 0)
            {
                Console.WriteLine("O multiplos de 3 são :" + multi);
            }
               
            }

        


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
