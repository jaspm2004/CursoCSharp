using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var negativo = -5;
            var n1 = 2;
            var n2 = 3;
            var booleano = true;

            Console.WriteLine(-negativo);
            Console.WriteLine(!booleano);

            n1++;
            Console.WriteLine(n1);

            --n1;
            Console.WriteLine(n1);

            Console.WriteLine(n1++ == --n2);
            Console.WriteLine($"{n1} {n2}");
        }
    }
}
