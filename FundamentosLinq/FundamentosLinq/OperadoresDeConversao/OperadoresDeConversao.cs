using System.Threading.Tasks.Dataflow;

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
        }
    }
}
