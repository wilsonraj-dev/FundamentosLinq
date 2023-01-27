namespace FundamentosLinq.Fundamentos_7
{
    internal class Fundamentos_7
    {
        static void Main(string[] args)
        {
            string[] cursos = { "C#", "Java", "Python", "PHP", "Go" };
            string resultado = cursos.Aggregate((s1, s2) => s1 + ", " + s2);
            Console.WriteLine(resultado);

            int[] numeros = { 3, 5, 7, 9 };
            int resultado1 = numeros.Aggregate((x, y) => x * y);
            Console.WriteLine(resultado1);

            var alunos = FonteDados.GetAlunos();
            string listaAlunos = alunos.Aggregate<Aluno, string>(
                                        "Nomes: ", //valor da semente
                                        (semente, aluno) => semente += aluno.Nome + ",");
            int indice = listaAlunos.LastIndexOf(",");
            listaAlunos = listaAlunos.Remove(indice);
            Console.WriteLine(listaAlunos);


            string novaListaAlunos = alunos.Aggregate<Aluno, string, string>(
                                            "Nomes: ", //valor da semente
                                            (semente, aluno) => semente += aluno.Nome + ",",
                                            resultado => resultado.Substring(0, resultado.Length - 1));
            Console.WriteLine(novaListaAlunos);

            var media = alunos.Average(x => x.Idade);
            Console.WriteLine(media);

            Console.ReadKey();
        }
    }
}
