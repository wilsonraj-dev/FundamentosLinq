namespace FundamentosLinq.Fundamentos_5
{
    class OperadoresDeConjunto2
    {
        static void Main(string[] args)
        {
            //INTERSECT

            List<int> fonte1 = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<int> fonte2 = new List<int> { 1, 3, 5, 8, 9, 10 };

            //Method Syntax
            var resultado = fonte1.Intersect(fonte2).ToList();
            foreach (var item in resultado)
            {
                Console.WriteLine($"{item} ");
            }

            //Query Syntax
            var resultado2 = (from num in fonte1
                              select num)
                              .Intersect(fonte2).ToList();
            foreach (var item in resultado)
            {
                Console.WriteLine($"{item} ");
            }


            string[] paises1 = { "Brasil", "Argentina", "UK", "USA", "China" };
            string[] paises2 = { "Brasil", "uk", "Japão", "França", "Argentina" };

            var resultadoPaises = paises1.Intersect(paises2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var paises in resultadoPaises)
            {
                Console.WriteLine($"{paises} ");
            }

            //INTERSECTBY

            var turmaA = FonteDados.GetTurmaA();
            var turmaB = FonteDados.GetTurmaB();

            var consulta2 = turmaA.Select(p => p.Nascimento.Year)
                            .Intersect(turmaB.Select(p => p.Nascimento.Year));

            var alunosTurmaAComMesmoAnoNascimento = turmaA.IntersectBy(turmaB.Select(p => p.Nascimento.Year),
                                                                       p => p.Nascimento.Year);

            Console.WriteLine("Turma A - Alunos com mesmo ano de nascimento da Turma B\n");
            foreach (var aluno in alunosTurmaAComMesmoAnoNascimento)
            {
                Console.WriteLine($"{aluno.Nome}");
            }


            //UNION

            var resultadoUnion = fonte1.Union(fonte2).ToList();
            foreach (var i in resultadoUnion)
            {
                Console.WriteLine($"{i} ");
            }

            var paisesUnion = paises1.Union(paises2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var i in paisesUnion)
            {
                Console.WriteLine($"{i} ");
            }

            //UNIONBY

            /// <summary>
            /// Dessa maneira é retornado apenas uma Lista de String
            /// </summary>
            var consultaUnion = turmaA.Select(p => p.Nome).Union(turmaB.Select(p => p.Nome));

            /// <summary>
            /// Dessa maneira é retornado uma Lista do tipo de Aluno
            /// </summary>
            var turmasUnionBy = turmaA.UnionBy(turmaB, p => p.Nome);

            Console.WriteLine("Alunos nomes distintos\n");
            foreach (var aluno in turmasUnionBy)
            {
                Console.WriteLine($"{aluno.Nome} {aluno.Nascimento.Year} {aluno.Idade}");
            }

            Console.ReadKey();
        }
    }
}
