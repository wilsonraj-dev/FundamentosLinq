namespace FundamentosLinq.Fundamentos_4
{
    class Fundamentos_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("## LINQ - Operações com conjuntos ## \n");

            Console.WriteLine("Idades -> 30, 33, 35, 36, 40, 30, 33, 36, 30, 40");
            var idadesDistintas = FonteDados.GetIdades().Distinct().ToList();
            foreach (var idade in idadesDistintas)
            {
                Console.WriteLine($"{idade} ");
            }


            Console.WriteLine("Nomes -> Paulo, MARIA, paulo, Amanda, maria, amanda");
            var nomesDistintos = FonteDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var nome in nomesDistintos)
            {
                Console.WriteLine($"{nome} ");
            }


            var alunos = FonteDados.GetAlunos().ToList();
            var alunosIdadesDistintas = alunos.DistinctBy(a => a.Idade);
            foreach (var aluno in alunosIdadesDistintas)
            {
                Console.WriteLine($"Aluno - {aluno.Nome} tem {aluno.Idade} anos");
            }


            List<int> fonte1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> fonte2 = new List<int>() { 1, 3, 5, 8, 9, 10 };

            var resultado = fonte1.Except(fonte2).ToList();
            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            string[] paises1 = { "Brasil", "USA", "UK", "Argentina", "China" };
            string[] paises2 = { "Brasil", "uk", "Argentina", "França", "Japão" };

            var resultadoPaises = paises1.Except(paises2, StringComparer.OrdinalIgnoreCase).ToList();
            foreach (var pais in resultadoPaises)
            {
                Console.WriteLine(pais);
            }


            var alunosExceptBy = FonteDados.GetAlunos();
            var alunosReprovados = new List<string> { "Amanda", "Alicia", "Jaime" };
            var alunosAprovados = alunosExceptBy.ExceptBy(alunosReprovados, n => n.Nome);

            Console.WriteLine("Alunos Aprovados");
            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine($"{aluno.Nome}");
            }

            Console.ReadKey();
        }
    }
}
