//Kullanıcıdan ay gün yıl bilgilerini alıp doğum tarihini ve gününü ekrana yazdırın

Console.WriteLine("Doğum tarihinizi gün ay yıl şeklinde ayrı ayrı girin");

Console.Write("Gün: ");
string dayText = Console.ReadLine();
Console.Write("Ay: ");
string monthText = Console.ReadLine();
Console.Write("Yıl");
string yearText = Console.ReadLine();
int day2 = Convert.ToInt32(dayText);


// olması gereken bu
int day =int.Parse(dayText);
int month =int.Parse(monthText);
int year = int.Parse(yearText);

DateTime birthdate = new DateTime(year, month, day);
Console.WriteLine(birthdate);
Console.WriteLine(birthdate.DayOfWeek);


