using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Array
    {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 2.5, 3.6, 4.7, 5.8, 6.9, 7.0 };
            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
