namespace FundamentosLinq.Fundamentos_12
{
    internal class Fundamentos_12
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            #region ElementAt
            int resultado = numeros.ElementAt(5);
            Console.WriteLine(resultado);

            //Retornando o objeto o aluno usando ElementAt()
            var aluno = FonteDados.GetAlunos().ElementAt(5);
            Console.WriteLine($"{aluno.Id} - {aluno.Nome} - {aluno.CursoId}");

            //Retornando somente a propriedade Nome
            var nome = FonteDados.GetAlunos().Select(a => a.Nome).ElementAt(5);
            Console.WriteLine(nome);

            //Sintaxe de consulta
            int sintaxeConsulta = (from num in numeros
                                   select num).ElementAt(7);
            #endregion

            #region ElementAtOrDefault
            ///<summary>
            ///A diferença desse método pro método ElementAt() é que se a fonte de dados estiver vazia
            ///ele não lañça uma exceção. Ao invés disso é retornado o valor padrão com base no tipo
            ///de dados do elemento que a fonte de dados contém. Por exemplo, se for tipo int retorna 0,
            ///se for tipo referência retorna null.
            /// </summary>

            int resultadoDefault = numeros.ElementAtOrDefault(12);
            Console.WriteLine(resultadoDefault);

            //Sintaxe de consulta
            sintaxeConsulta = (from num in numeros
                               select num).ElementAtOrDefault(2);
            #endregion

            #region First
            ///<summary>
            ///O método First() é usado para retornar o primeiro elemento de uma fonte de dados.
            ///Se a fonte de dados estiver vazia é retornada uma exceção do tipo InvalidOperationException
            /// </summary>

            int resultado1 = numeros.First();
            int resultado2 = numeros.First(n => n > 20);

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);

            //InvalidOperationException
            int resultado3 = numeros.First(n => n > 110);
            Console.WriteLine(resultado3);

            //Tipo complexo
            var alunoFirst = FonteDados.GetAlunos().First(a => a.CursoId == 30);
            Console.WriteLine($"{alunoFirst.Id} - {alunoFirst.Nome} - {alunoFirst.CursoId}");

            //Sintaxe de consulta
            int firstConsulta = (from num in numeros
                                 select num).First();
            #endregion

            #region FirstOrDefault
            ///<summary>
            ///Faz a mesma coisa que o método First(), exceto que esse método não lança uma exceção de
            ///operação inválida, em vez disso, é retornado o valor padrão com base no tipo de dados
            ///do elemento. 
            /// </summary>

            int resultado4 = numeros.FirstOrDefault();
            int resultado5 = numeros.FirstOrDefault(n => n > 40);

            Console.WriteLine(resultado4);
            Console.WriteLine(resultado5);

            //Retorna zero
            int resultado6 = numeros.FirstOrDefault(n => n > 110);
            Console.WriteLine(resultado6);

            //Sintaxe de consulta
            sintaxeConsulta = (from num in numeros
                               select num).FirstOrDefault();

            Console.WriteLine(sintaxeConsulta);
            #endregion
        }
    }
}
