abstract class Conta
{
    private double _saldo;
    private double _limite;

    public double Saldo { get => _saldo; set =>  if (value > 0){ _saldo = value; }}
    public double Limite { get => _limite; set => _limite = value; }
}