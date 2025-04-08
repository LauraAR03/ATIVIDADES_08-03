using System;

namespace ProjetoBuscaNomes
{
    public class Program
    {
        static int EncontrarIndice(string[] arr, string nome)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == nome)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            string[] nomes = { "Alice", "Bob", "Charlie", "David", "Eve" };
            string nomeProcurado = "Charlie";
            int indice = EncontrarIndice(nomes, nomeProcurado);
            Console.WriteLine($"O nome {nomeProcurado} está no índice: {indice}");
        }
    }
}
