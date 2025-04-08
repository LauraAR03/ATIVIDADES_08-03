using System;
using System.Collections.Generic;

class Program
{
    static bool BuscaBinariaDicionario(string[] dicionario, string palavra)
    {
        int esquerda = 0, direita = dicionario.Length - 1;

        while (esquerda <= direita)
        {
            int meio = (esquerda + direita) / 2;
            int comparacao = string.Compare(dicionario[meio], palavra, StringComparison.OrdinalIgnoreCase);

            if (comparacao == 0)
                return true; 
            else if (comparacao < 0)
                esquerda = meio + 1;
            else
                direita = meio - 1;
        }

        return false; 
    }

    static void Main()
    {
        string[] dicionario = { "amor", "bola", "carro", "dado", "elefante", "faca", "gato" };
        string palavraProcurada = "carro";

        bool encontrada = BuscaBinariaDicionario(dicionario, palavraProcurada);
        Console.WriteLine(encontrada
            ? $"A palavra '{palavraProcurada}' foi encontrada no dicionário."
            : $"A palavra '{palavraProcurada}' não está no dicionário.");
    }
}
