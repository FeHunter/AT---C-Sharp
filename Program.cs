using System;

namespace AtChsarp
{
    public class Program
    {
        static void Main ()
        {
            ContaCorrente conta = new ContaCorrente(0, 300);

            bool fim = false;
            int op = 0;

            while (!fim){
                // Leitura das opções e evitar erros
                do
                {
                    op = Menu();
                }while (op < 1 || op > 4);

                if (op == 1)
                {
                    Console.Write("\nDigite o valor para sacar: ");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Sacar(valor);
                }
                else if (op == 2)
                {
                    conta.MostrarSaldo();
                }
                else if (op == 3)
                {
                    Console.Write("\nDigite o valor do deposito: ");
                    double valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }
                else if (op == 4)
                {
                    fim = true;
                }
            }
        }

        static public int Menu ()
        {
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Apresentar o saldo");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("4 - Sair");
            int op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}