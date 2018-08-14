using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum
    {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filme = new Filme();
            filme.Titulo = "The Rock";
            filme.GeneroDoFilme = Genero.Acao;
            Console.WriteLine("{0} é {1}", filme.Titulo, filme.GeneroDoFilme);
        }
    }
}
