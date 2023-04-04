namespace FundamentosLinq.OperadoresDeGeracao
{
    internal class OperadoresDeGeracao
    {
        static void Main(string[] args)
        {
            #region Range
            ///<summary>
            ///O método Range() gera uma sequência de números inteiros dentro de um
            ///intervalo especificado
            /// </summary>

            var numeros = Enumerable.Range(1, 10);
            foreach (var num in numeros)
            {
                Console.Write($"{num} ");
            }

            var numerosPares = Enumerable.Range(1, 30).Where(x => x % 2 == 0);
            foreach (var num in numerosPares)
            {
                Console.Write($"{num} ");
            }

            IEnumerable<int> quadrados = Enumerable.Range(1, 10).Select(x => x * x);
            foreach (var num in quadrados)
            {
                Console.Write($"{num} ");
            }
            #endregion

            #region Repeat<T>
            ///<summary>
            ///O método Repeat<T> gera uma sequência ou coleção com um número
            ///especificado de elementos e cada elemento contém o mesmo valor
            /// </summary>

            IEnumerable<string> valores = Enumerable.Repeat("Thundercats", 10);
            foreach (var txt in valores)
            {
                Console.Write($"{txt} ");
            }

            IEnumerable<int> numerosRepeat = Enumerable.Repeat(2023, 10);
            foreach (var num in numerosRepeat)
            {
                Console.Write($"{num} ");
            }
            #endregion

            #region Empty<T>
            ///<summary>
            ///O método Empty<T> é usado para retornar uma coleção vazia (ou seja, IEnumerable<T>)
            ///de um tipo especificado.
            ///O método Empty<T> armazena em um cache uma sequência vazia do tipo T, quando o
            ///objeto que ele retorna é enumerado, ele não produz nenhum elemento.
            /// </summary>

            var vazio = Enumerable.Empty<string>();
            foreach (var num in vazio)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Concluído");

            var colecaoVazia1 = Enumerable.Empty<string>();
            var colecaoVazia2 = Enumerable.Empty<Aluno>();

            Console.WriteLine("\nColeção de strings\n");
            Console.WriteLine("Count: {0} ", colecaoVazia1.Count());
            Console.WriteLine("Tipo: {0} ", colecaoVazia1.GetType().Name);

            Console.WriteLine("\nColeção de objetos Aluno\n");
            Console.WriteLine("Count: {0} ", colecaoVazia2.Count());
            Console.WriteLine("Tipo: {0} ", colecaoVazia2.GetType().Name);

            //Exemplo prático mostrando onde o método Empty<T> pode ser usado
            IEnumerable<int> resultado = GetData() ?? Enumerable.Empty<int>();

            foreach (var num in resultado)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Concluído");

            static IEnumerable<int> GetData()
            {
                return null;
            }
            #endregion
        }

        public class Aluno
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }
    }
}
