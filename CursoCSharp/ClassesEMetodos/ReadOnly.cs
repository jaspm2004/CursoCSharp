using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }

    class ReadOnly {
        public static void Executar() {
            var cliente = new Cliente("José", new DateTime(1981, 11, 18));
            Console.WriteLine(cliente.GetNascimento());
        }
    }
}
