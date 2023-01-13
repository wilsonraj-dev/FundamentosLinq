namespace FundamentosLinq
{
    class Fundamentos_1
    {
        static void Main(string[] args)
        {
            IList<string> frutas = new List<string>() { "Banana", "Maça", "Pera", "Laranja", "Uva" };

            //Query syntax
            var resultado = from f in frutas
                            where f.Contains('r')
                            select f;

            Console.WriteLine(string.Join(" - ", resultado));

            //Method syntax
            var resultado2 = frutas.Where(f => f.Contains('r'));
            Console.WriteLine(string.Join(" - ", resultado2));

            Console.ReadKey();
        }
    }
}
