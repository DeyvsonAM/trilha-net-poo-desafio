using System.Reflection.Emit;
using DesafioPOO.Models;


    //VV TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone{

        
       public Iphone(string numero, string modelo, string iMEI, int memoria) : base(numero,modelo,iMEI,memoria){

       }
       


      public override void InstalarAplicativo(string nomeApp)
{

    Console.WriteLine("Foi instalado no Iphone o app " + nomeApp);

}  //VV TODO: Sobrescrever o método "InstalarAplicativo"
    }
