/*
    1.Syntax  =>  Compiling Time  yazma zamanı hatası 
//Sağ tuş build ile derlenir. ctrl + shift + b
//Console.ReadKey()
    
    2.Syntax  => Runtime çalışma zamanı hatası 
    
    Debug : Denemeler yapılır 
    Relase :  işlem bitince yapılan derleme sonuçlanır.

    3.Logical => Mantık hatası
 */

using System.ComponentModel.DataAnnotations.Schema;

int sayi = 100;
byte number = Convert.ToByte(sayi);


//Exception Handle
try
{
    int number1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Girilen sayı : {number1}");
}
catch (Exception ex)
{
    Console.WriteLine("Düzgün değer gir");
    //loglama işlemi
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.Source);
    Console.WriteLine(ex.StackTrace);
    if (ex.InnerException != null) //is not null
    {
        Console.WriteLine(ex.InnerException.Message); // alt mödülleri hataları yakar
    }
    Console.WriteLine( ex.ToString());
}

/*
try
{
    database.Connect();

}
catch
{
    //loglama

}
finally
{
    database.Disconnet(); // her türlü databaseyi kapatır.
}
*/

try
{
    byte number3 = byte.Parse(Console.ReadLine());
    if (number3 >50 || number3<30)
    {
        throw new Exception("50 ile 30 arasında değer girilmedi.");  //hata yoladık
    }
    
}
catch(FormatException fxd)
{
    Console.WriteLine("Harf girdin");
    Console.WriteLine(fxd.Message);
}
catch (OverflowException oxf)
{
    //Veritipini aşan değer.
    Console.WriteLine(oxf.Message);
}
catch(Exception ex)
{ 
    throw; // yollanan hatayı aldık
    Console.WriteLine(ex.Message);
}


Console.ReadKey();