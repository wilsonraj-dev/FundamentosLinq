namespace FundamentosLinq.Fundamentos_11
{
    internal class OperadoresDeJuncao
    {
        static void Main(string[] args)
        {
            ///<summary>
            /// Nesse exemplo irei fazer apenas os exemplos de como ficariam os métodos usando o operador
            /// Join(), tanto na sintaxe de método quanto na sintaxe de consulta.
            /// Decidi optar por não criar um novo projeto, pois para o objetivo desse 
            /// repositório mostrar como funciona o método já irá ajudar bastante.
            /// </summary>

            #region Join

            #region innerJoin
            //Sintaxe de método
            //var innerJoin = contexto.Funcionarios           //Outer Data Source
            //     .Join(
            //            contexto.Setores,                   //Inner Data Source
            //            funcionario => funcionario.SetorId, //Inner Key Selector
            //            setor => setor.SetorId,             //Outer Key Selector
            //            (funcionario, setor) => new         //Projetando os dados como um tipo anônimo
            //            {
            //                NomeFuncionario = funcionario.FuncionarioNome,
            //                NomeSetor = setor.SetorNome,
            //                CargoFuncionario = funcionario.FuncionarioCargo
            //            }).ToList();

            ////Sintaxe de consulta
            //var innerJoin2 = (from f in contexto.Funcionarios  //Outer Data Source                   
            //                  join s in contexto.Setores       //Inner Data Source
            //                  on f.SetorId equals s.SetorId    //Condição para obter os resultados
            //                  select new                       //Projetando o resultado
            //                  {
            //                      NomeFuncionario = f.FuncionarioNome,
            //                      CargoFuncionario = f.FuncionarioCargo,
            //                      NomeSetor = s.SetorNome,
            //                  }).ToList();
            #endregion

            #region leftJoin
            //Sintaxe de consulta
            ///<summary>
            /// Usando o leftJoin é mais fácil usar a sinxta de consulta, pois podem
            /// ocorrer alguns erros usando a sintaxe de método, além de que pode 
            /// variar alguns casos a maneira como fazer
            /// </summary>
            //var leftJoin = (from f in contexto.Funcionarios
            //                       join s in contexto.Setores
            //                       on f.SetorId equals s.SetorId
            //                       into funciSetorGrupo
            //                       from setor in funciSetorGrupo.DefaultIfEmpty()
            //                       select new
            //                       {
            //                           NomeFuncionario = f.FuncionarioNome,
            //                           CargoFuncionario = f.FuncionarioCargo,
            //                           NomeSetor = setor.Nome
            //                       }).ToList();
            #endregion

            #region rightJoin
            ///<summary>
            ///A LINQ não suporta um Right Join, por isso para contornar essa situação é possível
            ///trocar as tabelas e fazer um Left Join. Assim teremos o comportamento esperado para
            ///um Right Join
            /// </summary>

            //var rightJoin = (from s in contexto.Setores
            //                 join f in contexto.Funcionarios
            //                 on s.SetorId equals f.SetorId
            //                 into SetorfunciGrupo
            //                 from funcionario in SetorfunciGrupo.DefaultIfEmpty()
            //                 select new
            //                 {
            //                     NomeFuncionario = funcionario.FuncionarioNome,
            //                     CargoFuncionario = funcionario.FuncionarioCargo,
            //                     NomeSetor = s.SetorNome
            //                 }).ToList();
            #endregion

            #region fullJoin
            ///<summary>
            ///FullJoin é a união lógica entre um left join e um right join. Podemos usar o método
            ///Union() para encontrar os elementos exclusivos entre duas sequências ou coleções
            /// </summary>

            //var leftJoin = (from f in contexto.Funcionarios
            //                       join s in contexto.Setores
            //                       on f.SetorId equals s.SetorId
            //                       into funciSetorGrupo
            //                       from setor in funciSetorGrupo.DefaultIfEmpty()
            //                       select new
            //                       {
            //                           NomeFuncionario = f.FuncionarioNome,
            //                           CargoFuncionario = f.FuncionarioCargo,
            //                           NomeSetor = setor.Nome
            //                       }).ToList();

            //var rightJoin = (from s in contexto.Setores
            //                 join f in contexto.Funcionarios
            //                 on s.SetorId equals f.SetorId
            //                 into SetorfunciGrupo
            //                 from funcionario in SetorfunciGrupo.DefaultIfEmpty()
            //                 select new
            //                 {
            //                     NomeFuncionario = funcionario.FuncionarioNome,
            //                     CargoFuncionario = funcionario.FuncionarioCargo,
            //                     NomeSetor = s.SetorNome
            //                 }).ToList();

            //var fullJoin = leftJoin.Union(rightJoin);
            #endregion

            #region crossJoin
            ///<summary>
            ///O crossJoin faz a junção de duas coleções para obter uma nova coleção onde
            ///cada par combinado está representado. Essa associção não requer nenhuma condição na junção,
            ///porém a LINQ não permite o uso da palavra-chave "join" sem nenhuma condição.
            ///É preciso duas cláusulas "from", uma para cada coleção, para poder fazer uma junção cruzada,
            ///e a seguir usar a cláusula "Select" para fazer uma projeção do resultado.
            /// </summary>

            //var crossJoin = from f in contexto.Funcionarios
            //                from s in contexto.Setores
            //                select new
            //                {
            //                    Nome = f.FuncionarioNome,
            //                    Cargo = f.FuncionarioCargo,
            //                    Setor = s.SetorNome
            //                };
            #endregion

            #region GroupJoin
            ///<summary>
            ///O operador GroupJoin executa a mesma tarefa que o operador Join, porém ele irá
            ///retornar um resultado em grupo com base na chave de grupo especificada. O GroupJoin
            ///une duas coleções com base na chave e agrupa o resultado pela chave correspondente.
            ///A seguir, retorna uma coleção de resultado e chave agrupados. O GroupJoin requer
            ///os mesmos parâmetros que o Join.
            /// </summary>

            //var groupJoin = contexto.Setores
            //                .GroupJoin(contexto.Funcionarios,
            //                 s => s.SetorId, f => f.SetorId,
            //                 (f, funcionariosGrupo) => new
            //                 {
            //                     Funcionarios = funcionariosGrupo,
            //                     NomeSetor = f.SetorNome
            //                 }).ToList();
            #endregion

            #endregion
        }
    }
}
