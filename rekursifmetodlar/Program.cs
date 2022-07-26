﻿class Program
{
    public static void Main(string[] args)
    {
        //Rekursif - Oz yinelemeli // Faktoriyel ust alma islemleri falan
       int result =1;
       for (int i = 1; i < 5; i++)
       {
              result=result*3;
       }
       Console.WriteLine(result);
       Islemler instance=new();
       Console.WriteLine(instance.Expo(3,4));

        //Extension Metotlar 
       string ifade="Seyda Dilan Dursun";
       bool sonuc=ifade.CheckSpaces();
       Console.WriteLine(sonuc);
       if (true)
            {
               Console.WriteLine(ifade.RemoveWhiteSpace()); 
            }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());
    
       int[] dizi={9,3,2,1,5,0};
       dizi.SortArray();
       dizi.EkranaYazdir();
    
       int sayi= 5;
       Console.WriteLine(sayi.IsEven());
       
       Console.WriteLine(ifade.GetFirstCharacter());

    }
}

    public class Islemler
     {
      public int Expo(int sayi, int ust)
      {
        if(ust<2)
           return sayi;
        return Expo(sayi,ust-1)*sayi;
      }  
    }
      //Expo[3,4]= Expo[3,3]*3=Expo[3,2]*3*3...
   
   public static class Extension
   {
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpace(this string param)
    {
        string[] dizi=param.Split(" ");
        return string.Join("*",dizi);
    }

         public static string MakeUpperCase(this string param)
    {
        return param.ToUpper( );
    }

         public static string MakeLowerCase(this string param)
    {
        return param.ToLower( );
    }
      
      public static int[] SortArray(this int[] param)
      {
         Array.Sort(param);
         return param;
      }

      public static void EkranaYazdir(this int[] param )
      {
        foreach (int item in param)
        Console.WriteLine(item);     
      }

       public static bool IsEven(this int param)
       {
         return param%2 == 0 ;
       }

       public static string GetFirstCharacter(this string param)
       {
        return param.Substring(0,1);
       }
   
   }