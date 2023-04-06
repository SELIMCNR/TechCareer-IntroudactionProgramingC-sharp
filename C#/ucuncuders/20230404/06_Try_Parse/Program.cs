string str = "abc";
int number = 0;

//try parse deniyor değişkenler birbirine çeviriliyor mu diye ? 
bool result = int.TryParse(str, out number);
Console.WriteLine(result);
Console.WriteLine(number);

Console.ReadKey();