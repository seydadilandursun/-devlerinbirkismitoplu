﻿//erisim belirteci geri_donustipi metod_adi(parametreListesi/arguman)
//{  
 ////komutlar;
// return;
//}
int a=2;
int b=3;

Console.WriteLine(a+b);
int sonuc = Topla(ref a,ref b);
Console.WriteLine(sonuc);

Metotlar ornek = new Metotlar();
 ornek.EkranaYazdir(Convert.ToString(sonuc));
 Console.WriteLine(a+b);
 int sonuc2=ornek.ArttirveTopla( a, b);
 Console.WriteLine(a+b);
 

   static int Topla(ref int deger1,ref int deger2)
  {
   return (deger1+deger2);
  }

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public int ArttirveTopla(int deger1, int deger2)
    {
     deger1+=1;
     deger2+=1;
     return deger1+deger2;

    }
}