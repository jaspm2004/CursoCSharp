using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesList {

        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }
        }

        public static void Executar() {
            var livro = new Produto("Edad de Oro", 29.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 79.9),
                new Produto("HD", 299.9),
                new Produto("Skate", 99.9)
            };

            carrinho.AddRange(combo);            

            foreach (var item in carrinho) {
                Console.WriteLine("{0} {1} {2}", carrinho.IndexOf(item), item.Nome, item.Preco);
            }

        }
    }
}
