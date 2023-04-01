// Data Types Veri tipleri

#region // veri tipleri string yazı
// Metinsel Tipler string,
using System.Text;

string sehir;
sehir = "İstanbul";
string kullanici = "admin";

Console.WriteLine(sehir);
#endregion

#region  //char tek karakter 
//karakter veri tipi
char harf = 'a';
Console.WriteLine(harf);
Console.WriteLine();

#endregion

#region Tamsayı tipler
// byte<ushort<short<uint<int<ulong<long

byte byteSayi = 10;
short shortSayi = 14332;
int intSayi = 234244353;
long longSayi = 49365656598984848;

Console.WriteLine($"Max : {int.MaxValue}-Min{int.MinValue}-Boyut: {sizeof(int)}");
#endregion

#region Ondalık Sayı tipleri
//float<double<decimal 
//decimal parasal şeylerde kullanılır
double doubleSayi = 3.14D;
float floatSayi = 3.14F;
decimal decimalSayi = 3.14M;
Console.WriteLine(decimalSayi);
#endregion

#region Mantıksal tipler
bool dogruMuSamet = true;
bool buyukMu = 5 > 3;

Console.WriteLine(buyukMu);
#endregion

//Önden tanımlı 15 tane tip 
//kompleks tip 15 tane tip kullanarak kendi tiplerimizi oluşturmamıza yarar. f12 ile class ayrıntılarına gidilir.
//Oop herşeyi nesne olarak tanımlar.

#region //Object tüm verileri kapsar
/*
int sayi1 = 15;
sayi1 = "55"; //primitive önden tanımlı tiplerde hata verir.
              //Tip güvenliği devreye girer.*/

object sayi = 10;
sayi = "20"; 
//Object bütün tiplerin var olmasını sağlar.Tüm verileri kapsar.

//kompleks tiplerde sıkıntı çıkmaz. herşey obje(örnek int,string console.writeline vb ) olduğu için hata vermiyor.

#endregion

// Stack bölgesinde duranlara Value(Değer) Type -> diğer veri tiplerin hepsi 
// Heap bölgesinde duranlara Reference Type -> String,object 
//Heap bölgesinde elemanlarda sizeof alınamaz çünkü sabit boyut yok
//stack heap'e göre daha hızlı ve stack yığın olarak tutar rastgelelik yoktur sıralı düzenli 
// heap rastgele tutar sıra düzen yoktur.
//Stackde değişken tanımlanır string kelime = "a"; kelime yani değişken stackde , değeri heap'de tutulur.
//tipin üzerine gel f12 yap class ise referans struct ise değer tiplidir.


Console.ReadKey();
