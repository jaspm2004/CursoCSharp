using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        public static void recepcionar(params string[] nomes) {
            foreach (var nome in nomes) {
                Console.WriteLine("Olá {0}", nome);
            }

        }

        public static void Executar() {
            recepcionar("José", "Carlos", "Flávio", "Matheus");
        }
    }
}
