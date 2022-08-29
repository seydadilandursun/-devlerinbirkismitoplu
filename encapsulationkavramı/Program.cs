Ogrenci ogrenci=new Ogrenci();
ogrenci.Isim="Ayse";
ogrenci.Soyad="Yilmaz";
ogrenci.OgrenciNo=293;
ogrenci.Sinif=3;
ogrenci.OgrenciBilgileriniGetir();
ogrenci.SinifAtlat();
ogrenci.OgrenciBilgileriniGetir();

Ogrenci ogrenci1=new Ogrenci("Deniz","Arda",256,1);
ogrenci1.OgrenciBilgileriniGetir();
ogrenci1.SinifDusur();
ogrenci1.SinifDusur();
ogrenci.OgrenciBilgileriniGetir();

class Ogrenci
{
    private string isim;
    private string soyad;
    private int ogrenciNo;
    private int sinif;

    public string Isim { 
        get { return isim;}  
        set {isim=value;} 
        }

    public string Soyad { get => soyad; set => soyad = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif { 
        get => sinif; 
        set {  //1den kucuk olmamasi icin
              if(value<=1)
              {
                Console.WriteLine("Sinif En az 1 olabilir!");
              }
              else
              sinif = value; 
            } 
            }

    public Ogrenci(string isim, string soyad, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyad = soyad;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("*****Ogrenci Bilgileri");
        Console.WriteLine("Ogrenci Adi    :{0}",this.Isim);
        Console.WriteLine("Ogrenci SoyAdi :{0}",this.Soyad);
        Console.WriteLine("Ogrenci No     :{0}",this.OgrenciNo);
        Console.WriteLine("Ogrenci Sinifi :{0}",this.Sinif);
    }
     public void SinifAtlat()
    {
        this.Sinif= this.Sinif +1;
    }

    public void SinifDusur()
    {
        this.Sinif= this.Sinif -1;
        

    }
}