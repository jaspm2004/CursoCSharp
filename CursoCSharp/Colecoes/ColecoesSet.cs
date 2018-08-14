using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet {

        public class Produto {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco) {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object obj) {
                var produto = obj as Produto;
                return produto != null &&
                       Nome == produto.Nome &&
                       Preco == produto.Preco;
            }

            public override int GetHashCode() {
                var hashCode = -347481536;
                hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
                hashCode = hashCode * -1521134295 + Preco.GetHashCode();
                return hashCode;
            }
        }

        public static void Executar() {
            var livro = new Produto("Edad de Oro", 29.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 79.9),
                new Produto("HD", 299.9),
                new Produto("Skate", 99.9),
                new Produto("Skate", 99.9)
            };

            carrinho.UnionWith(combo);
            carrinho.Add(livro);

            foreach (var item in carrinho) {
                Console.WriteLine("{0} {1}", item.Nome, item.Preco);
            }

        }
    }
}
