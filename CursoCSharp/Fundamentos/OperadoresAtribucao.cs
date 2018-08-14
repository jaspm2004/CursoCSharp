using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribucao
    {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            Console.WriteLine(a);
            Console.WriteLine(b);

            a++;
            b--;

            Console.WriteLine(a);
            Console.WriteLine(b);

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine(c.nome);
        }
    }
}
