namespace FundamentosLinq.Fundamentos_14
{
    internal class PaginacaoDeDados
    {
        //Implementando a paginação
        int RegistrosPorPagina = 4;
        int NumeroPagina;

        public void Metodo()
        {
            do
            {
                Console.Write("\nInforme o nº de página entre 1 e 4: ");
                if (int.TryParse(Console.ReadLine(), out NumeroPagina))
                {
                    if (NumeroPagina > 0 && NumeroPagina < 5)
                    {
                        var alunos = Aluno.GetAlunos().Skip((NumeroPagina - 1) * RegistrosPorPagina)
                                                      .Take(RegistrosPorPagina).ToList();

                        Console.WriteLine("\nPágina. :" + NumeroPagina);

                        foreach (var aluno in alunos)
                        {
                            Console.WriteLine($"Id: {aluno.Id} Nome: {aluno.Nome} Curso: {aluno.Curso}");
                        }
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            } while (true);
        }
    }
}
