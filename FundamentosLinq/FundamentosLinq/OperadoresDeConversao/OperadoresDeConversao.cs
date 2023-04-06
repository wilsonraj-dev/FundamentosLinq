using System.Collections;
using System.Linq.Expressions;

namespace FundamentosLinq.OperadoresDeConversao
{
    internal class OperadoresDeConversao
    {
        static void Main(string[] args)
        {
            #region ToList
            ///<summary>
            ///O método ToList() cria um List<T> a partir de IEnumberable<T>
            /// </summary>

            string[] paises = { "US", "UK", "India", "Rússia", "China", "Brasil", "Japão" };
            var resultado = paises.ToList();

            foreach (string pais in resultado)
            {
                Console.WriteLine(pais);
            }

            var alunos = FonteDados.GetAlunos();
            var listaAlunos = alunos.Where(x => x.Nome.Contains('M')).ToList();

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine(aluno.Nome);
            }
            #endregion

            #region ToArray
            ///<summary>
            ///O método ToArray() cria um array a partir de um IEnumerable<T>
            /// </summary>

            var alunosArray = FonteDados.GetAlunos();
            var listaAlunosArray = alunos.Where(x => x.Nome.Contains('a')).ToArray();

            foreach (var item in listaAlunosArray)
            {
                Console.WriteLine(item);
            }

            var empresas = FonteDados.GetPacotes();
            var listaEmpresa = empresas.Select(pct => pct.Empresa).ToArray();
            foreach (var empresa in listaEmpresa)
            {
                Console.WriteLine(empresa);
            }
            #endregion

            #region ToDictionary
            ///<summary>
            ///O método ToDictionary() cria um ToDictionary<TKey, TValue> de um IEnumerable<T>
            /// </summary>

            var alunosDic = FonteDados.GetAlunos();
            var listAlunosDic = alunosDic.ToDictionary<Aluno, int>(a => a.Id);

            foreach (var chave in listAlunosDic.Keys)
            {
                Console.WriteLine($"Chave: {chave}, Valor: {(listAlunosDic[chave] as Aluno).Nome}");
            }
            #endregion

            #region ToLookUp
            ///<summary>
            ///O método ToLookUp() cria um LookUp<TKey, TValue> genérico de um IEnumerable<T>
            /// </summary>

            var funcionarios = FonteDados.GetFuncionarios();

            //Agrupar por cargo
            var funcionarioPorCargo = funcionarios.ToLookup(x => x.Cargo);

            Console.WriteLine("Funcionários agrupados por Cargo..");
            foreach (var kvp in funcionarioPorCargo)
            {
                Console.WriteLine(kvp.Key);
                foreach (var item in funcionarioPorCargo[kvp.Key])
                {
                    Console.WriteLine("\t" + item.Nome + "\t" + item.Cidade);
                }
            }
            #endregion

            #region AsEnumerable
            ///<summary>
            ///O método AsEnumerable() é usado para converter o tipo específico
            ///de uma determinada lista em seu tipo equivalente IEnumerable()
            /// </summary>

            int[] numeros = new int[] { 1, 2, 3, 4, 5 };
            var resultadoEnumerable = numeros.AsEnumerable();

            foreach (var item in resultadoEnumerable)
            {
                Console.WriteLine($"{item} ");
            }

            var paisesEnumerable = new List<string> { "US", "India", "UK", "Australia", "Canada" };
            var resultadoPaisesEnumerable = paisesEnumerable.AsEnumerable();

            foreach (var item in resultadoPaisesEnumerable)
            {
                Console.WriteLine($"{item} ");
            }


            #endregion

            #region AsQueryable
            ///<summary>
            ///O método AsQueryable() irá converter um IEnumerable em um IQueryable
            /// </summary>

            List<int> numerosQueryable = new List<int> { 78, 92, 100, 37, 81 };
            var resultadoQueryable = numerosQueryable.AsQueryable();

            Expression expressionTree = resultadoQueryable.Expression;

            Console.WriteLine("O NodeType da árvore de expressão é: " + expressionTree.NodeType.ToString());
            Console.WriteLine("O tipo da árvore de expressão é: " + expressionTree.Type.Name.ToString());

            foreach (var item in resultadoQueryable)
            {
                Console.WriteLine(numerosQueryable);
            }

            int soma = Queryable.Sum(resultadoQueryable);
            int conta = Queryable.Count(resultadoQueryable);
            double media = Queryable.Average(resultadoQueryable);
            int maximo = Queryable.Max(resultadoQueryable);
            int minimo = Queryable.Min(resultadoQueryable);

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Quantidade: {conta}");
            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Máximo: {maximo}");
            Console.WriteLine($"Mínimo: {minimo}");
            #endregion

            #region Cast
            ///<summary>
            ///O método Cast() tenta converter todos os itens de uma coleção
            ///em outro tipo e retorná-los em uma nova coleção que contém
            ///os elementos convertidos para o tipo especificado
            /// </summary>

            ArrayList lista = new ArrayList() { 10, 20, 30 };
            var resultadoCast = lista.Cast<int>();

            //lista.Add("40"); => Lança um InvalidCastException

            foreach (var item in resultadoCast)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region OfType
            ///<summary>
            ///O método OfType() é usado para filtrar dados de um tipo específico
            ///de uma fonte de dados com base no tipo de dados que passamos
            ///para esse operador
            /// </summary>

            List<object> dados = new List<object>()
            {
                "Tania", "Maria", 50, "Manoeal", 10, 20, 30, 40, "Tiago"
            };

            var dadosInt = dados.OfType<int>().ToList();
            foreach (var item in dadosInt)
            {
                Console.Write($"{item} ");
            }

            var dadosString = dados.OfType<string>().ToList();
            foreach (var item in dadosString)
            {
                Console.Write($"{item} ");
            }

            var dadosItnSoma = dados.OfType<int>().Where(n => n > 30).ToList();
            foreach (var item in dadosItnSoma)
            {
                Console.Write($"{item} ");
            }

            //Sintaxe de consulta
            var dadosStringSintaxeConsulta = (from nome in dados
                                              where nome is string
                                              select nome).ToList();
            #endregion
        }
    }
}
