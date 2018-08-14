using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public static string cidade;

        public Pessoa(string nome, int idade, string cidadeP) {
            this.nome = nome;
            this.idade = idade;
            cidade = cidadeP;
        }

        public Pessoa(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;            
        }

        public string toString() {
            return string.Format("nome = {0}, idade = {1}, cidade = {2}", nome, idade, cidade);
        }

        public void print() {
            Console.WriteLine(toString());
        }

        public void zerar() {
            nome = "";
            idade = 0;
        }
    }
}
