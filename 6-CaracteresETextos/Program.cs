using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - Caracteres e Textos");
        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(83 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java"; //Fazer listagem: utilizar o @ na frente do começo 
         //das aspas de uma string (exemplo linha 28)
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar....");
        Console.ReadLine();
    }
}


