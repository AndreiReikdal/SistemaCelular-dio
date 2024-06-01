using System;

namespace SistemaCelulares
{
    // Classe base para celulares
    public abstract class Celular
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Ligar();
        public abstract void Desligar();
    }

    // Classe para celulares Nokia
    public class Nokia : Celular
    {
        public Nokia(string modelo) : base("Nokia", modelo) { }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando o Nokia {Modelo}");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando o Nokia {Modelo}");
        }
    }

    // Classe para celulares iPhone
    public class iPhone : Celular
    {
        public iPhone(string modelo) : base("iPhone", modelo) { }

        public override void Ligar()
        {
            Console.WriteLine($"Ligando o iPhone {Modelo}");
        }

        public override void Desligar()
        {
            Console.WriteLine($"Desligando o iPhone {Modelo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Celulares!");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Ligar Nokia");
            Console.WriteLine("2. Ligar iPhone");
            Console.WriteLine("3. Desligar Nokia");
            Console.WriteLine("4. Desligar iPhone");
            Console.WriteLine("5. Sair");

            int opcao;
            Nokia nokia = new Nokia("3310");
            iPhone iphone = new iPhone("X");

            do
            {
                Console.Write("Digite a opção desejada: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            nokia.Ligar();
                            break;
                        case 2:
                            iphone.Ligar();
                            break;
                        case 3:
                            nokia.Desligar();
                            break;
                        case 4:
                            iphone.Desligar();
                            break;
                        case 5:
                            Console.WriteLine("Até logo!");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            } while (opcao != 5);
        }
    }
}
