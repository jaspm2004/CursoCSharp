using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar() {
            var pilha = new Stack();
            pilha.Push("Item");
            pilha.Push(true);
            pilha.Push(3);
            pilha.Push(3.14f);

            foreach (var item in pilha) {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine("{0}", pilha.Pop());
            Console.WriteLine("{0}", pilha.Peek());
        }
    }
}
