using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "44963258541", modelo: "896", imei: "9876541235", memoria: 528);
nokia.Ligar();
nokia.InstalarAplicativo("Genshin Impact");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "44998632054", modelo: "14 Pro", imei: "6543896874", memoria: 1024);
iphone.Ligar();
iphone.InstalarAplicativo("Free Fire");