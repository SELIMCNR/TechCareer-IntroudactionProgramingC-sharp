
/*
int sayi = 10;
byte number = sayi;  büyük int küçük byte eklenemiyor 
*/
/*
 1.Cast
 2.Convert Methods
 3.ToString
 4.Parse 
 */

#region Cast 
int sayi = 10;
byte number = (byte)sayi; // (byte) sayi  cast işlemi

byte sayi1 = 20;
int number1 = (int)sayi1;  // cast işlemi

//Explicit   açık dönüşüm  küçük tipten büyük tipe geçiş
//Implicit   kapalı dönüşüm  büyük tipten küçük tipe geçiş 

/*  Referans tipli stringe cast olmaz inte 
string sayi2 = "5";
int number2 = (int)sayi2;   
*/

object sayi2 = 5; 
int number3 = (int)sayi2; 


#endregion

Console.ReadKey();