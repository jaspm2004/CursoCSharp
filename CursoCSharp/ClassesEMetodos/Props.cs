using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CarroOpcional {
        double desconto = 0.1;
        string nome;

        // Propriedade com geters e seters customizados
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Propriedade somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);  // Lambda

            /*get {
                return Preco - (desconto * Preco);
            }*/
        }

        public CarroOpcional() {

        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

    }

    class Props
    {
        public static void Executar() {
            var op1 = new CarroOpcional("ar condicionado", 3499.9);
            Console.WriteLine("carro 1");
            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto);

            Console.WriteLine("");

            var op2 = new CarroOpcional();
            op2.Nome = "direção elétrica";
            op2.Preco = 2349.99;
            Console.WriteLine("carro 2");
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
