﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosLinq.Fundamentos_6
{
    internal class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new()
            {
                new Aluno() { Nome = "Maria", Idade = 36 },
                new Aluno() { Nome = "Manoel", Idade = 33 },
                new Aluno() { Nome = "Amanda", Idade = 21 },
                new Aluno() { Nome = "Carlos", Idade = 18 },
                new Aluno() { Nome = "Jaime", Idade = 36 },
                new Aluno() { Nome = "Débora", Idade = 33 },
                new Aluno() { Nome = "Alicia", Idade = 18 },
                new Aluno() { Nome = "Sandra", Idade = 19 },
            };

            return alunos;
        }
    }
}
