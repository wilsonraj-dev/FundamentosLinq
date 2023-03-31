namespace FundamentosLinq.Fundamentos_6
{
    internal class OperadoresDeOrdenacao
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>() { "Paulo", "Tarcisio", "Amaral", "Pedro", "Débora",
                                                      "Helena", "Percival", "Manoel", "Rute", "José" };

            //Ordem crescente
            var lista = nomes.OrderBy(x => x).ToList();
            foreach (var n in lista)
            {
                Console.WriteLine($"{n} ");
            }

            //Ordem decrescente
            lista = nomes.OrderByDescending(x => x).ToList();
            foreach (var n in lista)
            {
                Console.WriteLine($"{n} ");
            }

            var alunos = FonteDados.GetAlunos();

            var lista1 = alunos.OrderBy(x => x.Nome);
            foreach (var l1 in lista1)
                Console.WriteLine($"{l1.Nome} {l1.Idade}");


            var lista2 = alunos.Where(x => x.Nome.Contains('r')).OrderBy(x => x.Nome);
            foreach (var l2 in lista2)
                Console.WriteLine($"{l2.Nome} {l2.Idade}");


            var lista3 = alunos.Where(x => x.Nome.Contains('r'))
                                        .OrderBy(x => x.Nome).ThenBy(x => x.Idade);
            foreach (var l3 in lista3)
                Console.WriteLine($"{l3.Nome} {l3.Idade}");


            var lista4 = alunos.Where(x => x.Nome.Contains('r'))
                                        .OrderByDescending(x => x.Nome).ThenByDescending(x => x.Idade);
            foreach (var l4 in lista4)
                Console.WriteLine($"{l4.Nome} {l4.Idade}");

            /// <summary>
            /// O método Reverse() do namespace System.Linq deve ser convertido para um
            /// IEnumerable ou IQueryable para que seja possível usá-lo.Após isso é só
            /// percorrer a lista obtida por um foreach e teremos o resultado
            /// </summary>
            IEnumerable<string> lista5 = nomes.AsEnumerable().Reverse();
            foreach (var l5 in lista5)
                Console.WriteLine($"{l5} ");

            IQueryable<string> lista6 = nomes.AsQueryable().Reverse();
            foreach (var l6 in lista6)
                Console.WriteLine($"{l6} ");

            Console.ReadKey();
        }
    }
}
