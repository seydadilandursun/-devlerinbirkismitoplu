Dikdortgen dikdortgen = new Dikdortgen();
//dikdortgen.KisaKenar= 3;
//dikdortgen.UzunKenar= 4;
Console.WriteLine("Class Alan Hesabi: {0}",dikdortgen.AlanHesabi());

//Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
//dikdortgen_struct.KisaKenar= 3;
//dikdortgen_struct.UzunKenar= 4;

//Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,4);
//Console.WriteLine("Struct Alan Hesabi: {0}",dikdortgen_struct.AlanHesapla());
Dikdortgen_Struct dikdortgen_struct;
//dikdortgen_struct.KisaKenar= 3;
//dikdortgen_struct.UzunKenar= 4;
Console.WriteLine("Struct Alan Hesabi: {0}",dikdortgen_struct.AlanHesapla());





class Dikdortgen
{
    public int KisaKenar;

    public int UzunKenar;

  //  public Dikdortgen()
  //  {
  //      KisaKenar=3;
  //      UzunKenar=4;
  //  }
    public long AlanHesabi()
    {
        return this.KisaKenar*this.UzunKenar;
    }
}
struct Dikdortgen_Struct
{
       public int KisaKenar;
       public int UzunKenar;

    public Dikdortgen(int kisaKenar, int uzunKenar)
    {
        KisaKenar = 3;
        UzunKenar = 4;
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }
    public long AlanHesapla()
       {
         return this.KisaKenar*this.UzunKenar;
       }


}