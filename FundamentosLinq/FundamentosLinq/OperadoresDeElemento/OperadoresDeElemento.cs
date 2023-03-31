namespace FundamentosLinq.Fundamentos_12
{
    internal class OperadoresDeElemento
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

            #region Last
            ///<summary>
            ///O método Last() é usado para retornar o primeiro elemento de uma fonte de dados.
            ///Se a fonte de dados estiver vazia é retornada uma exceção do tipo InvalidOperationException
            /// </summary>

            int resultadoLast = numeros.Last();
            Console.WriteLine(resultadoLast);

            resultadoLast = numeros.Last(num => num < 50);
            Console.WriteLine(resultadoLast);

            //Sintaxe de consulta
            int lastSintaxeConsulta = (from num in numeros
                                       select num).Last();

            lastSintaxeConsulta = (from num in numeros
                                   select num).Last(num => num > 50);
            #endregion

            #region LastOrDefault
            ///<summary>
            ///Faz a mesma coisa que o método Last(), porém não retorna uma exceção. É retornado um 
            ///valor padrão com base no tipo de dados do elemento
            /// </summary>

            int resultadoLastOrDefault = numeros.LastOrDefault();
            Console.WriteLine(resultadoLastOrDefault);

            resultadoLastOrDefault = numeros.LastOrDefault(num => num < 50);
            Console.WriteLine(resultadoLastOrDefault);

            //Sintaxe de consulta
            lastSintaxeConsulta = (from num in numeros
                                   select num).LastOrDefault();

            lastSintaxeConsulta = (from num in numeros
                                   select num).LastOrDefault(num => num > 50);
            #endregion

            #region Single
            ///<summary>
            ///O método Singles() retorna um único e especifico elemento da coleção
            /// </summary>

            List<int> numerosSingle = new List<int> { 10 };
            int resultadoSingle = numerosSingle.Single();
            Console.WriteLine(resultadoSingle); //10

            List<int> numerosSingle2 = new List<int> { 10, 20, 30 };
            resultadoSingle = numerosSingle2.Single(n => n > 20);
            Console.WriteLine(resultadoSingle); //30

            resultadoSingle = numerosSingle2.Single(n => n > 10); //InvalidOperationException
                                                                  //Mais de um elemento atende a condição

            //Sintaxe de consulta
            int sintaxeConsultaSingle = (from num in numerosSingle2
                                         select num).Single();

            sintaxeConsultaSingle = (from num in numerosSingle2
                                     select num).Single(n => n > 20);
            #endregion

            #region SingleOrDefault
            ///<summary>
            ///Faz a mesma coisa que o método Singles(), porém não retorna uma exceção quando a coleção
            ///estiver vazia ou quando nenhum elemento na coleção satisfazer a condição fornecida.
            ///Porém continuará lançando uma exceção se a coleção tiver mais de um elemento ou se mais de 
            ///um elemento atender a coleção.
            /// </summary>

            int resultadoSingleOrDefault = numerosSingle.SingleOrDefault();
            Console.WriteLine(resultadoSingleOrDefault); //10

            resultadoSingleOrDefault = numerosSingle2.SingleOrDefault(n => n > 20);
            Console.WriteLine(resultadoSingleOrDefault); //20

            resultadoSingleOrDefault = numerosSingle2.SingleOrDefault(n => n > 50); //Retorna valor padrão => 0
                                                                                    //Nenhum elemento atende a condição

            //Sintaxe de consulta
            sintaxeConsultaSingle = (from num in numeros
                                     select num).SingleOrDefault();

            sintaxeConsultaSingle = (from num in numeros
                                     select num).SingleOrDefault(n => n > 20);
            #endregion

            #region DefaultIfEmpty
            ///<summary>
            ///O método DefaultIfEmpty() retorna os elementos de uma coleção especificada ou o valor
            ///padrão do parâmetro de tipo em uma coleção de singletons se a coleção estiver vazia.
            /// </summary>

            List<int> numerosDefaultIfEmpty = new List<int> { 10, 20, 30 };
            IEnumerable<int> resultadoDefaultIfEmpty = numerosDefaultIfEmpty.DefaultIfEmpty();

            foreach (var num in resultadoDefaultIfEmpty)
            {
                Console.WriteLine(num); //10, 20, 30
            }

            List<int> numerosDefaultIfEmptyVazia = new List<int> { };
            resultadoDefaultIfEmpty = numerosDefaultIfEmptyVazia.DefaultIfEmpty();
            foreach (var num in resultadoDefaultIfEmpty)
            {
                Console.WriteLine(num); //0
            }

            IEnumerable<int> resultadoDefaultIfEmptyValorPadrao = numerosDefaultIfEmptyVazia.DefaultIfEmpty(5);
            foreach (var num in resultadoDefaultIfEmptyValorPadrao)
            {
                Console.WriteLine(num); //5
            }

            //Exemplo prático usando o método DefaultIfEmpty()
            var filmes = new List<Filme>
            {
                new Filme("Titanic", 7),
                new Filme("De volta para o futuro", 8),
                new Filme("Mulher maravilha", 6),
            };

            var filmeFavorito = new Filme("Guardiões da galáxia", 10);

            var filmeAAssistir = filmes.Where(x => x.Avaliacao >= 9)
                                       .DefaultIfEmpty(filmeFavorito)
                                       .First();

            Console.WriteLine($"{filmeAAssistir.Titulo} - {filmeAAssistir.Avaliacao}");
            #endregion
        }
    }
}
