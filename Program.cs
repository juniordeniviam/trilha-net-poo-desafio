using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "2198765432", modelo: "Model one", imei: "123456", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "21991662080", modelo: "Model 8", imei: "78900", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");