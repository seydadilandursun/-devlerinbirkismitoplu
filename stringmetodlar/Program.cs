string degisken="Dersimiz CSharp,Hosgeldiniz";
string degisken2="Dersimiz CSharp";

//Length
Console.WriteLine(degisken.Length);

//To Upper To Lower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat
Console.WriteLine(String.Concat(degisken,"Merhaba!"));

//Compare , CompareTo

Console.WriteLine(degisken.CompareTo(degisken2));//0,1,-1
Console.WriteLine(String.Compare(degisken,degisken2,true));//0,1,-1

// Contains
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hosgeldiniz"));
Console.WriteLine(degisken.StartsWith("Merhaba"));

//IndexOf
Console.WriteLine(degisken.IndexOf("Cs"));
Console.WriteLine(degisken.IndexOf("Zikriye"));

//Insert 
Console.WriteLine(degisken.Insert(0,"Merhaba"));
Console.WriteLine(degisken.LastIndexOf("i"));

//PadLeft, PadRight

Console.WriteLine(degisken+degisken2.PadLeft(30));
Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
Console.WriteLine(degisken.PadRight(50)+degisken2);
Console.WriteLine(degisken.PadLeft(50,'-')+degisken2);

//Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

//Replace 
Console.WriteLine(degisken.Replace("Csharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split
Console.WriteLine(degisken.Split(' ')[1]);

//Substring
Console.WriteLine(degisken.Substring(4));
Console.WriteLine(degisken.Substring(4,6));
