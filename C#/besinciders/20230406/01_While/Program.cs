

Console.WriteLine("Platon");
Console.WriteLine("Platon");
Console.WriteLine("Platon");
Console.WriteLine("Platon");
Console.WriteLine("Platon");


/* 1. While
 * 2. Do While
 * 3. For
 * 
 * 4. For Each
 */


//while (koşul)
//{

//}


int sayac = 1;
while (sayac <= 5)
{
    Console.WriteLine("Platon");
    sayac++;
}



// 1 ile 100 arasındaki çift sayıların toplamı
#region Yöntem 1
int toplam = 0;
int sayac1 = 1;
while (sayac1 < 101)
{
    if (sayac % 2 == 0)
    {
        toplam += sayac;
    }

    sayac++;
}

Console.WriteLine(toplam);
#endregion


#region Yöntem 2
int toplam1 = 0;
int sayac2 = 2;
while (sayac2 < 101)
{
    toplam1 += sayac2;
    sayac2 += 2;
}
Console.WriteLine(toplam1);
#endregion



// Kullanıcının girdiği sayıya kadar olan sayıların toplamını
#region MyRegion
//int sayi = 0;
//int sayac = 1;
//int toplam = 0;
//bool sonuc = false;

//while (!sonuc) // sonuc == false
//{
//    Console.Write("Sayı : ");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);
//}

////while (sayac <= sayi)
////{
////    toplam += sayac;
////    sayac++;
////}


//toplam = sayi * (sayi + 1) / 2;

//Console.WriteLine(toplam); 
#endregion


//1 ile 100 arasındaki asal sayıları ekrana yazdırın
int sayi = 2;

while (sayi <= 100)
{
    int bolen = 2;
    bool kontrol = false; // flag
    while (bolen <= sayi / 2)
    {
        if (sayi % bolen == 0)
        {
            kontrol = true;
            bolen = 100;
        }
        bolen++;
    }

    if (!kontrol)
    {
        Console.WriteLine(sayi);
    }

    sayi++;
}

Console.ReadKey();