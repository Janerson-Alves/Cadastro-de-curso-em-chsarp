
# Projeto Curso
## Descrição
Este projeto em C# envolve a criação de um sistema de cadastro que gerencia informações de pessoas e cursos. O sistema é composto por duas classes principais: Pessoa e Curso.

## Classe Pessoa
A classe Pessoa é usada para armazenar informações pessoais. Cada instância da classe representa uma pessoa com os seguintes atributos:

 - **Nome**: O nome da pessoa.
 - **Sobrenome**: O sobrenome da pessoa.
 - **Idade**: A idade da pessoa.

## Classe Curso
A classe Curso é usada para gerenciar informações sobre cursos e inscrições de alunos. Cada instância da classe representa um curso com os seguintes atributos e métodos:

 - **Nome do Curso**: O nome do curso.
 - **Alunos**: Uma lista de objetos Pessoa que contém os alunos inscritos no curso.
 - **Adicionar Aluno**: Método utilizado para adicionar um aluno ao curso.
 - **Remover Aluno**: Método utilizado para remover um aluno do curso.
 - **Listar Alunos**: Método utilizado para listar todos os alunos inscritos no curso.
 - **Obter Quantidade de Alunos**:  Método utilizado para obter a quantidade de alunos inscritos no curso.

## Funcionalidade

 - **`Adicionar Alunos`**: Permite adicionar instâncias da  classe Pessoa à lista de alunos de um curso específico. O   usuário insere o nome e sobrenome do aluno, que é então registrado no curso.
 - **`Remover Alunos`**: Permite remover instâncias da classe Pessoa da lista de alunos de um curso. O sistema facilita a remoção de alunos com base no nome e sobrenome fornecidos.
 - **`Listar Alunos`**: Permite listar todos os alunos atualmente inscritos no curso, mostrando o nome e sobrenome de cada aluno.
 - **`Obter Quantidade de Alunos`**: Permite verificar quantos alunos estão atualmente inscritos em um curso específico.

