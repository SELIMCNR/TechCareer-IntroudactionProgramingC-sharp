using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //   ilkSoru();
        // ikinciSoru();
        // ucuncuSoru();
        dorduncuSoru();
    }
    public static void ilkSoru (){
        // 1.Kullanıcının girdiği sayının pozitif mi negatif mi yoksa sıfır mı olduğunu ekrana yazdırın.
        Console.WriteLine("Sayi giriniz : ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        if(sayi < 0)
        {
            Console.WriteLine("Sayi negatif {0}",sayi);
        }
        else if (sayi > 0)
        {

            Console.WriteLine("Sayi pozitif {0}",sayi);
        }
        else
        {
            Console.WriteLine("Sayi : {0}",sayi);
        }


    }

    public static void ikinciSoru()
    {
        // 2 .  Kullanıcının girdiği sayının faktöriyelini hesaplayıp ekrana yazdırın.
        int sayac = 1;
        int faktoriyel = 1;
        int n;
        Console.WriteLine("N değerini giriniz : ");
        n = int.Parse(Console.ReadLine());
        
        while(sayac <=n)
        {
            sayac++;
            faktoriyel = sayac * faktoriyel;
        }
        Console.WriteLine("Sayının faktoriyeli {0}",faktoriyel);
    }

    public static void ucuncuSoru()
    {
        /*Bir çağrı merkezinin otomatik band kaydı ile ilgili geliştirmeyi yapıyorsunuz. Kullanıcı İngilizce 
dinlemek istiyorsa 9 girecek. Türkçe devam ediyorsa ENTER diyip devam edecek. Ardından adını 
girmesini talep edeceksiniz. Adına hitaben bir selamlama cümlesi yazdıracaksınız.
*/
        int ingilizce = 9 ;
        string türkce = "Enter";
        string isim;
        string dinlemekİstenen;

        Console.WriteLine("İngilizce mi Türkce mi dinlemek istersiniz ? ");
        Console.WriteLine("İngilizce ise 9'a Türkce ise Entera basınız. ");

        dinlemekİstenen = Console.ReadLine();

        Console.WriteLine("İsim giriniz  ");
        isim = Console.ReadLine();

        if(dinlemekİstenen != türkce)
        {
            Console.WriteLine("Hello  {0} .",isim);
        }
        else
        {
            Console.WriteLine("Merhaba {0} .",isim);
        }


    }

    public static void dorduncuSoru()
    {
        /*
         Bir stok uygulamasında ürün ekleme kısmını yapacaksınız. Ürün eklenebilmesi için kullanıcının 
ürün adı, fiyatı ve stok bilgisini girmesi gerekiyor. Eğer fiyat bilgisi 2 liradan az girilirse uyarı 
vereceksiniz. Stok bilgisi negatif girilirse de uyarı vereceksiniz. Doğru değerler girdiği takdirde 
ürünün bilgilerini yazıp kaydedildiği bilgisini vereceksiniz.*/
        string ürünAdı;
        int fiyat;
        int stok;

        Console.WriteLine("Ürün adını giriniz ? ");
        ürünAdı = Console.ReadLine();

        Console.WriteLine("Fiyatı giriniz ");
        fiyat = int.Parse(Console.ReadLine());
        if(fiyat < 2)
        {
            Console.WriteLine("Fiyat bilgisi 2 liradan az girilemez");
            Console.WriteLine("Fiyatı giriniz ");
            fiyat = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("Stok adedini giriniz ");
        stok = int.Parse(Console.ReadLine());

        if(stok < 0)
        {
            Console.WriteLine("Stok adeti 0 dan küçük olamaz");
            Console.WriteLine("Stok adedini giriniz ");
            stok = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ürün adı : {0}",ürünAdı);
        Console.WriteLine("Fiyat : {0}",fiyat);
        Console.WriteLine("Adet sayısı: {0}",stok);


    }
}