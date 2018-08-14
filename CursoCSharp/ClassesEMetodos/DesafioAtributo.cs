using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo {
        int a = 10;

        public static void Executar() {
            Console.WriteLine("a = {0}", new DesafioAtributo().a);
        }        
    }
}
