using System;

class Program
{
    static (int, int) EncontrarMaiorMenor(int[] arr)
    {
        if (arr.Length == 0)
            throw new ArgumentException("O array não pode estar vazio.");

        int maior = arr[0];
        int menor = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maior)
                maior = arr[i];
            if (arr[i] < menor)
                menor = arr[i];
        }
        return (maior, menor);
    }

    static int EncontrarMultiplo(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % x == 0)
                return arr[i]; 
        }
        return -1; 
    }

    static void Main()
    {
        int[] numeros = { 10, 25, 7, 30, 5, 40, 15 };
        var (maior, menor) = EncontrarMaiorMenor(numeros);
        Console.WriteLine($"Maior número: {maior}, Menor número: {menor}");

        int x = 5;
        int multiplo = EncontrarMultiplo(numeros, x);
        Console.WriteLine(multiplo != -1
            ? $"O primeiro múltiplo de {x} encontrado foi: {multiplo}"
            : $"Nenhum múltiplo de {x} encontrado no array.");
    }
}

