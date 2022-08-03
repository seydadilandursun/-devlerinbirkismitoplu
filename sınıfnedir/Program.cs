//class SinifAdi
//{
//   [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
 //   [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
//    {
        //Metot Gövdesi
//    }
//}
// Erisim Belirleyiciler
// * Public
// * Private
// * Internal
// *Protected
Calisan calisan1= new Calisan();
calisan1.Ad="Ayse";
calisan1.Soyad="Kara";
calisan1.No=23426334;
calisan1.Departman="Insan Kaynaklari";
calisan1.CalisanBilgileri();
Console.WriteLine("****************");
Calisan calisan2=new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Arda";
calisan2.No=25646789;
calisan2.Departman="Satin Alim";
calisan2.CalisanBilgileri();

class Calisan 
{
    public string Ad;
    public string Soyad;

    public int No;

    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan adi:{0}",Ad);
        Console.WriteLine("Calisan soyadi:{0}",Soyad);
        Console.WriteLine("Calisan numarasi:{0}",No);
        Console.WriteLine("Calisan departmani:{0}",Departman);

    }
}