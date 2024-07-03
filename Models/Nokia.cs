using DesafioPOO.Models;

    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
    {

    }
    public override void InstalarAplicativo(string nomeApp)
    {

        Console.WriteLine("Foi instalado no Nokia o app " + nomeApp);

    }

    // TODO: Sobrescrever o método "InstalarAplicativo"
}
