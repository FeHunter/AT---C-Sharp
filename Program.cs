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
                MostrarMenu();
            }
        }

        static public void MostrarMenu ()
        {
            Console.WriteLine("1 - Sacar");
            Console.WriteLine("2 - Apresentar o saldo");
            Console.WriteLine("3 - Depositar");
            Console.WriteLine("4 - Sair");
        }
    }
}