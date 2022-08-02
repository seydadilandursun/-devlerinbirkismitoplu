using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
        // her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve 
        //ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
        List<double> numbers = new List<double>();

        for (int i = 0; i < 20; i++)
        {

            Console.WriteLine("Write a number,please!");
            string str = Console.ReadLine(); 
            double d = double.Parse(str); 
            numbers.Add(d);
        }
         // Buyukten kucuge yazdir
        numbers.Sort();
        foreach (var item in numbers)
        {
        Console.WriteLine(item);
         }
       

        // ilk ve son uc sayi 
        List<double> ilkucsayi = numbers.GetRange(0, 3);
        List<double> sonucucsayi = numbers.GetRange(17,3 );

        int j = 0;
        double t1 = 0;
        double t2 = 0;
        while (j < 3)
        {
            t1 = t1 + ilkucsayi[j];
            t2 = t2 + sonucucsayi[j];
            j++;
        }
        Console.WriteLine("Total of The smallest 3 numbers in the numbers set you selected is: " + t1);
        Console.WriteLine("Total of the biggest 3 numbers in the numbers set you selected is: " + t2);
        Console.WriteLine("Mean of The smallest 3 numbers in the numbers set you selected is: " + t1 / 3);
        Console.WriteLine("Mean of The biggest 3 numbers in the numbers you selected is: " + t2 / 3);
        Console.WriteLine("Total of the mean of the smallest 3 and the biggest 3 numbers set in numbers you selected is: " + (t1 + t2) / 3);
    }
}