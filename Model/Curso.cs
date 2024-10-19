using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pratica.Model
{
    public class Curso
    {
        public string NomeDoCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        //Adicionar aluno
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void ObterQuantidadeDeAlunosMatriculados()
        {
            int qtd_alunos = Alunos.Count;
            Console.WriteLine($"O curso {NomeDoCurso} possui {qtd_alunos} alunos matriculados.");
        }

        public void ListarAlunos()
        {
            foreach(var aluno in Alunos)
            {
                Console.WriteLine($"Nome: {aluno.NomeCompleto}");
            }
        }
        //remover aluno
        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
            Console.WriteLine("Aluno removido com sucesso!");
        }
    }
}