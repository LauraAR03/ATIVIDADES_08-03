using System;

class Program
{
    static bool ExisteNaLista(int[] arr, int alvo)
    {
        int esquerda = 0, direita = arr.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == alvo)
                return true;
            else if (arr[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return false; 
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int procurado = 7;
        bool existe = ExisteNaLista(numeros, procurado);

        Console.WriteLine(existe ? $"O número {procurado} existe na lista." : $"O número {procurado} não existe na lista.");
    }
}
