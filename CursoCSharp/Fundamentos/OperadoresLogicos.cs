using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var fezT1 = true;
            var fezT2 = false;

            var comprouTv50 = fezT1 && fezT2;
            Console.WriteLine("Comprou TV 50? {0}", comprouTv50);

            var comprouSorvete = fezT1 || fezT2;
            Console.WriteLine("Comprou sorve? {0}", comprouSorvete);

            var comprouTV32 = fezT1 ^ fezT2;
            Console.WriteLine("Comprou TV 32? {0}", comprouTV32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}
