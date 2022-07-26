
//2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
//Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("Lüften pozitif bir sayı giriniz:");
int k= int.Parse(Console.ReadLine());
Console.WriteLine("Lüften pozitif bir sayı giriniz:");
int m= int.Parse(Console.ReadLine());
int[] sayilar2= new int[k];
for (int i = 0; i < k; i++)
{
    Console.WriteLine("Lütfen {0} ıncı sayıyı giriniz adet sayı giriniz:",i+1);  
    sayilar2[i]=int.Parse(Console.ReadLine());
}

foreach (int sayi in sayilar2)
{
    if(sayi%m==0)
      Console.WriteLine(sayi);
}

