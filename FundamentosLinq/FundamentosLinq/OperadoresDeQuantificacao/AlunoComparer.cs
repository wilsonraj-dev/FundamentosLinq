using System.Diagnostics.CodeAnalysis;

namespace FundamentosLinq.Fundamentos_9
{
    internal class AlunoComparer : IEqualityComparer<Aluno>
    {
        /// <summary>
        /// Alunos são iguais se os nomes e os pontos forem iguais
        /// </summary>
        public bool Equals(Aluno x, Aluno y)
        {
            //Se ambas referências do objeto forem iguais retorna true
            if (object.ReferenceEquals(x, y))
                return true;

            //Se uma das referências for null retorna false
            if (x is null || y is null)
                return false;

            return x.Nome == y.Nome && x.Pontos == y.Pontos;
        }

        /// <summary>
        /// Se Equals() retornar true para o par de objetos GetHasCode() tem que 
        /// retornar os mesmos valores para os objetos
        /// </summary>
        public int GetHashCode([DisallowNull] Aluno obj)
        {
            //Se o objeto for null retorna 0
            if (obj is null)
                return 0;

            int nomeHashCode = obj.Nome == null ? 0 : obj.Nome.GetHashCode();
            int pontosHashCode = obj.Pontos.GetHashCode();
            return nomeHashCode ^ pontosHashCode;
        }
    }
}
