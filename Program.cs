using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234567", modelo: "1100", imei: "1234567K", 10);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "6 Plus", imei: "369852147Y", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

