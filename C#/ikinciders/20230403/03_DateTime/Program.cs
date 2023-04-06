// See https://aka.ms/new-console-template for more information
var birthdate = new DateTime(2023, 10, 27);

Console.WriteLine(birthdate.ToLongTimeString);
Console.WriteLine(birthdate.ToString());
Console.WriteLine(birthdate.Year);
Console.WriteLine(birthdate.Minute);
Console.WriteLine(birthdate.ToLongDateString);



Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.UtcNow);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);
Console.WriteLine(DateTime.Now.Millisecond);

Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Today);
Console.WriteLine(DateTime.Now.DayOfYear);
Console.WriteLine(DateTime.Now.DayOfWeek);


Console.WriteLine(DateTime.IsLeapYear(2023)); //artık yıl mı değil mi 

DateOnly date = new DateOnly(2023, 10, 27);
TimeOnly time = new TimeOnly(14, 30);

DateTime date1 = DateTime.Now.AddDays(5); // 5 gün ekle -5 5 gün sil
Console.WriteLine(date1);

DateTime now = DateTime.Now;

TimeSpan diff= date1 - now; // aradaki fark
Console.WriteLine(diff.Days);
Console.WriteLine(diff.TotalDays);
Console.WriteLine(diff.TotalHours);

Console.WriteLine(DateTime.Now.Ticks);



Console.ReadKey();