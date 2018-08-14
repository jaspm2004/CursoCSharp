using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar() {
            string entrada = "";
            bool bom;

            //if(entrada == "S" || entrada == "s") {
            //    bom = true;
            //}

            //bom = entrada == "S" || entrada == "s";
            bom = entrada.ToLower() == "s";
        }
    }
}
