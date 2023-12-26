using DesafioPOO.Models;

// Instanciando as classes implementadas

Nokia nokia = new Nokia("1199789129", "Nokia 5110", "353612656105272", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Cybertron VR 6000");

Console.WriteLine();

Iphone iphone = new Iphone("1199789129", "iPhone 4 SE", "353612656106666", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Ultimate RAM Downloader");

Console.WriteLine();

Console.WriteLine("Teste finalizado");