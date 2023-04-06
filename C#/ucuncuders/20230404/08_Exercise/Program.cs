//kullanıcının girdiği harf  büyük mü küçük mü ekrana yazdırın - İngiliz alfabesi 
Console.WriteLine("Bir harf girin");
char harf = char.Parse(Console.ReadLine());
int ascii = harf;

if(ascii =>65 && ascii<=96)
{
    Console.WriteLine("Büyük harf");
}
else if (ascii>96 && ascii <= 122)
{
    Console.WriteLine("Küçük harf");
}
else
{
    Console.WriteLine("Harf girmedin ");
}




if (ascii >= 'A' && ascii <= 'Z')
{
    Console.WriteLine("Büyük harf");
}
else if (ascii >= 'a' && ascii <= 'z')
{
    Console.WriteLine("Küçük harf");
}
else
{
    Console.WriteLine("Harf girmedin");
}


Console.ReadKey();