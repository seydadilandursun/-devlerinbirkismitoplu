using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    static void Main(string[] args)
    {
//list<T> class
//System.Collections.Generic
//T object turundedir
         
List<int> sayilistesi= new List<int>();

sayilistesi.Add(23);
sayilistesi.Add(10);
sayilistesi.Add(4);
sayilistesi.Add(5);
sayilistesi.Add(92);
sayilistesi.Add(34);

List<string> renklistesi= new List<string>();
renklistesi.Add("Kirmizi");
renklistesi.Add("Mavi");
renklistesi.Add("Turuncu");
renklistesi.Add("Sari");
renklistesi.Add("Yesil");

//Count
Console.WriteLine(renklistesi.Count);
Console.WriteLine(sayilistesi.Count);

foreach (var sayi in sayilistesi)
    Console.WriteLine(sayi);


foreach (var renk in renklistesi)
    Console.WriteLine(renk);

sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
renklistesi.ForEach(renk=>Console.WriteLine(renk));

//Listeden eleman cikarma
sayilistesi.Remove(4);
renklistesi.Remove("Yesil");

sayilistesi.RemoveAt(0);
renklistesi.RemoveAt(1);

sayilistesi.ForEach(sayi=>Console.WriteLine(sayi));
renklistesi.ForEach(renk=>Console.WriteLine(renk));

//Liste icerisinide arama 
if(sayilistesi.Contains(10))
  Console.WriteLine("10 liste icerisinde bulundu");
//Eleman ile indexe erisme
Console.WriteLine(renklistesi.BinarySearch("Sari"));

// Diziyi Liste  cevirme 
string[] hayvanlar={"Kedi","Kopek","Kus"};

List<string> hayvanlistesi= new List<string>(hayvanlar);
//Liste temizleme
hayvanlistesi.Clear();

// Liste icerisinde nesne nasil tutariz?
List<kullanicilar> kullaniciListesi= new List<kullanicilar>();
kullanicilar kullanici1 = new kullanicilar();
kullanici1.Isim="Ayse";
kullanici1.Soyad="Yilmaz";
kullanici1.Yas=26;

kullanicilar kullanici2 = new kullanicilar();
kullanici2.Isim="Ozcan";
kullanici2.Soyad="Caliskan";
kullanici2.Yas=26;

kullaniciListesi.Add(kullanici1);
kullaniciListesi.Add(kullanici2);

List<kullanicilar> yeniListe= new List<kullanicilar>();
yeniListe.Add(new kullanicilar(){
    Isim="Deniz",
    Soyad="Arda",
    Yas=24
});
foreach(var kullanici in kullaniciListesi)
{
    Console.WriteLine("Kullanici adi:"+kullanici.Isim);
    Console.WriteLine("Kullanici soyadi:"+kullanici.Soyad);
    Console.WriteLine("Kullanici yas:"+kullanici.Yas);
}

//yeniListe.Clear();
    }
    }
    public class kullanicilar
{
    private string isim;
    private string soyad;
    private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}