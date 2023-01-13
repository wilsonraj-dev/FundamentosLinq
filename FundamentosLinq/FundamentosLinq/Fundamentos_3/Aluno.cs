namespace FundamentosLinq.Fundamentos_3
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();
    }
}
