/*cast*/
int sayi = 1000;
byte number = (byte)sayi;
Console.WriteLine(number);  // 10 luk sistemde değeri gelir.

/* referans tipten değere dönüşüm olmuyor
string metin = "123";
int sayi2 = (int)metin;
*/

/* hatalı durumlar 
object objSayi = 50;
int sayi3 = (int)objSayi;

object metin = "abc";
string text = (string)metin;
*/

//Boxing  - Unboxing 
object sayi4 = 20;    // boxing 
int number4 = (int) sayi4;  // unboxing



Console.ReadKey();