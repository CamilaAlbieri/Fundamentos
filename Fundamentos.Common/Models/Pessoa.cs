using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física
    /// </summary>
    public class Pessoa
    {

        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, eu tenho {Idade} anos.");
        }
    }
}

