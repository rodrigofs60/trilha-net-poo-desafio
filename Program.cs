using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "95555-5555", modelo: "N1", imei: "11111", memoria: 64);
nokia.InstalarAplicativo("Whatsapp");
nokia.Ligar();

Smartphone iphone = new Iphone(numero: "96666-777", modelo: "Iphone 13", imei: "22222", memoria: 128);
iphone.InstalarAplicativo("TikTok");
iphone.ReceberLigacao();
