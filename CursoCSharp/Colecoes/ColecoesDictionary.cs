using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2004, "A Rocha");
            filmes.Add(2005, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            Console.WriteLine(filmes.ContainsValue("Batman"));

            Console.WriteLine("Removeu? {0}", filmes.Remove(2004));

            foreach (KeyValuePair<int, string> film in filmes) {
                Console.WriteLine("O {0} é de {1}", film.Value, film.Key);
            }

            foreach (var film in filmes) {
                Console.WriteLine("O {0} é de {1}", film.Value, film.Key);
            }
        }
    }
}
