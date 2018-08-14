using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadorTernario
    {
        public static void Executar() {
            var nota = 9.0;
            bool bom = false;
            string resultado = nota >= 7.0 && bom ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);
        }
    }
}
