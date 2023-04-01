
#region //Başlangıç projesi seçimi ayarları
//Solution set up start op project ile ilk bu açılsın denebilir.

//Solution configure start up project ile iki iki farklı program çalıştırılabilir.
#endregion

#region //sayı tipde veri yazdırma
//sayı tipde veri yazdırma
Console.WriteLine(10);

#endregion

#region
//placeholder yer tutucu 
//0.indis,1.indis,2.indis olarak yer tutar
Console.WriteLine("{0} + {1} = {2}",3,5,3+5);
Console.WriteLine("{0} + {1} = {2} -> ikinciindis: {1}", 3, 5, 3 + 5);
Console.WriteLine("{0} {1} or not {0} {1}","to","be");

//string interpolation
Console.WriteLine($"{"to"},{"be"} or not {"to"} {"be"} {5}");
Console.WriteLine($"{3} + {5} = {3+5}");



#endregion
Console.ReadKey();