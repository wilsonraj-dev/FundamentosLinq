namespace FundamentosLinq.Fundamentos_10
{
    internal class Fundamentos_10
    {
        static void Main(string[] args)
        {
            var alunos = FonteDados.GetAlunos();

            #region GroupBy
            //Sintaxe de método
            var grupos = alunos.GroupBy(a => a.Idade).OrderBy(c => c.Key);

            //Sintaxe de consulta
            var grupos2 = from a in alunos
                          group a by a.Idade into grupo
                          orderby grupo.Key
                          select grupo;

            //Itera cada grupo
            foreach (var grupo in grupos)
            {
                Console.WriteLine($"\nIdade: {grupo.Key} alunos: {grupo.Count()}");

                //Itera através de cada aluno do grupo
                foreach (var g in grupo)
                {
                    Console.WriteLine($"\t{g.Nome} {g.Curso} {g.Sexo}");
                }
            }

            ///<summary>
            /// Ordernando por curso e ordenando cada aluno de determinado curso por nome
            ///</summary>
            var grupos3 = alunos.GroupBy(s => s.Curso)
                     //Primeiro ordena os dados baseado na chave: curso
                     .OrderBy(c => c.Key)
                     .Select(std => new
                     {
                         Key = std.Key,
                         //Ordena os dados baseado no nome
                         Aluno = std.OrderBy(x => x.Nome)
                     });

            ///<summary>
            /// Agrupamento utilizando múltiplas chaves com GroupBy
            /// </summary>
            var gruposMultiplos = alunos.GroupBy(x => new { x.Curso, x.Sexo })
                                                  .OrderByDescending(g => g.Key.Curso)
                                                  .ThenBy(g => g.Key.Sexo)
                                                  .Select(g => new
                                                  {
                                                      Curso = g.Key.Curso,
                                                      Sexo = g.Key.Sexo,
                                                      Alunos = g.OrderBy(x => x.Nome)
                                                  });

            foreach (var grupo in gruposMultiplos)
            {
                Console.WriteLine($"\n{grupo.Curso} {grupo.Sexo} (alunos: {grupo.Alunos.Count()})");

                //Itera através de cada grupo de alunos 
                foreach (var aluno in grupo.Alunos)
                {
                    Console.WriteLine($"\t{aluno.Nome} {aluno.Idade} {aluno.Sexo}");
                }
            }
            #endregion

            #region ToLookUp
            ///<summary>
            /// A grande diferença do GroupBy para o ToLookUp é que o método ToLookUp trabalha com
            /// uma execução imediata, enquanto o método GroupBy obtém o resultado durante a iteração.
            /// Quase todos os exemplos usados para GroupBy também podem ser replicados para ToLookUp
            /// </summary>

            //Sintaxe de método
            var gruposToLookUp = alunos.ToLookup(a => a.Curso);

            //Sintaxe de consulta
            var gruposToLookUpSintaxeConsulta = (from a in alunos
                                                 select a).ToLookup(c => c.Curso);

            foreach (var g in gruposToLookUpSintaxeConsulta)
            {
                Console.WriteLine($"\n {g.Key} ({g.Count()})");
                foreach (var aluno in g)
                {
                    Console.WriteLine($"\t {aluno.Nome} {aluno.Idade} {aluno.Sexo}");
                }
            }
            #endregion
        }
    }
}
