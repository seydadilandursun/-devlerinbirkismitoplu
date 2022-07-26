//1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
//Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
// Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

Console.WriteLine("Lüften pozitif bir sayı giriniz:");
int n= int.Parse(Console.ReadLine());


int[] sayilar2= new int[n];
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Lütfen {0} ıncı sayıyı giriniz adet sayı giriniz:",i+1);  
    sayilar2[i]=int.Parse(Console.ReadLine());
}

foreach (int sayi in sayilar2)
{
    if(sayi%2==0)
      Console.WriteLine(sayi);
}
