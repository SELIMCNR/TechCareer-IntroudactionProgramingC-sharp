#region //alan gibi düşün
// Yorum satırıdır.

/*
 Çoklu yorum satırıdır.

 */
//Intellisense kod tamamlayıcı
#endregion

#region // yazdırma komutları
Console.Write("a"); // aynı satırda yazar 
Console.WriteLine("Merhaba Dünya"); // alt satırdan yeni satırdan devam et
#endregion

#region //dışardan değer alma
//Kullanıcıdan değer alma
Console.ReadLine();//Kullanıcı birşeyyazana kadar bekle hepsini okur örnek aba string
Console.Read(); // tek bir değer okur örnek a
//Kaybolan kodlarda ctrl + space yap integer
Console.ReadKey(); // herhangi bir tuşa basar basmaz gider 


#endregion

#region //dışardan değer alma yazdırma
//Kullanıcıdan değer alma yazdırma
Console.WriteLine(Console.ReadLine());
Console.WriteLine(Console.Read());
Console.WriteLine(Console.ReadKey().KeyChar);  //keychar ile bir tane daha harf atar

Console.ReadKey();

#endregion