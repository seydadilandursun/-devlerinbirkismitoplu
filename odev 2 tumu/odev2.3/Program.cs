using System;
using System.Collections;
using System.Collections.Generic;


Console.WriteLine("Lutfen bir cumle giriniz:");
string mysentence=Console.ReadLine();
UnluHarfKontrol instance=new();
ArrayList d=instance.ContainsVowel(mysentence);
foreach (var item in d)
{
    Console.WriteLine(item);
}






public class UnluHarfKontrol 
{
   
    private char[] vowels = new [] { 'a', 'A', 'e', 'E', 'ı', 'I', 'i', 'İ', 'o', 'O', 'u', 'U' ,'ü', 'Ü'};

    public ArrayList ContainsVowel(string sentence)
    {
        ArrayList vowelsinsentence= new ArrayList();
        foreach (char vowel in vowels)
        {
            if (sentence.Contains(vowel))
            {
             vowelsinsentence.Add(vowel);  
             vowelsinsentence.Sort();           
            }

        }
        return vowelsinsentence;
    }
}

