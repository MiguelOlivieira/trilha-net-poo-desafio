using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone: ");
Iphone iphone = new Iphone(numero: "123456", modelo: "iphone13", imei: "556789", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "1234567", modelo: "NokiaLumia", imei: "55349", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
