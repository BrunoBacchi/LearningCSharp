using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1250.70;

        Console.WriteLine("meu salario é " + salario);

        int valor = 12.5;             // não compila.

        int valor2 = 0.0;             // não compila.

        double teste = 125.50;        // compila

        int valor3 = teste;           // não compila.

        Console.ReadLine();
    }
}

