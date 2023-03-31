namespace FundamentosLinq.Fundamentos_12
{
    internal class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>
            {
                new Aluno() { Id = 1, Nome= "Maria", EnderecoId = 1, CursoId = 10 },
                new Aluno() { Id = 2, Nome= "Manoel", EnderecoId = 2, CursoId = 20 },
                new Aluno() { Id = 3, Nome= "Amanda", EnderecoId = 3, CursoId = 30 },
                new Aluno() { Id = 4, Nome= "Carlos", EnderecoId = 4, CursoId = 40 },
                new Aluno() { Id = 5, Nome= "Jaime", EnderecoId = 5, CursoId = 10 },
                new Aluno() { Id = 6, Nome= "Debora", EnderecoId = 6, CursoId = 20 },
                new Aluno() { Id = 7, Nome= "Alicia", EnderecoId = 4, CursoId = 30 },
                new Aluno() { Id = 8, Nome= "Sandra", EnderecoId = 7, CursoId = 40 },
                new Aluno() { Id = 9, Nome= "Marta", EnderecoId = 2, CursoId = 0 },
                new Aluno() { Id = 10, Nome= "Sueli", EnderecoId = 7, CursoId = 30 },
            };

            return alunos;
        }
    }
}
