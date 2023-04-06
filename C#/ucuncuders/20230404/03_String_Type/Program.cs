using System.Globalization;

float pi = 3.14F;
string strPi = pi.ToString(); // stringe döndürür.
Console.WriteLine(strPi);


string metin = "123";
int sayi = int.Parse(metin); // integere döndürür.
Console.WriteLine(++sayi);

//string bir immutable bir dilidir. 
string isim = "Selim";
isim += "Çınar";
Console.WriteLine(isim);

isim = $"";
isim = string.Format("{0} {1} ", "Selim","Çınar");