//3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cumle giriniz:");
       string k= Convert.ToString(Console.ReadLine());


      patikaodev.harfkelimesay(k);
    }
}


public class patikaodev
{
  public static void harfkelimesay(string cumle)
  {
    int bosluk=1;
    int harfsay=0;
    foreach (char eleman in cumle)
   {
    if(eleman ==' ')
    {
        bosluk+=1;
    }
    else
    {
       harfsay++;
    }
   }
   Console.WriteLine("Girdiginiz cumle {0} kelimedir. " , bosluk);
   Console.WriteLine("Girdiginiz cumle {0} harften oluşmaktadir. " , harfsay);

  }
}