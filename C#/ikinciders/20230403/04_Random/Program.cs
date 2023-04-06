Random random = new Random();
var a =random.Next(0, 20);  // 0 ile 20 arası rastgele sayı gelir
var b = random.NextDouble(); // 0.0 ile 1.0 arası rastgele sayı gelir
var c = random.NextInt64(0,100);



Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.ReadKey();