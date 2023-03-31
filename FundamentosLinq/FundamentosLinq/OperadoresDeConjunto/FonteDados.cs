namespace FundamentosLinq.Fundamentos_4
{
    public class FonteDados
    {
        public static int[] GetIdades()
        {
            var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };
            return idades;
        }

        public static string[] GetNomes()
        {
            var nomes = new[] { "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda" };
            return nomes;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Maria",  Idade = 42, },
                new Aluno() { Nome = "Manoel", Idade = 34, },
                new Aluno() { Nome = "Amanda", Idade = 21, },
                new Aluno() { Nome = "Carlos", Idade = 18, },
                new Aluno() { Nome = "Alicia", Idade = 15, },
                new Aluno() { Nome = "Jaime",  Idade = 36, },
                new Aluno() { Nome = "Debora",  Idade = 33, },
                new Aluno() { Nome = "Sandra",  Idade = 19, },
            };

            return alunos;
        }
    }
}
