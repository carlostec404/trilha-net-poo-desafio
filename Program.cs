﻿using DesafioPOO.Models;

Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo-01", imei: "1111-JKS", memoria: 128);
nokia.Ligar();
nokia.InfoCell();
nokia.InstalarAplicativo("GitHub");
Console.WriteLine();
Console.WriteLine("DADOS DO PROXIMO APARELHO:");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "2024-512PTBR", modelo: "Modelo-ProMAX", imei: "4052-ERG", memoria: 512);
iphone.InfoCell();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");