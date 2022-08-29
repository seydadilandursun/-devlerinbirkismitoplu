//Soz Dizisi
//class SinifAdi
//{
// [Erisim Belirleyici] [Veri Tipi]  Ozellik Adi:
// [Erisim Belirleyici] [Geri Donu Tipi] Metot Adi([Parametre Listesi]) 
//   { 
//        Method Komutlari
//   }
//}

//Erisim Belirleyiciler
// *Public 
// *Private
// *Internal 
// *Protected
Console.WriteLine("*****Calisan 1*****");
Calisan calisan1=new Calisan("Ayse","Kara",23425634,"Insan Kaynaklari");
calisan1.CalisanBilgileri();
Console.WriteLine("*****Calisan 2*****");
Calisan calisan2=new Calisan();
calisan2.Ad="Deniz";
calisan2.Soyad="Arda";
calisan2.No=2564634;
calisan2.Departman="SatinAlma";
calisan2.CalisanBilgileri();
//Kurucu fonksiyonlar da overload olabilir.
Console.WriteLine("*****Calisan 3*****");
Calisan calisan3=new Calisan("Dilan","Dursun");
calisan3.CalisanBilgileri();
//Kurucu fonksiyonda o fonksiynun tum propertylerini tanimlanmadiya inte 0 stringe bos atama yapar bool ise false atar


class Calisan
{
    public string Ad;

    public string Soyad;

    public int No;

    public string Departman;
    

    public Calisan(){}
    public Calisan(string ad,string soyad,int no, string departman)
    {
        this.Ad=ad;
        this.Soyad=soyad;
        this.No=no;
        this.Departman=departman;
    }
      public Calisan(string ad,string soyad)
    {
        this.Ad=ad;
        this.Soyad=soyad;
    }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisanin Adi:{0}",Ad);
        Console.WriteLine("Calisanin Soyad:{0}",Soyad);
        Console.WriteLine("Calisanin Numarasi:{0}",No);
        Console.WriteLine("Calisanin Departmani:{0}",Departman);

    }
}