using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "213455", modelo: "Modelo 1", imei: "2321231231", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "567567", modelo: "Modelo 2", imei: "32189312890", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");