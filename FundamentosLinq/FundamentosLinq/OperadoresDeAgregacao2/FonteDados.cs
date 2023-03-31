namespace FundamentosLinq.Fundamentos_8
{
    internal class FonteDados
    {
        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>()
            {
                new Funcionario() { Nome = "Maria", Idade = 22, Salario = 3290.55m },
                new Funcionario() { Nome = "Manoel", Idade = 24, Salario = 4125.45m },
                new Funcionario() { Nome = "Amanda", Idade = 21, Salario = 5123.99m },
                new Funcionario() { Nome = "Carlos", Idade = 18, Salario = 6200.50m },
                new Funcionario() { Nome = "Alicia", Idade = 17, Salario = 4099.11m },
                new Funcionario() { Nome = "Sandra", Idade = 19, Salario = 6124.50m },
            };

            return funcionarios;
        }
    }
}
