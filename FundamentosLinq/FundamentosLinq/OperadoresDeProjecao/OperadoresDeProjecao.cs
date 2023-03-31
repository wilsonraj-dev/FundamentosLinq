namespace FundamentosLinq.Fundamentos_3
{
    class OperadoresDeProjecao
    {
        static void Main(string[] args)
        {
            //Select
            //QUERY SYNTAX
            IEnumerable<Aluno> alunos = FonteDados.GetAlunos().ToList();

            Console.WriteLine("Alunos Nomes e Notas");
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"{aluno.Nome} : {aluno.Nota}");
            }

            //Da maneira que está abaixo deixo explicito que quero retornar apenas uma propriedade
            IEnumerable<string> nomes = FonteDados.GetAlunos().Select(n => n.Nome);

            Console.WriteLine("\nAlunos Nomes");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }


            //Selecionando um novo formato do mesmo tipo obtendo apenas o Nome e a Idade
            List<Aluno> lista = FonteDados.GetAlunos().Select(a => new Aluno()
            {
                Nome = a.Nome,
                Idade = a.Idade
            }).ToList();

            Console.WriteLine("\nLista Alunos");
            foreach (var listaAlunos in lista)
            {
                Console.WriteLine($"{listaAlunos.Nome} : {listaAlunos.Idade}");
            }


            //Criando uma projeção para um tipo anônimo
            var alunosTipoAnonimo = FonteDados.GetAlunos().Select(a => new
            {
                NomeAluno = a.Nome,
                IdadeAluno = a.Idade,
                NotaAluno = a.Nota
            }).ToList();

            Console.WriteLine("\nLista Anônima");
            foreach (var aluno in alunosTipoAnonimo)
            {
                Console.WriteLine($"{aluno.NomeAluno} : {aluno.IdadeAluno}");
            }


            //Realizando cálculos com o operador Select
            var funcionariosTipoAnonimo = FonteDados.GetFuncionarios().Select(f => new
            {
                NomeFuncionario = f.Nome,
                IdadeFuncionario = f.Idade,
                SalarioAnual = f.Salario * 12
            }).ToList();

            Console.WriteLine("\nLista Anônima Funcionários");
            foreach (var funcionarios in funcionariosTipoAnonimo)
            {
                Console.WriteLine($"{funcionarios.NomeFuncionario} : {funcionarios.IdadeFuncionario} : {funcionarios.SalarioAnual.ToString("c")}");
            }

            //SelectMany
            List<List<int>> listas = new List<List<int>>
            {
                new List<int> { 1, 2, 3 },
                new List<int> { 12 },
                new List<int> { 5, 6, 5, 7 },
                new List<int> { 10, 12, 12, 13 }
            };

            IEnumerable<int> resultado = listas.SelectMany(lista => lista);
            foreach (var i in resultado)
            {
                Console.Write($"{i} ");
            }

            //Retorna resultado sem os valores repetidos
            IEnumerable<int> resultadoDistinct = listas.SelectMany(lista => lista.Distinct());
            foreach (var i in resultadoDistinct)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");
            //Comparando o Select com SelectMany
            Console.WriteLine("↓ Comparando Select com SelectMany ↓\n");

            Console.WriteLine("Usando Select");
            IEnumerable<List<string>> retornoSelect = FonteDados.GetAlunos().Select(c => c.Cursos);

            foreach (List<string> listaCursos in retornoSelect)
            {
                foreach (string curso in listaCursos)
                {
                    Console.Write($"{curso} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nUsando SelectMany");
            IEnumerable<string> retornoSelectMany = FonteDados.GetAlunos().SelectMany(c => c.Cursos);

            foreach (string curso in retornoSelectMany)
            {
                Console.WriteLine($"{curso} ");
            }

            Console.ReadKey();
        }
    }
}
