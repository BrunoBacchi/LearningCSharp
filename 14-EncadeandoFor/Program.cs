using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 14- Encadeando For!");

        //*
        //**
        //***
        //****
        //*****

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {   
            for (int contadorColuna = 0; contadorColuna <10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
        }

        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinhas; contadorColuna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }


        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}