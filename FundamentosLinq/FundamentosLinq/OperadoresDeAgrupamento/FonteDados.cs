namespace FundamentosLinq.Fundamentos_10
{
    internal class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { AlunoId = 1, Curso = "Fisica", Nome = "Vitor", Sexo = 'M', Idade = 18 },
                new Aluno() { AlunoId = 2, Curso = "Quimica", Nome = "Jorge", Sexo = 'M', Idade = 21 },
                new Aluno() { AlunoId = 3, Curso = "Engenharia", Nome = "Bernardo", Sexo = 'M', Idade = 18 },
                new Aluno() { AlunoId = 4, Curso = "Moda", Nome = "Danusa", Sexo = 'F', Idade = 19 },
                new Aluno() { AlunoId = 5, Curso = "Moda", Nome = "Carla", Sexo = 'F', Idade = 20 },
                new Aluno() { AlunoId = 6, Curso = "Fisica", Nome = "Helio", Sexo = 'M', Idade = 21 },
                new Aluno() { AlunoId = 7, Curso = "Engenharia", Nome = "Bianca", Sexo = 'F', Idade = 19 },
                new Aluno() { AlunoId = 8, Curso = "Quimica", Nome = "Vilma", Sexo = 'F', Idade = 20 },
                new Aluno() { AlunoId = 9, Curso = "Engenharia", Nome = "Amanda", Sexo = 'F', Idade = 18 },
                new Aluno() { AlunoId = 10, Curso = "Quimica", Nome = "Silvia", Sexo = 'F', Idade = 21 },
            };

            return alunos;
        }
    }
}
