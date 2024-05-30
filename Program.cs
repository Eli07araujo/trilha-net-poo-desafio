using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Criação de um objeto Smartphone da classe Nokia
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "N91000", imei: "111111111", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Mercado Livre");

Console.WriteLine("\n");

// Criação de um objeto Smartphone da classe Iphone
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "74108520", modelo: "15", imei: "555555555", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");