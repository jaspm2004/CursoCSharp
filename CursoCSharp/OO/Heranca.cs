using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Carro {

        private readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                novaVelocidade = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                novaVelocidade = VelocidadeMaxima;
            }

            VelocidadeAtual = novaVelocidade;

            return novaVelocidade;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {

        public Uno() : base(200) {

        }
    }

    public class Ferrari : Carro {

        public Ferrari() : base(350) {
        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        // oculta método da classe pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
        
    }

    class Heranca
    {
        public static void Executar() {
            Uno c1 = new Uno();
            Console.WriteLine(c1.Acelerar());
            Console.WriteLine(c1.Frear());
            Console.WriteLine(c1.Frear());

            Ferrari c2 = new Ferrari();
            Console.WriteLine(c2.Acelerar());
            Console.WriteLine(c2.Acelerar());
            Console.WriteLine(c2.Frear());
            Console.WriteLine(c2.Frear());
            Console.WriteLine(c2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro c3 = new Ferrari();   // Polifmorfismo
            Console.WriteLine(c3.Acelerar());
            Console.WriteLine(c3.Acelerar());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());
            Console.WriteLine(c3.Frear());
        }
    }
}
