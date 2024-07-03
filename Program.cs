using DesafioPOO.Models;

// VVTODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia(numero:"81984371475",modelo:"SS54",iMEI: "99999999", memoria: 85);

Iphone iphone = new Iphone(numero:"81986802342",modelo:"G25",iMEI: "8888888", memoria: 81);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Watsapp");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

