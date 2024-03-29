﻿namespace FundamentosLinq.Fundamentos_3
{
    class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Maria",  Idade = 42, Nota = 7, Cursos = new List<string> { "Informática", "EF Core" } },
                new Aluno() { Nome = "Manoel", Idade = 34, Nota = 6, Cursos = new List<string> { "Spring", "Java", "Oracle" } },
                new Aluno() { Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List<string> { "Node", "JavaScript", "React" } },
                new Aluno() { Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List<string> { "Dart", "Futter", "Firebase" } },
                new Aluno() { Nome = "Alicia", Idade = 15, Nota = 4, Cursos = new List<string> { "C#", ".NET", "EF Core" } },
            };

            return alunos;
        }

        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>()
            {
                new Funcionario() { Nome = "Maria", Idade = 22, Salario = 3290.55m },
                new Funcionario() { Nome = "Manoel", Idade = 24, Salario = 4125.45m },
                new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 5123.99m },
                new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 6200.50m },
                new Funcionario() { Nome = "Alicia", Idade = 17, Salario = 4099.11m },
            };

            return funcionarios;
        }
    }
}
