
bool result = 3 < 5;
Console.WriteLine(result);
Console.WriteLine(!result);

// && ve , || veya karşılaştırma operatörler <,<=,>,>= ,==
result = 4 < 5 && 3<5;
result = 5 < 5 ||  3<5;
Console.WriteLine(result);

// Aritmetiksel operatörler 
// + , -,* , / ,% mod alma

int sayi = 5;
sayi = sayi + 1;
sayi++;

// -> 1 artırma    -- -> 1 azaltma 

int number = sayi++; //number = sayi; sayi = sayi + 1; öncelik sırası
number = ++sayi;     // sayi = sayi + 1 ; number = sayi

Console.WriteLine(number);
Console.WriteLine(5 % 3 );


Console.ReadKey();
