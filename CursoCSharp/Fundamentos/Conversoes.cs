using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}");

            Console.Write("Digite a sua idade: ");
            string idadeStr = Console.ReadLine();
            int idadeInt = int.Parse(idadeStr);
            Console.WriteLine($"Idade inserida: {idadeInt}");

            idadeInt = Convert.ToInt32(idadeStr);
            Console.WriteLine($"Idade inserida: {idadeInt}");

            Console.Write("Digite o primeiro número: ");
            string n1Str = Console.ReadLine();
            int n1;
            int.TryParse(n1Str, out n1);
            Console.WriteLine($"Número 1: {n1}");

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int n2);
            Console.WriteLine($"Número 2: {n2}");
        }
    }
}
