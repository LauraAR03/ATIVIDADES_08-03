using System;

public class Atividade_2
{
    static int BuscaSequencial(int[] arr, int elemento)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == elemento)
            {
                return i; 
            }
        }
        return -1; 
    }

    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int elemento = 30;
        int resultado = BuscaSequencial(arr, elemento);
        Console.WriteLine($"Elemento {elemento} encontrado no índice: {resultado}");
    }
}

