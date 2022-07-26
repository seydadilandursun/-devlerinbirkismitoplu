//3.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
//Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
//Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
int k= int.Parse(Console.ReadLine());
string[] dizi= new string[k];
for (int i = 0; i < k; i++)
{
    Console.WriteLine("Lütfen {0} ıncı kelimeyi giriniz:",i+1);  
    string kelime=Convert.ToString(Console.ReadLine());
    dizi[i]=kelime;
}

Console.WriteLine(string.Join(" ", dizi));