using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse
    {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1;    // atribuição por VALOR!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            Console.WriteLine();

            CPonto cponto1 = new CPonto { X = 2, Y = 4 };
            CPonto copiaCPonto1 = cponto1;    // atribuição por REFERÊNCIA!
            cponto1.X = 4;

            Console.WriteLine("CPonto 1 X:{0}", cponto1.X);
            Console.WriteLine("Copia CPonto 1 X:{0}", copiaCPonto1.X);
        }
    }
}
