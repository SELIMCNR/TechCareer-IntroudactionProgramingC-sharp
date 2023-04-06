
using System.Threading.Channels;

string isim = "platon";


//isim değişkeni platon içeriyor mu ?
if(isim is "platon")
{

}

//isim değişkeni platon içermiyor mu ? 
if(isim is not "platon")
{

}

// koşullu switch case'de sıralama önemlidir.
int number = 10;
switch (number)
{
    case 0:
        Console.WriteLine("Sıfı");
        break;
    case < 5:
        Console.WriteLine("5'ten küçüktür");
        break;
    case >= 15:
        Console.WriteLine("15'ten büyüktür ve eşittir.");
        break;
}

int number1 = 2;
//Switch expression
string numberText = number1 switch
{
    1 => "bir",
    2 => "iki",
    3 => "üç",
    _ => "hatalı değer"
};
Console.WriteLine(numberText);

Console.WriteLine(number switch
{
    1 => "bir",
    2 => "iki",
    _ => "hatalıdeğer"
}) ;

string isim1 = "platon";
string sonuc = isim switch
{
    "platon" or "aristo" => "Tamam"
};

int number2 = 1;
string result = number2 switch
{
    1 or 2 => "1veya 2",
    >= 3 and <= 7 => "3 ile 7 arasında",
    not 9 => "9 değil",
    _=>  "Tanımsız"
};
Console.WriteLine(result);


string result3 = DateTime.Now.DayOfWeek switch
{
    DayOfWeek.Wednesday when DateTime.Now.Hour > 20 => "Çarşamba akşam",
    DayOfWeek.Wednesday => "Çarşamba"
};
Console.WriteLine(result3);




Console.ReadKey();