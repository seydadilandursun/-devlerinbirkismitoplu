//out parametreler
string sayi="999";
bool sonuc = int.TryParse(sayi, out int outSayi);
if(sonuc)
{
    Console.WriteLine("Basarili!");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Basarisiz");
}

Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonucu);
Console.WriteLine(toplamSonucu);
//Metot Asiri Yukleme = overloading
int ifade=999
instance.EkranaYazdir(Convert.ToString(ifade));
instance.EkranaYazdir(ifade);
instance.EkranaYazdir("Dilan", "Dursun");
//metod imzasi
//metotAd + parametre sayisi + parametre

class Metotlar
{
    public int Topla(int a,int b, out int toplam)
    {
        toplam=a+b;
    }

    public void EkranaYazdir(string veri )
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri )
    {
        Console.WriteLine(veri);
    }

     public void EkranaYazdir(string veri,string veri2 )
    {
        Console.WriteLine(veri+veri2);
    }
}
