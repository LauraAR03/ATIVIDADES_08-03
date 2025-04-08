using System;
using System.Collections.Generic;

class Program
{
    static List<int> EncontrarOcorrencias(int[] arr, int alvo)
    {
        List<int> indices = new List<int>();
        int esquerda = 0, direita = arr.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == alvo)
            {
                indices.Add(meio);

               
                int i = meio - 1;
                while (i >= 0 && arr[i] == alvo)
                {
                    indices.Add(i);
                    i--;
                }

                
                int j = meio + 1;
                while (j < arr.Length && arr[j] == alvo)
                {
                    indices.Add(j);
                    j++;
                }

                break; 
            }
            else if (arr[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        indices.Sort();
        return indices;
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 7, 7, 9, 11, 13, 15 };
        int procurado = 7;
        List<int> indices = EncontrarOcorrencias(numeros, procurado);

        if (indices.Count > 0)
            Console.WriteLine($"O número {procurado} ocorre nos índices: {string.Join(", ", indices)}");
        else
            Console.WriteLine($"O número {procurado} não foi encontrado na lista.");
    }
}

