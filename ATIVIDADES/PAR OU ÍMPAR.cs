using System;

class Aluno
{
    public string Nome { get; set; }
    public int Matricula { get; set; }
}

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

    static Aluno EncontrarAlunoPorMatricula(Aluno[] alunos, int matricula)
    {
        for (int i = 0; i < alunos.Length; i++)
        {
            if (alunos[i].Matricula == matricula)
                return alunos[i]; 
        }
        return null; 
    }

    static int EncontrarUltimaOcorrencia(int[] arr, int elemento)
    {
        int indice = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == elemento)
                indice = i;
        }
        return indice; 
    }

    static int EncontrarPrimeiroPar(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
                return arr[i]; 
        }
        return -1; 
    }

    static void Main()
    {
        int[] numeros = { 10, 25, 7, 30, 5, 40, 15, 30, 25 };
        var (maior, menor) = EncontrarMaiorMenor(numeros);
        Console.WriteLine($"Maior número: {maior}, Menor número: {menor}");

        int x = 5;
        int multiplo = EncontrarMultiplo(numeros, x);
        Console.WriteLine(multiplo != -1
            ? $"O primeiro múltiplo de {x} encontrado foi: {multiplo}"
            : $"Nenhum múltiplo de {x} encontrado no array.");

        Aluno[] alunos =
        {
            new Aluno { Nome = "Ana", Matricula = 101 },
            new Aluno { Nome = "Bruno", Matricula = 102 },
            new Aluno { Nome = "Carla", Matricula = 103 }
        };

        int matriculaBusca = 102;
        Aluno alunoEncontrado = EncontrarAlunoPorMatricula(alunos, matriculaBusca);
        Console.WriteLine(alunoEncontrado != null
            ? $"Aluno encontrado: {alunoEncontrado.Nome} (Matrícula: {alunoEncontrado.Matricula})"
            : "Matrícula não encontrada.");

        int elementoBusca = 30;
        int ultimaOcorrencia = EncontrarUltimaOcorrencia(numeros, elementoBusca);
        Console.WriteLine(ultimaOcorrencia != -1
            ? $"A última ocorrência de {elementoBusca} está no índice: {ultimaOcorrencia}"
            : $"O elemento {elementoBusca} não foi encontrado no array.");

        int primeiroPar = EncontrarPrimeiroPar(numeros);
        Console.WriteLine(primeiroPar != -1
            ? $"O primeiro número par encontrado foi: {primeiroPar}"
            : "Nenhum número par encontrado no array.");
    }
}
