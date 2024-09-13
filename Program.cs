
using CELULAR_COM_POO.Models;

Console.WriteLine("-----NOKIA-----\n");
Smartphone nokia = new Nokia(numero: "6610", modelo: "Lumia", imei: "11111111", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo(nomeAPP: "Instagram");

Console.WriteLine("\n-----IPHONE-----\n");
Smartphone iphone = new Iphone(numero: "15", modelo: "PRO MAX", imei: "222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao(tel: "11 97777-4444");
iphone.InstalarAplicativo(nomeAPP: "WhatsApp");