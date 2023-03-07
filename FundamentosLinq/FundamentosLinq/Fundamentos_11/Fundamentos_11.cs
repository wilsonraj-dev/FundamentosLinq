namespace FundamentosLinq.Fundamentos_11
{
    internal class Fundamentos_11
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
            
            #endregion
        }
    }
}
