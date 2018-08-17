using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Animal {
        protected String Nome { get; set; }

        public Animal(String nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        public Cachorro(String nome) : base(nome) {
            Console.WriteLine("Cachorro {0} inicalizado", nome);
        }

        public Cachorro(String nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"O {Nome} tem {Altura} de altura";
        }

    }

    class ConstrutorThis
    {
        public static void Executar() {
            Cachorro spike = new Cachorro("spike");
            Cachorro pacoca = new Cachorro("paçoca", 40);

            Console.WriteLine(spike);
            Console.WriteLine(pacoca);
        }
    }
}
