int sayi = 10;

if (sayi % 2 == 0)
{
    Console.WriteLine($"{sayi} sayısı çifttir.");
}
else
{
    Console.WriteLine($"{sayi} sayısı tektir.");
}

int number = int.Parse(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Pozitif");
}
else
{
    
    if (number < 0)
    {

        Console.WriteLine("Sayi negatif");
    }
    else
    {
        Console.WriteLine("Sıfıra eşittir");
    }
}

int number1 = int.Parse(Console.ReadLine());

if (number1 > 0)
{
    Console.WriteLine("Pozitif");
}
else if (sayi == 0)
{
    Console.WriteLine("Sıfır");
}
else
{
    Console.WriteLine("Negatif");
}




Console.ReadKey();