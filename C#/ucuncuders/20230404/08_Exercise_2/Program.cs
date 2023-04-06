/*Kullanıcının girdiği sayı 7 'nin katı mı değil mi 
Eğer katıysa kaç katı onu da yazın , Sayı girmediyse uyarı verin */

Console.Write("Sayı : ");
int number = 0;
bool isParsed = int.TryParse(Console.ReadLine(), out number);

if (isParsed)
{
    if (number % 7 == 0)
    {
        Console.WriteLine($"{number} sayısı 7 'nin {number / 7} katıdır");
    }
    else
    {
        Console.WriteLine($"{number} sayısı 7 'nin katı değildir ");
    }
}
else
{
    Console.WriteLine("Sayı girmedin");
}

Console.ReadKey();
