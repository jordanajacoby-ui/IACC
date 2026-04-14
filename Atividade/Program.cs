using System;
class Program
{
    //EXERCÍCIO 1:
    static void Main()
    {
        int[] notas = { 8, 7, 9, 10, 6 };

        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]}");
        }
        Console.ReadKey();


        //EXERCÍCIO 2:------
        double[] temperaturas = { 25.5, 28.0, 30.2, 22.8, 24.5, 27.0 };
        double soma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }
        double media = soma / temperaturas.Length;
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Média: {media:F2}");
        Console.WriteLine();
        Console.ReadKey();

        //EXERCÍCIO 3:-----
        int[] numeros = { 15, 5, 2, 9, 26, 10 };
        int maior = numeros[0];
        int menor = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
            if (numeros[i] < menor)
            {
                menor = numeros[i];
            }

        }
        Console.WriteLine($"Array: {string.Join(", ", numeros)}");
        Console.WriteLine($"O maior valor é: {maior}");
        Console.WriteLine($"O menor valor é: {menor}");
    }
}