using System;

public class Atividade_1
{
    static int BuscaBinaria(int[] array, int alvo)
    {
        int esquerda = 0, direita = array.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;

            if (array[meio] == alvo)
                return meio; 
            else if (array[meio] < alvo)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return -1; 
    }

    static void Main()
    {
        int[] numeros = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int selecionado = 7;
        int indice = BuscaBinaria(numeros, selecionado);
        Console.WriteLine($"O número {selecionado} está no índice {indice}.");
    }
}

