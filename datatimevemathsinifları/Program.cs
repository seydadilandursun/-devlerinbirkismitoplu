﻿Console.WriteLine(DateTime.Now);//gunun tarihi
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine(DateTime.Now.DayOfWeek);
Console.WriteLine(DateTime.Now.DayOfYear);

Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());

Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(3));
Console.WriteLine(DateTime.Now.AddSeconds(30));
Console.WriteLine(DateTime.Now.AddMonths(5));
Console.WriteLine(DateTime.Now.AddYears(10));
Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//Date.Time Format

Console.WriteLine(DateTime.Now.ToString("dd")); //24
Console.WriteLine(DateTime.Now.ToString("ddd")); //Sat
Console.WriteLine(DateTime.Now.ToString("dddd")); //Saturday

Console.WriteLine(DateTime.Now.ToString("MM")); //04
Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
Console.WriteLine(DateTime.Now.ToString("MMM")); //April

Console.WriteLine(DateTime.Now.ToString("yy")); //21
Console.WriteLine(DateTime.Now.ToString("yyy")); //2021

//Math Kutuphanesi 
Console.WriteLine("***Math Kutuphanesi**");
Console.WriteLine(Math.Abs(=25));// 25
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));

Console.WriteLine(Math.Ceiling(22.3));//23
Console.WriteLine(Math.Round(22.3));//22
Console.WriteLine(Math.Floor(22.7));//asagi yuvarlart

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));
Console.WriteLine(Math.Pow(2,6));//3 uzeri 4u verir
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Log(9));//(un e tabanindaki logaritmik karsiligini getirir)
Console.WriteLine(Math.Exp(3));//e uzeri 3u verir
Console.WriteLine(Math.Log10(10));//10 sayisinin logaritma 10 tabanindaki karsiligi





