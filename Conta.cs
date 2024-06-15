abstract class Conta
{
    private double _saldo;
    private double _limite;

    public double Saldo { get => _saldo; private set => _saldo = value; }
    public double Limite { get => _limite; private set {
        if (value > 0)
        {
            _limite = value;
        }
    } }

    public abstract void Depositar (double valor);

    public abstract void Sacar (double valor);
}