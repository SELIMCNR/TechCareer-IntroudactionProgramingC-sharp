int firstNumber = 10;
int secondNumber = 20;
byte operation;
Console.WriteLine("Toplama için: 1 , Çıkarma için : 2 , Çarpma için : 3 ,Bölme için : 4");

operation = byte.Parse( Console.ReadLine());

#region ifelse
if (operation == 1)
{
    Console.WriteLine(firstNumber + secondNumber);
}
else if(operation == 2)
{
    Console.WriteLine(firstNumber - secondNumber);
}
else if(operation == 3)
{
    Console.WriteLine(firstNumber * secondNumber);
}
else if(operation == 4)
{
    Console.WriteLine(firstNumber / secondNumber);
}
Console.ReadKey();
#endregion
switch (operation)
{
    case 1:
        Console.WriteLine(firstNumber+secondNumber);
        break;
    case 2:
        Console.WriteLine(firstNumber- secondNumber);
        break;
    case 3:
        Console.WriteLine(firstNumber*secondNumber);
        break;
    case 4:
        Console.WriteLine(firstNumber/secondNumber);
        break;
    default:
        Console.WriteLine("Hatalı işlem");
        break;
}

switch (operation)
{
    case 1:
    case 2:
        Console.WriteLine(firstNumber + secondNumber);
            break;
    case 3:
    case 4:
    case 5:
        break;
}

ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine(keyInfo.KeyChar);
Console.WriteLine(keyInfo.Key);
if(keyInfo.Key == ConsoleKey.Tab)
{
    Console.WriteLine("Tab tuşu");
}


switch (keyInfo.Key)
{
    case ConsoleKey.W:
        Console.WriteLine("ileri");
        break;
    case ConsoleKey.S:
        Console.WriteLine("geri");
        break;
    case ConsoleKey.D:
        Console.WriteLine("sağa");
        break;
    case ConsoleKey.A:
        Console.WriteLine("sola");
        break;
    default:
        break;
}


Console.ReadKey();

