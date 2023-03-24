namespace FundamentosLinq.Fundamentos_13
{
    internal class Fundamentos_13
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numerosNaoOrdenados = new List<int>() { 1, 3, 7, 10, 5, 8, 6, 9, 4, 2 };
            List<string> nomes = new List<string>() { "Sara", "Raul", "José", "Ana", "Pedro" };

            #region Take
            ///<summary>
            ///Retorna os primeiros "n" elementos da fonte de dados onde "n" é um número inteiro que é
            ///passado como parâmetros para o método Take()
            /// </summary>

            List<int> resultado = numeros.Take(4).ToList();
            foreach (var num in resultado)
            {
                Console.Write($"{num} "); //1, 2, 3, 4
            }

            List<int> resultadoOrdenandoDescendendo = numeros.OrderByDescending(n => n).Take(5).ToList();
            foreach (var num in resultadoOrdenandoDescendendo)
            {
                Console.Write($"{num} "); //10, 9, 8, 7, 6
            }

            List<int> resultadoOrdenado = numerosNaoOrdenados.OrderBy(n => n).Where(n => n > 5).Take(4).ToList();
            foreach (var num in resultadoOrdenado)
            {
                Console.Write($"{num} "); //6, 7, 8, 9
            }

            //Sintaxe de consulta
            List<int> sintaxeConsulta = (from num in numeros
                                         select num).Take(4).ToList();
            #endregion

            #region TakeWhile
            ///<summary>
            ///Retorna elementos de uma sequência desde que uma condição especificada seja verdadeira
            ///e, em seguida, ignora os elementos restantes. Depois que a condição falhar, o método
            ///TakeWhile() não vefica o restante dos elementos presentes na fonte de dados, mesmo que
            ///a condição seja verdadeira para os elementos restante.
            /// </summary>

            resultado = numeros.TakeWhile(num => num < 6).ToList();
            foreach (var num in resultado)
            {
                Console.Write($"{num} "); //1, 2, 3, 4, 5
            }

            //Comparando o método TakeWhile() com o método Where()
            List<int> comparaTakeWhileEWhere = new List<int>() { 1, 2, 3, 6, 7, 8, 9, 10, 4, 5 };

            List<int> resultado1 = comparaTakeWhileEWhere.TakeWhile(n => n < 6).ToList();
            foreach (var num in resultado1)
            {
                Console.Write($"{num} "); //1, 2, 3
            }

            List<int> resultado2 = comparaTakeWhileEWhere.Where(n => n < 6).ToList();
            foreach (var num in resultado2)
            {
                Console.Write($"{num} "); //1, 2, 3, 4, 5
            }

            //Segunda sobrecarga do método - usando o índice na lógica da condição

            List<string> resultadoNomes = nomes.TakeWhile((nome, index) => nome.Length > index).ToList();
            foreach (var nome in resultadoNomes)
            {
                Console.Write($"{nome} "); //Sara, Raul, José
            }

            #endregion

            #region Skip
            ///<summary>
            ///O método Skip() ignora um número 'n' especificado de elementos em uma sequência
            ///e retorna os elementos restantes.
            /// </summary>

            List<int> resultadoSkip = numeros.Skip(4).ToList();
            foreach (var num in resultadoSkip)
            {
                Console.Write($"{num} "); //5, 6, 7, 8, 9, 10
            }

            var resultadoSkip2 = numeros.Where(n => n > 3).Skip(4);
            foreach (var num in resultadoSkip2)
            {
                Console.Write($"{num} "); //8, 9, 10
            }

            //Sintaxe de consulta
            resultadoSkip = (from num in numeros
                             select num).Skip(4).Where(n => n < 7).ToList();
            #endregion

            #region SkipWhile
            ///<summary>
            ///Ignora os elementos em uma fonte de dados desde que uma condição especificada
            ///seja verdadeira e, em seguida, retorna os elementos restantes
            /// </summary>

            List<int> skipWhile = numeros.SkipWhile(n => n < 5).ToList();
            foreach (var num in skipWhile)
            {
                Console.Write($"{num} "); //5, 6, 7, 8, 9, 10
            }

            skipWhile = numerosNaoOrdenados.SkipWhile(n => n < 5).ToList();
            foreach (var num in skipWhile)
            {
                Console.Write($"{num} "); //7, 10, 5, 8, 6, 9, 4, 2
            }

            resultadoNomes = nomes.SkipWhile((nome, index) => nome.Length > index).ToList();
            foreach (var nome in resultadoNomes)
            {
                Console.Write($"{nome} "); //Ana, Pedro
            }
            #endregion
        }
    }
}
