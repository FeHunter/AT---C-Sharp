using System;

namespace AtChsarp
{
    public class Program
    {
        static void Main ()
        {
            ContaCorrente conta1 = new ContaCorrente(0, 300);

            bool fim = false;

            while (!fim){
                int op = Menu();
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