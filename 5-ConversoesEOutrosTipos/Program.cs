using System;

class Programa
{
    static void Main(string[] args)
    {
        float pontoFlutuante = 3.14f;

        double salario = 3000.10;
        Console.WriteLine(salario);

        int salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
        double valor1 = 0.2;
        double valor2 = 0.1;
        double total = valor1 + valor2;

        Console.WriteLine(total);
        //pode fazer o casting para burlar esse erro, convertenddo uma variável
        //do tipo float para int, como está sendo mostrado acima.
        //exemplo: (int)salario; (linha 13)


        // long é um tipo de veriável de x64 bits, feita pra grandes quantidades
        long x = 2000000000000000000; ;
        Console.WriteLine(x);

        // short é um tipo de variável de x32 bits, feita para pequenas quantidades
        short y = 15000; ;
        Console.WriteLine(y);


        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle enter para fechar ...");
        Console.WriteLine();
    }
}