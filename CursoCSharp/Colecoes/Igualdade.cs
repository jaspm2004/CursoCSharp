using System;
using System.Collections.Generic;
using System.Text;
//using static CursoCSharp.Colecoes.ColecoesSet;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar() {
            var p1 = new ColecoesSet.Produto("Caneta", 1.89);
            var p2 = new ColecoesSet.Produto("Caneta", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p2 == p3);

            Console.WriteLine(p1.Equals(p2));
        }
    }
}

