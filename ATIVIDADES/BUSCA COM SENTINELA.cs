using System;

public class Estudante
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

class Programa
{
    static int BuscarElementoComSentinela(int[] array, int elementoBuscado)
    {
        int tamanho = array.Length;
        int[] arrayComSentinela = new int[tamanho + 1];
        Array.Copy(array, arrayComSentinela, tamanho);
        arrayComSentinela[tamanho] = elementoBuscado;

        int indice = 0;
        while (arrayComSentinela[indice] != elementoBuscado)
        {
            indice++;
        }

        return (indice < tamanho) ? indice : -1;
    }

    static void Main()
    {
        int[] numeros = { 10, 25, 7, 30, 5, 40, 15, 30, 25 };
        int numeroBuscado = 30;

        int indiceEncontrado = BuscarElementoComSentinela(numeros, numeroBuscado);
        Console.WriteLine(indiceEncontrado != -1
            ? $"O número {numeroBuscado} foi encontrado no índice: {indiceEncontrado}"
            : $"O número {numeroBuscado} não foi encontrado na array.");
    }
}
