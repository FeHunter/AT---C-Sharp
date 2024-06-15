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
}