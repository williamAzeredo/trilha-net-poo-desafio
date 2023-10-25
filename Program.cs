using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Teste no IPHONE");
Iphone ip = new Iphone("123","11","252368",8);
ip.Ligar();
ip.InstalarAplicativo("Instalando Aplicativo IPhone");
ip.ReceberLigacao();
Console.WriteLine("==============================");
Console.WriteLine("Teste no NOKIA");
Nokia nk = new Nokia("321", "N45", "363636", 4);
nk.Ligar();
nk.InstalarAplicativo("Instalando Aplicativo Nokia");
nk.ReceberLigacao();
Console.WriteLine("==============================");