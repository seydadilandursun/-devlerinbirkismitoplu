using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

List<int> numbers=new List<int>();
for (int i = 0; i < 20; i++)
{
        Console.WriteLine("Write a positive number,please!");
        try
        {
            int  n=int.Parse(Console.ReadLine());
            numbers.Add(n);

        //if (n <= 0) throw new Exception("The number you've written is not positive!");
        }
         catch (FormatException)
            {
                Console.Write("The number you've written is not integer.");}  
}

List<int> primenumbers=new List<int>();

foreach (var item in numbers)
{
    for(int j = 2; j<item; j++)
    {    
        if(item%j==0) primenumbers.Add(item); numbers.Remove(item) ;        
    }
}

// Buyukten kucuge yazdir
numbers.Sort();
primenumbers.Sort();

foreach (var item in numbers)  Console.WriteLine(item);
foreach (var item in primenumbers)  Console.WriteLine(item);
// ortalamayi bul
 int total=0;
foreach (var item in numbers) total=total+item; 
Console.WriteLine("The mean of non-prime numbers: {0} ",total/20);
int total2=0;
foreach (var item in primenumbers) total2=total2+item; 
Console.WriteLine("The mean of prime numbers: {0} ",total2/20);
