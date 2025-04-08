using System;
using System.Collections.Generic;

class Program
{
    static int EncontrarPrimeiraOcorrencia(int[] arr, int alvo)
    {
        int esquerda = 0, direita = arr.Length - 1;
        int resultado = -1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == alvo)
            {
                resultado = meio;
                direita = meio - 1;
            }
            else if (arr[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return resultado; 
    }

    static int EncontrarUltimaOcorrencia(int[] arr, int alvo)
    {
        int esquerda = 0, direita = arr.Length - 1;
        int resultado = -1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (arr[meio] == alvo)
            {
                resultado = meio; 
                esquerda = meio + 1;
            }
            else if (arr[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return resultado; 
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 3, 3, 5, 7, 7, 9, 11, 13, 15 };
        int procurado = 3;

        int indicePrimeira = EncontrarPrimeiraOcorrencia(numeros, procurado);
        Console.WriteLine(indicePrimeira != -1
            ? $"A primeira ocorrência do número {procurado} está no índice {indicePrimeira}."
            : $"O número {procurado} não foi encontrado na lista.");

        int indiceUltima = EncontrarUltimaOcorrencia(numeros, procurado);
        Console.WriteLine(indiceUltima != -1
            ? $"A última ocorrência do número {procurado} está no índice {indiceUltima}."
            : $"O número {procurado} não foi encontrado na lista.");
    }
}