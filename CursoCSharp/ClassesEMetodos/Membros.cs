using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros {
        public static void Executar() {

            Pessoa p1 = new Pessoa("José", 37, "São Paulo");
            Pessoa p2 = new Pessoa("Carlos", 30);

            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
        }
    }
}
