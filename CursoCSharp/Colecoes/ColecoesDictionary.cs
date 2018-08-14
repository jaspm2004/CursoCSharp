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
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));   // não lança erro caso a chave não exista
            }

            Console.WriteLine(filmes.ContainsValue("Batman"));

            Console.WriteLine("Removeu? {0}", filmes.Remove(2004));

            filmes.TryGetValue(2006, out string filme2006); // não lança erro caso a chave não exista
            Console.WriteLine("2006: {0}", filme2006);

            foreach (KeyValuePair<int, string> film in filmes) {
                Console.WriteLine("O {0} é de {1}", film.Value, film.Key);
            }

            foreach (var film in filmes) {
                Console.WriteLine("O {0} é de {1}", film.Value, film.Key);
            }
        }
    }
}
