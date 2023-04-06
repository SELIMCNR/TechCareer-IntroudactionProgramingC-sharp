
//do
//{
//    kodlar
//}
//while (koşul);

#region While vs. DoWhile
//int counter = 10;
//while (counter < 5)
//{
//    Console.WriteLine(counter);
//    counter--;
//}

//do
//{
//    Console.WriteLine(counter);
//    counter--;
//} while (counter < 5);


#endregion


//Console.Write("Kullanıcı Adı : ");
//string username = Console.ReadLine();
//Console.Write("Şifre : ");
//string password = Console.ReadLine();

//while (username != "admin" || password != "123")
//{
//    Console.Write("Kullanıcı Adı : ");
//    username = Console.ReadLine();
//    Console.Write("Şifre : ");
//    password = Console.ReadLine();
//}


//string username, password;

//do
//{
//    Console.Write("Kullanıcı Adı : ");
//    username = Console.ReadLine();
//    Console.Write("Şifre : ");
//    password = Console.ReadLine();
//} while (username != "admin" || password != "123");



// Kullanıcı bilinçli bir şekilde 0 girene kadar girdiği sayıları toplayıp ekrana yazdırın
#region MyRegion
//int sum = 0;
//int number = 0;
//bool isParsed = false;

//do
//{
//    Console.Write("Sayı : ");
//    isParsed = int.TryParse(Console.ReadLine(), out number);
//    if (!isParsed)
//    {
//        Console.WriteLine("Sayı girin");
//    }
//    sum += number;
//} while (number != 0 || !isParsed);

//Console.WriteLine($"Toplam : {sum}"); 
#endregion



// Kullanıcı "ok" yazana kadar girdiği sayıların toplamı
#region MyRegion
//string value = "";
//int number = 0;
//int sum = 0;
//bool isParsed = false;

//do
//{
//    Console.WriteLine("Sayı girin. Sonlandırmak için ok yazın");
//    value = Console.ReadLine();

//    isParsed = int.TryParse(value, out number);
//    if (!isParsed && value != "ok")
//    {
//        Console.WriteLine("ok dışında metinsel bir ifade yazılamaz");
//    }
//    sum += number;
//} while (value != "ok" || value != "OK");

//#region MyRegion
////if (sum != 0)
////{
////    Console.WriteLine($"Toplam : {sum}");
////}
////else
////{
////    Console.WriteLine("Toplam oluşmadı");
////} 
//#endregion


//// Ternary Operator

//Console.WriteLine(sum != 0 ? $"Toplam:{sum}" : "Toplam oluşmadı"); 
#endregion



//Kullanıcıdan iki tane sayı alın. Bu iki sayı arasında rastgele 500 tane sayı üretin. Bu sayılardan tek olanların toplamını ekrana yazdırın.
int firstNumber, secondNumber, temp;
bool firstCheck, secondCheck;

Console.Write("Küçük sayı : ");
firstCheck = int.TryParse(Console.ReadLine(), out firstNumber);
Console.Write("Büyük sayı : ");
secondCheck = int.TryParse(Console.ReadLine(), out secondNumber);

#region MyRegion
//if (firstCheck && secondCheck && (secondNumber - firstNumber) >= 2)
//{
//    Random rnd = new Random();
//    int number = 0,
//        sum = 0,
//        counter = 1;

//    while (counter <= 500)
//    {
//        number = rnd.Next(firstNumber, secondNumber + 1);
//        if (number % 2 == 1)
//        {
//            sum += number;
//        }
//        counter++;
//    }

//    Console.WriteLine(sum);
//}
//else
//{
//    Console.WriteLine("Hatalı giriş yaptınız");
//} 
#endregion

if (firstCheck && secondCheck)
{
    if (firstNumber > secondNumber)
    {
        temp = secondNumber;
        secondNumber = firstNumber;
        firstNumber = temp;
    }

    if (secondNumber - firstNumber >= 2)
    {
        Random rnd = new Random();
        int number = 0,
            sum = 0,
            counter = 1;

        while (counter <= 500)
        {
            number = rnd.Next(firstNumber, secondNumber + 1);
            if (number % 2 == 1)
            {
                sum += number;
            }
            counter++;
        }

        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine("En az 2 fark olmalı");
    }
}
else
{
    Console.WriteLine("Hatalı giriş yaptınız");
}


Console.ReadKey();