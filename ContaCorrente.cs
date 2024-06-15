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
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
        }

        public void MostrarSaldo (){
            Console.WriteLine($"Saldo {Saldo}");
            Console.ReadKey();
        }
    }
}