using pratica.Model;

//Cria uma instância da classe Pessoa e passa os valores para o construtor
Pessoa p1 = new Pessoa("João", "Silva", 20);	
Pessoa p2 = new Pessoa("Maria", "Santos", 25);
//Cria uma instância da classe Curso
Curso curso = new Curso();
//Atribui um valor para a propriedade NomeDoCurso
curso.NomeDoCurso = "C#";
//Cria uma lista de alunos
curso.Alunos = new List<Pessoa>();
//Adiciona alunos à lista
curso.AdicionarAluno(p1);
//Chama os métodos da classe Curso
curso.ObterQuantidadeDeAlunosMatriculados();
//Listar os alunos matriculados
curso.ListarAlunos();
//Remover um aluno
curso.RemoverAluno(p1);