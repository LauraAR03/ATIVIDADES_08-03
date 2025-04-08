using System;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

class Program
{
    static int BuscaSequencialComSentinela(int[] arr, int elemento)
    {
        int n = arr.Length;
        int[] novoArr = new int[n + 1];
        Array.Copy(arr, novoArr, n);
        novoArr[n] = elemento; 

        int i = 0;
        while (novoArr[i] != elemento)
        {
            i++;
        }

        return (i < n) ? i : -1; 
    }

    static int BuscarPalavra(string texto, string palavra)
    {
        int indice = texto.IndexOf(palavra, StringComparison.OrdinalIgnoreCase);
        return indice;
    }

    static void Main()
    {
        int[] numeros = { 10, 25, 7, 30, 5, 40, 15, 30, 25 };
        int elementoBusca = 30;
        int indice = BuscaSequencialComSentinela(numeros, elementoBusca);
        Console.WriteLine(indice != -1
            ? $"O elemento {elementoBusca} foi encontrado no índice: {indice}"
            : $"O elemento {elementoBusca} não foi encontrado no array.");

        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();

        Console.Write("Digite a palavra a ser buscada: ");
        string palavra = Console.ReadLine();

        int posicao = BuscarPalavra(texto, palavra);
        Console.WriteLine(posicao != -1
            ? $"A palavra '{palavra}' foi encontrada na posição: {posicao}"
            : $"A palavra '{palavra}' não foi encontrada no texto.");
    }
}
