namespace FundamentosLinq.Fundamentos_12
{
    internal class Filme
    {
        public string Titulo { get; set; }
        public int Avaliacao { get; set; }

        public Filme(string titulo, int avaliacao)
        {
            Titulo = titulo;
            Avaliacao = avaliacao;
        }

        public Filme() { }
    }
}
