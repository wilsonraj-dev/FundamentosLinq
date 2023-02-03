namespace FundamentosLinq.Fundamentos_9
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

        public static List<Pessoa> GetPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa { Nome = "Maria",
                             Cachorros = new Cachorro[] {
                                         new Cachorro { Nome = "Bilu", Idade = 10 },
                                         new Cachorro { Nome = "Pipoca", Idade = 14 },
                                         new Cachorro { Nome = "Bidu", Idade=6 }}},
                new Pessoa { Nome = "Fernando",
                             Cachorros = new Cachorro[] {
                                         new Cachorro { Nome = "Canelinha", Idade = 1 }}},
                new Pessoa { Nome = "Amanda",
                             Cachorros = new Cachorro[] {
                                         new Cachorro { Nome = "Bisteca", Idade = 8 }}},
                new Pessoa { Nome = "Patricia",
                             Cachorros = new Cachorro[] {
                                         new Cachorro { Nome = "Acerola", Idade = 2 },
                                         new Cachorro { Nome = "Mel", Idade = 13 }}}

            };

            return pessoas;
        }

        public static List<Cachorro> GetCachorros()
        {
            List<Cachorro> cachorros = new List<Cachorro>()
            {
                new Cachorro() { Nome = "Bilu", Idade = 6, Vacinado = true },
                new Cachorro() { Nome = "Canelinha", Idade = 3, Vacinado = true },
                new Cachorro() { Nome = "Pipoca", Idade = 8, Vacinado = true},
            };

            return cachorros;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno() { Nome = "Maria", Pontos = 275 },
                new Aluno() { Nome = "Marta", Pontos = 375 },
                new Aluno() { Nome = "Pedro", Pontos = 299 },
            };

            return alunos;
        }
    }
}
