namespace AtChsarp
{
    abstract class Conta
    {
        private double _saldo;
        private double _limite;

        public double Saldo { get => _saldo; protected set => _saldo = value; }
        public double Limite { get => _limite; private set {
            if (value > 0)
            {
                _limite = value;
            }
        } }

        public Conta (double saldo, double limite)
        {
            Saldo = saldo;
            Limite = limite;
        }

        public abstract void Depositar (double valor);

        public abstract void Sacar (double valor);
    }
}