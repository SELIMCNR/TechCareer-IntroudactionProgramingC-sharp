
int sayi = 300; 
byte number = Convert.ToByte(sayi); // byte değeri alamayacağından hata verir.

int sayi2 = 300;
byte number2 = (byte) sayi2; // hata vermez ama sayıyı eksik verir

checked  // hata alınacak yerlerde hata verdirir.
{
    int sayi3 = 300;
    byte number3 = (byte) sayi3;
}

// Convert : önden tanımlı tiplerde birbirine dönüştürmek için kullanılır.

double fiyat = 30.5;
int sayi4 = Convert.ToInt32(fiyat);   // yuvarlama işlemi yapar 0.5 i 1 e , 0.4 ü 0 'a gibi.
Console.WriteLine(sayi4);

int sayi5 = 0;  // 0 false   0 haricinde hepsi true değeri döner. -10 da + 10 da true.
bool sonuc = Convert.ToBoolean(sayi5);
Console.WriteLine(sonuc);

char harf = 'A';
harf++;
int kod = (int) harf; // chardan integere dönüşte ascıı kodu gelitr
Console.WriteLine(kod);
kod += 5;
harf = (char) kod;
Console.WriteLine(harf);







Console.ReadKey();