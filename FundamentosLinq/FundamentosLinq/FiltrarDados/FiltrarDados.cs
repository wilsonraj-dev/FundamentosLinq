namespace FundamentosLinq.Fundamentos_2
{
    class FiltrarDados
    {
        static void Main(string[] args)
        {
            //números - 1, 2, 4, 8, 16, 32, 64, 128, 256, 512
            var numeros = FonteDados.GetNumeros();
            var listaNegra = FonteDados.GetListaNegra();

            var resultado1 = numeros.Where(n => n < 10);
            var resultado2 = numeros.Where(n => n > 1 && n != 4 && n < 20);

            var resultado3 = numeros.Where(n => !listaNegra.Contains(n));

            var resultado4 = numeros.Where(n => n > 1)
                                    .Where(n => n != 4)
                                    .Where(n => n > 20);

            Console.WriteLine(string.Join(" ", resultado1));
            Console.WriteLine(string.Join(" ", resultado2));
            Console.WriteLine(string.Join(" ", resultado3));
            Console.WriteLine(string.Join(" ", resultado4));

            //TRABALHANDO COM OBJETOS COMPLEXOS
            var alunos = FonteDados.GetAlunos();

            var resultado5 = alunos.Where(a => a.Nome.StartsWith('A')
                                            && a.Idade < 18);

            //USANDO A QUERY SYNTAX
            var filtro = from a in alunos
                         where a.Nome.StartsWith('A') && a.Idade < 18
                         select a;

            foreach (var aluno in resultado5)
            {
                Console.WriteLine(aluno.Nome + " : " + aluno.Idade);
            }

            Console.ReadKey();
        }
    }
}
