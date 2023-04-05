namespace FundamentosLinq.OperadoresDeConversao
{
    internal class FonteDados
    {
        public static IEnumerable<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Id = 1, Nome = "Maria", Idade = 36 },
                new Aluno() { Id = 2, Nome = "Manoel", Idade = 33 },
                new Aluno() { Id = 3, Nome = "Amanda", Idade = 21 },
                new Aluno() { Id = 4, Nome = "Carlos", Idade = 18 },
                new Aluno() { Id = 5, Nome = "Jaime", Idade = 36 },
                new Aluno() { Id = 6, Nome = "Debora", Idade = 33 },
                new Aluno() { Id = 7, Nome = "Alicia", Idade = 18 },
                new Aluno() { Id = 8, Nome = "Sandra", Idade = 19 },
            };

            return alunos.AsEnumerable();
        }

        public static IEnumerable<Pacote> GetPacotes()
        {
            List<Pacote> pacotes = new()
            {
                new Pacote() { Empresa = "Google", Peso = 25.2 },
                new Pacote() { Empresa = "JcmSoft", Peso = 18.7 },
                new Pacote() { Empresa = "Twitter", Peso = 33.8 },
            };

            return pacotes.AsEnumerable();
        }

        public static IEnumerable<Funcionario> GetFuncionarios()
        {
            List<Funcionario> funcionarios = new()
            {
                new Funcionario() { Nome = "Maria", Cidade = "Santos", Cargo = "Admin" },
                new Funcionario() { Nome = "Marta", Cidade = "Lins", Cargo = "Assistente" },
                new Funcionario() { Nome = "Paulo", Cidade = "Campinas", Cargo = "Vendedor" },
                new Funcionario() { Nome = "Carlos", Cidade = "Lins", Cargo = "Vendedor" },
                new Funcionario() { Nome = "Amanda", Cidade = "Barretos", Cargo = "Caixa" },
                new Funcionario() { Nome = "Vicente", Cidade = "Santos", Cargo = "Operador" },
                new Funcionario() { Nome = "Armando", Cidade = "Campinas", Cargo = "Gerente" },
            };

            return funcionarios.AsEnumerable();
        }
    }
}
