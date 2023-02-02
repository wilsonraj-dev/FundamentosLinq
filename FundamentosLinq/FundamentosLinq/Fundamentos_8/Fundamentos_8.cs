namespace FundamentosLinq.Fundamentos_8
{
    internal class Fundamentos_8
    {
        static void Main(string[] args)
        {
            //Método Count
            string[] cursos = { "C#", "Java", "Python", "PHP", "Go", "Node" };
            var resultado1 = cursos.Count();
            Console.WriteLine(resultado1);

            // Count com filtro
            var resultado2 = cursos.Count(c => c.Contains('P'));
            Console.WriteLine(resultado2);

            var resultado3 = cursos.Where(c => c.Contains('P')).Count();
            Console.WriteLine(resultado3);

            ///<summary>
            /// Vale ressaltar o método LongCount() que tem a mesma função do método Count(),
            /// porém para valores muito grandes. Deve ser usado quando o valor máximo dos inteiros
            /// ultrapassa a quantidade suportada pelo Count(). Essa quantidade é 2.147.483.647
            /// </summary>

            // Método SUM
            int[] numeros = { 3, 5, 7, 9, 10, 12, 15, 20, 30, 39 };
            int soma = numeros.Sum();
            Console.WriteLine(soma);

            // Sum com filtros
            var soma1 = numeros.Where(n => n > 10).Sum();
            Console.WriteLine(soma1);

            /// <summary>
            /// Essa á uma sobrecarga do método Sum() que usa um predicate, e neste predicate
            /// é definida lógica que será usada para filtrar os dados.
            /// </summary>
            var soma2 = numeros.Sum(n =>
            {
                if (n > 10)
                    return n;
                else
                    return 0;
            });
            Console.WriteLine(soma2);

            //Métodos Max e Min
            var funcionarios = FonteDados.GetFuncionarios();
            var maxIdade = funcionarios.Max(f => f.Idade);
            var maxSalario = funcionarios.Max(f => f.Salario);
            var valorMaximo30 = funcionarios.Max(f =>
            {
                if (f.Idade > 30)
                    return f.Salario;
                return 0;
            });

            Console.WriteLine(maxIdade);
            Console.WriteLine(maxSalario);
            Console.WriteLine(valorMaximo30);

            var minIdade = funcionarios.Min(f => f.Idade);
            var minSalario = funcionarios.Min(f => f.Salario);
            var menor20 = funcionarios.Where(f => f.Idade < 20).Min(f => f.Salario);
            Console.WriteLine(minIdade);
            Console.WriteLine(minSalario);
            Console.WriteLine(menor20);

            Console.ReadKey();
        }
    }
}
