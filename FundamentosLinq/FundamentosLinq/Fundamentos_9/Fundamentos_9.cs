namespace FundamentosLinq.Fundamentos_9
{
    internal class Fundamentos_9
    {
        static void Main(string[] args)
        {
            #region All
            int[] numeros = { 10, 22, 32, 44, 56, 64, 78 };
            var resultado = numeros.All(x => x % 2 == 0);
            Console.WriteLine($"{(resultado ? "Todos são pares" : "Nem todos são pares")}");

            //Sintaxe de consulta para o operador All()
            resultado = (from n in numeros
                         select n).All(x => x % 2 == 0);
            Console.WriteLine($"{(resultado ? "Todos são pares" : "Nem todos são pares")}");


            var funcionarios = FonteDados.GetFuncionarios();

            var todosSalarioAcima2500 = funcionarios.All(x => x.Salario > 2500.00m);
            var todosMaiorQue21 = funcionarios.All(x => x.Idade > 21);
            var todosNomesContemLetraA = funcionarios.All(x => x.Nome.Contains('a'));
            Console.WriteLine($"{todosSalarioAcima2500} {todosMaiorQue21} {todosNomesContemLetraA}");

            todosSalarioAcima2500 = (from n in funcionarios
                                     select n).All(x => x.Salario > 2500.00m);
            Console.WriteLine($"{(resultado ? "Todos os salários são maiores que 2500" : "Nem todos salários são maiores que 2500")}");

            var pessoas = FonteDados.GetPessoas();
            var nomes = (from p in pessoas
                         where p.Cachorros.All(pet => pet.Idade > 5)
                         select p.Nome);
            foreach (var n in nomes)
            {
                Console.WriteLine($"{n} ");
            }
            #endregion

            #region Any
            string[] cursos = { "C#", "Java", "Python", "PHP", "Go", "Node" };

            var existemCursos = cursos.Any();
            var existemCursosMaiorQue2 = cursos.Any(c => c.Length > 2);
            Console.WriteLine($"{existemCursos} - {existemCursosMaiorQue2}");

            //Sintaxe de consulta
            var resultadoCurso = (from c in cursos
                                  select c).Any(c => c.Contains('P'));
            Console.WriteLine(resultadoCurso);

            var cachorro = FonteDados.GetCachorros();
            bool naoVacinados = cachorro.Any(c => c.Idade > 2 && c.Vacinado == false);
            Console.WriteLine($"{(naoVacinados ? "Existem" : "Não existem")} cães com mais de 2 anos não vacinados.");

            //Sintaxe de consulta
            var resultadoCachorros = (from c in cachorro
                                      select c).Any(c => c.Idade > 2 && c.Vacinado == false);
            Console.WriteLine($"{(resultadoCachorros ? "Existem" : "Não existem")} cães com mais de 2 anos não vacinados.");
            #endregion

            #region Contains
            var alunos = FonteDados.GetAlunos();

            var aluno1 = new Aluno() { Nome = "Maria", Pontos = 275 };

            /// <summary>
            /// Nesses dois exemplos é retornado um resultado "false", pois a primeira
            /// sobrecarga do método Contains() compara apenas a referência e não os valores passados.
            /// Para isso temos que usar um IEqualityComparer
            /// </summary>
            var resultadoAluno1 = alunos.Contains(aluno1);

            //Sintaxe de consulta
            var resultaAluno1SintaxeConsulta = (from a in alunos
                                                select a).Contains(aluno1);
            Console.WriteLine($"{resultadoAluno1} - {resultaAluno1SintaxeConsulta}");

            //Usando o método Contains() com sua segunda sobrecarga
            AlunoComparer alunoComparer = new AlunoComparer();
            var compararAluno = alunos.Contains(aluno1, alunoComparer);

            resultaAluno1SintaxeConsulta = (from a in alunos
                                            select a).Contains(aluno1, alunoComparer);
            Console.WriteLine($"{alunoComparer} - {resultaAluno1SintaxeConsulta}");
            #endregion

            Console.ReadKey();
        }
    }
}
