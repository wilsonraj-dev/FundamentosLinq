namespace FundamentosLinq.Fundamentos_18
{
    internal class Fundamentos_18
    {
        static void Main(string[] args)
        {
            #region Append<T>
            ///<summary>
            ///O método Append<T> é usado para anexar um valor ao final da sequência sem modificar
            ///os elementos da sequência. Ele cria uma cópia da sequência com o novo elemento.
            /// </summary>

            List<int> numeros = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", numeros.Append(5)));

            List<string> frutas = new List<string> { "Uva", "Banana", "laranja" };
            var novasFrutas = frutas.Append("Abacaxi");
            Console.WriteLine(string.Join(", ", novasFrutas));
            #endregion

            #region Prepend<T>
            ///<summary>
            ///O método Prepend<T> é usado para anexar um valor ao início da sequência sem
            ///modificar os elementos da sequência. Ele cria uma cópia da sequência com
            ///o novo elemento.
            /// </summary>

            numeros = new List<int> { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(", ", numeros.Prepend(0)));

            frutas = new List<string> { "Uva", "Banana", "laranja" };
            novasFrutas = frutas.Prepend("Abacaxi");
            Console.WriteLine(string.Join(", ", novasFrutas));
            #endregion

            #region Zip
            ///<summary>
            ///O método Zip() é usado para aplicar uma função especificada aos elementos
            ///correspondentes de duas sequências e produzir uma sequência dos resultados.
            /// </summary>

            int[] numerosZip = { 10, 20, 30, 40, 50 };
            string[] palavras = { "Dez", "Vinte", "Trinta", "Quarenta" };

            var resultadoZip = numerosZip.Zip(palavras, (prim, seg) => prim + " - " + seg);
            foreach (var item in resultadoZip)
            {
                Console.WriteLine(item);
            }

            var seq1 = new[] { 1, 2, 3 };
            var seq2 = new[] { 10, 20, 30 };

            var resultadoZip2 = seq1.Zip(seq2, (m, n) => m * n);
            foreach (var item in resultadoZip2)
            {
                Console.WriteLine(item);
            }

            var estados = new[] { "São Paulo", "Rio de Janeiro", "Minas Gerais" };
            var siglas = new[] { "SP", "RJ", "MG" };

            resultadoZip = estados.Zip(siglas, (x, y) => estados + " - " + siglas);
            foreach (var item in resultadoZip)
            {
                Console.WriteLine(resultadoZip);
            }
            #endregion
        }
    }
}
