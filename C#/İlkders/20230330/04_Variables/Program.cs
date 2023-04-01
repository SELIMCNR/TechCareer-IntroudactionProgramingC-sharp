
#region //Değişken tanımlama kuralları 
/* 1-> Clean code kavramına uygun isimlendirilir temiz kod ödevde istenir
 * 2-> Değişkenler rakamla başlayamaz hata verir. int 1sayi denilmez
 * 3-> _ dışında bir karakterle başlayamaz . _sayi=15 olur ?sayi=16 olmaz.
 * 4-> Birden fazla kelimeden oluşamaz.camelCase deve yazım snake_case yılan yazım şekillerinde yazılır.ad-soyad kebap yazımı c#'da yok.
 * 5-> Reserved  keyword'ler isim olamazlar. string,int,if,else gibi illa yapacam diyorsan başına @ işareti koymalısın.
 * 6-> C# case sentetive bir dildir.kucuk sayi ile buyuk Sayi farklıdır.
 * */
#endregion

//default değerleri vardır tiplerin.
Console.WriteLine(default(int));

//null boş dır.
string metin = null;
object a = null;
// hata veriri primitive değer tiplerde  long c = null;
//primitive tiplerde boş yazdırma
int b = 0;
char c = ' ';


//Scope
int sayi = 10; //global scope
{
    string isim = "";// local scope 
}
// Console.WriteLine(isim); hata verir scope dışında olduğundan.
{
    int isim = 0; //local scope
}
