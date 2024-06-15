abstract class Conta
{
    private double _saldo;
    private double _limite;

    public double Saldo { get => _saldo; }
    public double Limite { get => _limite; set {
        if (value > 0)
        {
            _limite = value;
        }
    } }

    public virtual void Depositar (double valor)
    {
        if (valor > 0){
            _saldo += valor;
        }
    }

    public virtual void Sacar (double valor)
    {
        if (valor <= _saldo)
        {
            _saldo -= valor;
        }
    }
}