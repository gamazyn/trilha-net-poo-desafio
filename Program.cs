using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "120920", modelo: "Modelo 1", imei: "2918902183918", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("IFood");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "982304", modelo: "Modelo 4", imei: "90932092302", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");