using System;

namespace ProjetoEscola
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
    }

    class Programa
    {
        static (int maior, int menor) ObterMaiorEMenor(int[] valores)
        {
            if (valores.Length == 0)
                return (0, 0);

            int maior = valores[0];
            int menor = valores[0];

            foreach (int valor in valores)
            {
                if (valor > maior)
                    maior = valor;
                if (valor < menor)
                    menor = valor;
            }

            return (maior, menor);
        }

        static int PrimeiroMultiploDe(int[] valores, int divisor)
        {
            foreach (int valor in valores)
            {
                if (valor % divisor == 0)
                    return valor;
            }
            return -1;
        }

        static Aluno BuscarAlunoPorMatricula(Aluno[] listaAlunos, int matricula)
        {
            foreach (Aluno aluno in listaAlunos)
            {
                if (aluno.Matricula == matricula)
                    return aluno;
            }
            return null;
        }

        static void Main()
        {
            int[] numeros = { 10, 25, 7, 30, 5, 40, 15 };

            var (maior, menor) = ObterMaiorEMenor(numeros);
            Console.WriteLine($"Maior número: {maior}, Menor número: {menor}");

            int divisor = 5;
            int multiplo = PrimeiroMultiploDe(numeros, divisor);
            Console.WriteLine(multiplo != -1
                ? $"O primeiro múltiplo de {divisor} encontrado foi: {multiplo}"
                : $"Nenhum múltiplo de {divisor} encontrado.");

            Aluno[] alunos = {
                new Aluno { Nome = "seila", Matricula = 101 },
                new Aluno { Nome = "seila2", Matricula = 102 },
                new Aluno { Nome = "seila3", Matricula = 103 }
            };

            int matriculaBuscada = 102;
            Aluno aluno = BuscarAlunoPorMatricula(alunos, matriculaBuscada);
            Console.WriteLine(aluno != null
                ? $"Aluno encontrado: {aluno.Nome} (Matrícula: {aluno.Matricula})"
                : "Matrícula não encontrada.");
        }
    }
}
