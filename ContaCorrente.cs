using System;

namespace AtChsarp
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(double saldo, double limite) : base(saldo, limite)
        {
        }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Deposito efetuado com sucesso!\nNovo saldo: ${Saldo}");
                Console.ReadKey();
            }
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Saldo insuficiente, faça um deposito e tente novamente.");
                Console.ReadKey();
            }
        }

        public void MostrarSaldo (){
            Console.Clear();
            Console.WriteLine($"Saldo: {Saldo}");
            Console.ReadKey();
        }
    }
}